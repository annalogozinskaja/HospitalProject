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
            List<Patient> lp = new List<Patient>();
            lp = obj.GetDataAllPatients().ToList();

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

        public void GetRelativesOfPatient(PatientClient ptnt)
        {
            Patient temp = ConvertPatientClientToPatient(ptnt);
            patient.RelativeList = obj.GetRelativesOfPatient(temp).ToList();
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
