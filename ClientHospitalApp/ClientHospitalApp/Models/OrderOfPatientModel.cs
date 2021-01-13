using AutoMapper;
using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class OrderOfPatientModel: IOrderOfPatientModel
    {
        private OrderOfPatientClient order;
        private List<OrderOfPatientClient> listOrders;
        private WebServiceHospitalSoapClient service;
        BindingList<OrderOfPatientClient> orderList;
        private List<OrderOfPatientClient> listToAdd;
        private List<OrderOfPatientClient> listToUpdate;
        private List<OrderOfPatientClient> listToDelete;

        public OrderOfPatientClient Order
        {
            get => order;
            set => order = value;
        }
        public List<OrderOfPatientClient> ListOrders
        {
            get => listOrders;
            set => listOrders = value;
        }
        public BindingList<OrderOfPatientClient> OrderList
        {
            get => orderList;
            set => orderList = value;
        }
        public List<OrderOfPatientClient> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List<OrderOfPatientClient> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List<OrderOfPatientClient> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }

        IOrderOfPatientModel orderModel;

        public OrderOfPatientModel()
        {
            Order = new OrderOfPatientClient();
            ListOrders = new List<OrderOfPatientClient>();
            service = new WebServiceHospitalSoapClient();
            ListToAdd = new List<OrderOfPatientClient>();
            ListToUpdate = new List<OrderOfPatientClient>();
            ListToDelete = new List<OrderOfPatientClient>();
            orderModel = this;
        }

        public void GetAllOrders()
        {
            ListOrders = service.GetDataAllOrders().ToList();
        }





        private OrderOfPatientClient ConvertOrderToOrderClient(OrderOfPatient order)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderOfPatient, OrderOfPatientClient>();
            });

            IMapper iMapper = config.CreateMapper();
            OrderOfPatientClient newOrder = iMapper.Map<OrderOfPatient, OrderOfPatientClient>(order);

            return newOrder;
        }

        private List<OrderOfPatientClient> ConvertOrderToOrderClient(List<OrderOfPatient> orderList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderOfPatient, OrderOfPatientClient>();
            });

            IMapper iMapper = config.CreateMapper();
            foreach (OrderOfPatient item in orderList)
            {
                OrderOfPatientClient newOrder = iMapper.Map<OrderOfPatient, OrderOfPatientClient>(item);
                ListOrders.Add(newOrder);
            }
            return ListOrders;
        }

        private OrderOfPatient ConvertOrderClientToOrder(OrderOfPatientClient order)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderOfPatientClient, OrderOfPatient>();
            });

            IMapper iMapper = config.CreateMapper();
            OrderOfPatient newOrder = iMapper.Map<OrderOfPatientClient, OrderOfPatient>(order);

            return newOrder;
        }
        private List<OrderOfPatient> ConvertOrderClientToOrder(List<OrderOfPatientClient> orderList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<OrderOfPatientClient, OrderOfPatient>();
            });

            IMapper iMapper = config.CreateMapper();

            List<OrderOfPatient> lstOrd = new List<OrderOfPatient>();
            foreach (OrderOfPatientClient item in orderList)
            {
                OrderOfPatient newOrder = iMapper.Map<OrderOfPatientClient, OrderOfPatient>(item);
                lstOrd.Add(newOrder);
            }

            return lstOrd;
        }

        void IOrderOfPatientModel.AddOrder()
        {
            service.AddOrder(ConvertPatientClientToPatient(ListToAdd).ToArray());
        }

        public void GetAllPatients()
        {
            List<Patient> lp = new List<Patient>();
            lp = service.GetDataAllPatients().ToList();

            ListPatients = ConvertPatientToPatientClient(lp);
            FillPatientList();
        }

        public void FillPatientList()
        {
            PatientList = new BindingList<PatientClient>(ListPatients);
            PatientList.AllowNew = true;
            PatientList.AllowEdit = true;
            PatientList.AllowRemove = true;
            PatientList.RaiseListChangedEvents = true;
            PatientList.ListChanged += new ListChangedEventHandler(PatientList_ListChanged);
        }

        void IPatientModel.UpdatePatient()
        {
            service.UpdatePatient(ConvertPatientClientToPatient(ListToUpdate).ToArray());
        }

        void IPatientModel.DeletePatient()
        {
            service.DeletePatient(ConvertPatientClientToPatient(ListToDelete).ToArray());
        }
        public void GetRelativesOfPatient(PatientClient ptnt)
        {
            Patient temp = ConvertPatientClientToPatient(ptnt);
            patient.RelativeList = service.GetRelativesOfPatient(temp).ToList();
        }

        public void SaveDataOfPatient()
        {
            if (ListToAdd.Count > 0)
            {
                patientModel.AddPatient();
                ListToAdd.Clear();
            }

            if (ListToUpdate.Count > 0)
            {
                patientModel.UpdatePatient();
                ListToUpdate.Clear();
            }

            if (ListToDelete.Count > 0)
            {
                patientModel.DeletePatient();
                ListToDelete.Clear();
            }
        }

        void PatientList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ListChangedType.ItemAdded == e.ListChangedType)
            {
                ListToAdd.Add(PatientList[e.NewIndex]);
            }
            else if (ListChangedType.ItemChanged == e.ListChangedType)
            {
                if (PatientList[e.NewIndex].ID_Patient > 0)  //это пациент из базы
                {
                    patientModel.ListToUpdate.Add(PatientList[e.NewIndex]);
                }
                else //это пациент из грида,он еще не сохранен в базе
                {
                    for (int i = 0; i < ListToAdd.Count; i++)
                    {
                        if (ListToAdd[i].Equals(Patient))
                        {
                            ListToAdd[i] = PatientList[e.NewIndex];
                        }
                    }
                    Patient = null;
                }
            }
            else if (ListChangedType.ItemDeleted == e.ListChangedType)
            {
                if (ListPatients.Contains(Patient))
                {
                    ListToDelete.Add(Patient);
                }
                else
                {
                    ListToAdd.Remove(Patient);
                }
                Patient = null;
            }
        }

    }
}
