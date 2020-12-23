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
        private SpecimentsInOrder speciment;
        private List<SpecimentsInOrder> listSpeciments;
        private WebServiceHospitalSoapClient obj;
        BindingList<SpecimentsInOrder> specimentList;
        private List<SpecimentsInOrder> listToAdd;
        private List<SpecimentsInOrder> listToUpdate;
        private List<SpecimentsInOrder> listToDelete;
        ISpecimentsInOrderModel specimentModel;

        public SpecimentsInOrder Speciment
        {
            get => speciment;
            set => speciment = value;
        }
        public List<SpecimentsInOrder> ListSpeciments
        {
            get => listSpeciments;
            set => listSpeciments = value;
        }
        public BindingList<SpecimentsInOrder> SpecimentList
        {
            get => specimentList;
            set => specimentList = value;
        }
        public List<SpecimentsInOrder> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List<SpecimentsInOrder> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List<SpecimentsInOrder> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }      

        public SpecimentsInOrderModel()
        {
            Speciment = new SpecimentsInOrder();
            ListSpeciments = new List<SpecimentsInOrder>();
            obj = new WebServiceHospitalSoapClient();
            ListToAdd = new List<SpecimentsInOrder>();
            ListToUpdate = new List<SpecimentsInOrder>();
            ListToDelete = new List<SpecimentsInOrder>();
            specimentModel = this;
        }

        //public void GetSpeciment(int IdSpeciment)
        //{          
        //    Speciment = obj.GetDataSpeciment(IdSpeciment);
        //}

        void ISpecimentsInOrderModel.AddSpeciment()
        {
            obj.AddSpeciment(ListToAdd.ToArray());
        }

        void ISpecimentsInOrderModel.UpdateSpeciment()
        {
            obj.UpdateSpeciment(ListToUpdate.ToArray());
        }

        void ISpecimentsInOrderModel.DeleteSpeciment()
        {
            obj.DeleteSpeciment(ListToDelete.ToArray());
        }

        public void GetAllSpeciments()
        {
            ListSpeciments = obj.GetDataAllSpeciments().ToList();
            FillSpecimentList();
        }

        public void FillSpecimentList()
        {
            SpecimentList = new BindingList<SpecimentsInOrder>(ListSpeciments);
            SpecimentList.AllowNew = true;
            SpecimentList.AllowEdit = true;
            SpecimentList.AllowRemove = true;
            SpecimentList.RaiseListChangedEvents = true;
            SpecimentList.ListChanged += new ListChangedEventHandler(SpecimentList_ListChanged);
        }

        //public void GetRelativesOfPatient(PatientClient ptnt)
        //{
        //    Patient temp = ConvertPatientClientToPatient(ptnt);
        //    patient.RelativeList = obj.GetRelativesOfPatient(temp).ToList();
        //}

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
