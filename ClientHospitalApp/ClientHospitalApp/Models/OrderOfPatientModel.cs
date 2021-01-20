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
        private List<OrderOfPatient> listOrdersForSpeciment;

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
        public List<OrderOfPatient> ListOrdersForSpeciment
        {
            get => listOrdersForSpeciment;
            set => listOrdersForSpeciment = value;
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

        public void GetAllOrders()
        {
            List<OrderOfPatient> lOrd = new List<OrderOfPatient>();
            lOrd = service.GetDataAllOrders().ToList();
            ListOrdersForSpeciment = lOrd;

            ListOrders = ConvertOrderToOrderClient(lOrd);
            FillOrderList();
        }

        void IOrderOfPatientModel.AddOrder()
        {
            service.AddOrder(ConvertOrderClientToOrder(ListToAdd).ToArray());
        }

        void IOrderOfPatientModel.UpdateOrder()
        {
            service.UpdateOrder(ConvertOrderClientToOrder(ListToUpdate).ToArray());
        }

        void IOrderOfPatientModel.DeleteOrder()
        {
            service.DeleteOrder(ConvertOrderClientToOrder(ListToDelete).ToArray());
        }

        public void FillOrderList()
        {
            OrderList = new BindingList<OrderOfPatientClient>(ListOrders);
            OrderList.AllowNew = true;
            OrderList.AllowEdit = true;
            OrderList.AllowRemove = true;
            OrderList.RaiseListChangedEvents = true;
            OrderList.ListChanged += new ListChangedEventHandler(OrderList_ListChanged);
        }

        public void SaveDataOfOrder()
        {
            if (ListToAdd.Count > 0)
            {
                orderModel.AddOrder();
                ListToAdd.Clear();
            }

            if (ListToUpdate.Count > 0)
            {
                orderModel.UpdateOrder();
                ListToUpdate.Clear();
            }

            if (ListToDelete.Count > 0)
            {
                orderModel.DeleteOrder();
                ListToDelete.Clear();
            }
        }

        void OrderList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ListChangedType.ItemAdded == e.ListChangedType)
            {
                ListToAdd.Add(OrderList[e.NewIndex]);
            }
            else if (ListChangedType.ItemChanged == e.ListChangedType)
            {
                if (OrderList[e.NewIndex].ID_Order > 0)  //это ордер из базы
                {
                    orderModel.ListToUpdate.Add(OrderList[e.NewIndex]);
                }
                else //это ордер из грида,он еще не сохранен в базе
                {
                    for (int i = 0; i < ListToAdd.Count; i++)
                    {
                        if (ListToAdd[i].Equals(Order))
                        {
                            ListToAdd[i] = OrderList[e.NewIndex];
                        }
                    }
                    Order = null;
                }
            }
            else if (ListChangedType.ItemDeleted == e.ListChangedType)
            {
                if (ListOrders.Contains(Order))
                {
                    ListToDelete.Add(Order);
                }
                else
                {
                    ListToAdd.Remove(Order);
                }
                Order = null;
            }
        }

    }
}
