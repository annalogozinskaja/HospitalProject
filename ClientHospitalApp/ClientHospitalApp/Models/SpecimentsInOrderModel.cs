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
   public  class SpecimentsInOrderModel: ISpecimentsInOrderModel
    {
        private SpecimentsInOrderClient speciment;
        private List<SpecimentsInOrderClient> listSpeciments;
        private WebServiceHospitalSoapClient service;
        BindingList<SpecimentsInOrderClient> specimentList;
        private List<SpecimentsInOrderClient> listToAdd;
        private List<SpecimentsInOrderClient> listToUpdate;
        private List<SpecimentsInOrderClient> listToDelete;
        ISpecimentsInOrderModel specimentModel;

        public SpecimentsInOrderClient Speciment
        {
            get => speciment;
            set => speciment = value;
        }
        public List<SpecimentsInOrderClient> ListSpeciments
        {
            get => listSpeciments;
            set => listSpeciments = value;
        }
        public BindingList<SpecimentsInOrderClient> SpecimentList
        {
            get => specimentList;
            set => specimentList = value;
        }
        public List<SpecimentsInOrderClient> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List<SpecimentsInOrderClient> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List<SpecimentsInOrderClient> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }      

        public SpecimentsInOrderModel()
        {
            Speciment = new SpecimentsInOrderClient();
            ListSpeciments = new List<SpecimentsInOrderClient>();
            service = new WebServiceHospitalSoapClient();
            ListToAdd = new List<SpecimentsInOrderClient>();
            ListToUpdate = new List<SpecimentsInOrderClient>();
            ListToDelete = new List<SpecimentsInOrderClient>();
            specimentModel = this;
        }

        //private SpecimentsInOrderClient ConvertSpecimentsInOrderToSpecimentsInOrderClient(SpecimentsInOrder speciment)
        //{
        //    MapperConfiguration config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<SpecimentsInOrder, SpecimentsInOrderClient>();
        //    });

        //    IMapper iMapper = config.CreateMapper();
        //    SpecimentsInOrderClient newSpeciment = iMapper.Map<SpecimentsInOrder, SpecimentsInOrderClient>(speciment);

        //    return newSpeciment;
        //}

        private List<SpecimentsInOrderClient> ConvertSpecimentsInOrderToSpecimentsInOrderClient(List<SpecimentsInOrder> specimentList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SpecimentsInOrder, SpecimentsInOrderClient>();
            });

            IMapper iMapper = config.CreateMapper();
            foreach (SpecimentsInOrder item in specimentList)
            {
                SpecimentsInOrderClient newSpeciment = iMapper.Map<SpecimentsInOrder, SpecimentsInOrderClient>(item);
                ListSpeciments.Add(newSpeciment);
            }
            return ListSpeciments;
        }

        //private SpecimentsInOrder ConvertSpecimentsInOrderClientToSpecimentsInOrder(SpecimentsInOrderClient speciment)
        //{
        //    MapperConfiguration config = new MapperConfiguration(cfg =>
        //    {
        //        cfg.CreateMap<SpecimentsInOrderClient, SpecimentsInOrder>();
        //    });

        //    IMapper iMapper = config.CreateMapper();
        //    SpecimentsInOrder newSpeciment = iMapper.Map<SpecimentsInOrderClient, SpecimentsInOrder>(speciment);

        //    return newSpeciment;
        //}
        private List<SpecimentsInOrder> ConvertSpecimentsInOrderClientToSpecimentsInOrder(List<SpecimentsInOrderClient> specimentList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<SpecimentsInOrderClient, SpecimentsInOrder>();
            });

            IMapper iMapper = config.CreateMapper();

            List<SpecimentsInOrder> lstSpcmnts = new List<SpecimentsInOrder>();
            foreach (SpecimentsInOrderClient item in specimentList)
            {
                SpecimentsInOrder newSpeciment = iMapper.Map<SpecimentsInOrderClient, SpecimentsInOrder>(item);
                lstSpcmnts.Add(newSpeciment);
            }

            return lstSpcmnts;
        }

        void ISpecimentsInOrderModel.AddSpeciment()
        {
            service.AddSpeciment(ConvertSpecimentsInOrderClientToSpecimentsInOrder(ListToAdd).ToArray());
        }

        void ISpecimentsInOrderModel.UpdateSpeciment()
        {
            service.UpdateSpeciment(ConvertSpecimentsInOrderClientToSpecimentsInOrder(ListToUpdate).ToArray());
        }

        void ISpecimentsInOrderModel.DeleteSpeciment()
        {
            service.DeleteSpeciment(ConvertSpecimentsInOrderClientToSpecimentsInOrder(ListToDelete).ToArray());
        }

        public void GetAllSpeciments()
        {
            List<SpecimentsInOrder> lsp = new List<SpecimentsInOrder>();
            lsp = service.GetDataAllSpeciments().ToList();

            ListSpeciments = ConvertSpecimentsInOrderToSpecimentsInOrderClient(lsp);
            FillSpecimentList();
        }

        public void FillSpecimentList()
        {
            SpecimentList = new BindingList<SpecimentsInOrderClient>(ListSpeciments);
            SpecimentList.AllowNew = true;
            SpecimentList.AllowEdit = true;
            SpecimentList.AllowRemove = true;
            SpecimentList.RaiseListChangedEvents = true;
            SpecimentList.ListChanged += new ListChangedEventHandler(SpecimentList_ListChanged);
        }

        public void SaveDataOfSpeciment()
        {
            if (ListToAdd.Count > 0)
            {
                specimentModel.AddSpeciment();
                ListToAdd.Clear();
            }

            if (ListToUpdate.Count > 0)
            {
                specimentModel.UpdateSpeciment();
                ListToUpdate.Clear();
            }

            if (ListToDelete.Count > 0)
            {
                specimentModel.DeleteSpeciment();
                ListToDelete.Clear();
            }
        }

        void SpecimentList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ListChangedType.ItemAdded == e.ListChangedType)
            {
                ListToAdd.Add(SpecimentList[e.NewIndex]);
            }
            else if (ListChangedType.ItemChanged == e.ListChangedType)
            {
                if (SpecimentList[e.NewIndex].ID_SpecimentOrder > 0)  //это спесимент из базы
                {
                    ListToUpdate.Add(SpecimentList[e.NewIndex]);
                }
                else //это спесимент из грида,он еще не сохранен в базе
                {
                    for (int i = 0; i < ListToAdd.Count; i++)
                    {
                        if (ListToAdd[i].Equals(Speciment))
                        {
                            ListToAdd[i] = SpecimentList[e.NewIndex];
                        }
                    }
                    Speciment = null;
                }
            }
            else if (ListChangedType.ItemDeleted == e.ListChangedType)
            {
                if (Speciment.ID_SpecimentOrder>0)
                {
                    ListToDelete.Add(Speciment);
                }
                else
                {
                    ListToAdd.Remove(Speciment);
                }
                Speciment = null;
            }
        }
    }
}
