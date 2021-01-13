using AutoMapper;
using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp.Models
{
    public class PatientModel : IPatientModel
    {
        private PatientClient patient;
        private List<PatientClient> listPatients;
        private WebServiceHospitalSoapClient service;
        BindingList<PatientClient> patientList;
        private List<PatientClient> listToAdd;
        private List<PatientClient> listToUpdate;
        private List<PatientClient> listToDelete;
        public PatientClient Patient 
        { 
            get => patient; 
            set => patient = value; 
        }
        public List<PatientClient> ListPatients 
        { 
            get => listPatients;
            set => listPatients = value; 
        }
        public BindingList<PatientClient> PatientList
        {
            get => patientList;
            set => patientList = value;
        }
        public List<PatientClient> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List<PatientClient> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List<PatientClient> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }

        IPatientModel patientModel;

        public PatientModel()
        {
            Patient = new PatientClient();
            ListPatients = new List<PatientClient>();
            service = new WebServiceHospitalSoapClient();          
            ListToAdd = new List<PatientClient>();
            ListToUpdate = new List<PatientClient>();
            ListToDelete = new List<PatientClient>();
            patientModel = this;         
        }
        private PatientClient ConvertPatientToPatientClient(Patient patient)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientClient>();
            });

            IMapper iMapper = config.CreateMapper();
            PatientClient newPatient = iMapper.Map<Patient, PatientClient>(patient);

            return newPatient;            
        }

        private List <PatientClient> ConvertPatientToPatientClient(List<Patient> patientList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientClient>();
            });

            IMapper iMapper = config.CreateMapper();
            foreach (Patient item in patientList)
            {
                PatientClient newPatient = iMapper.Map<Patient, PatientClient>(item);
                ListPatients.Add(newPatient);
            }
            return ListPatients;
        }

        private Patient ConvertPatientClientToPatient(PatientClient patient)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PatientClient, Patient>();
            });

            IMapper iMapper = config.CreateMapper();
            Patient newPatient = iMapper.Map<PatientClient, Patient>(patient);

            return newPatient;
        }
        private List<Patient> ConvertPatientClientToPatient(List<PatientClient> patientList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PatientClient, Patient>();
            });

            IMapper iMapper = config.CreateMapper();

            List<Patient> lstPtnts = new List<Patient>();
            foreach (PatientClient item in patientList)
            {
                Patient newPatient = iMapper.Map<PatientClient, Patient>(item);
                lstPtnts.Add(newPatient);
            }

            return lstPtnts;         
        }

        public void GetPatient(int IdPatient)
        {
            Patient p = new Patient();
            p = service.GetDataPatient(IdPatient);

            Patient=ConvertPatientToPatientClient(p);
        }

        void IPatientModel.AddPatient()
        {
            service.AddPatient(ConvertPatientClientToPatient(ListToAdd).ToArray());
        }

        public void GetAllPatients()
        {
            List<Patient> lp = new List<Patient>();
            lp= service.GetDataAllPatients().ToList();

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
            Patient temp=ConvertPatientClientToPatient(ptnt);
            patient.RelativeList= service.GetRelativesOfPatient(temp).ToList();
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
