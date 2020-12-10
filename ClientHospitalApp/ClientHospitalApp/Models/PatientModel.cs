using AutoMapper;
using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class PatientModel : IPatientModel
    {
        private PatientClient patient;
        private List<PatientClient> list;
        private WebServiceHospitalSoapClient obj;
        private List<PatientClient> listToAdd;
        private List<PatientClient> listToUpdate;
        private List<PatientClient> listToDelete;
        public PatientClient Patient 
        { 
            get => patient; 
            set => patient = value; 
        }
        public List<PatientClient> List 
        { 
            get => list;
            set => list = value; 
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

        public PatientModel()
        {
            Patient = new PatientClient();
            List = new List<PatientClient>();
            obj = new WebServiceHospitalSoapClient();
            ListToAdd = new List<PatientClient>();
            ListToUpdate = new List<PatientClient>();
            ListToDelete = new List<PatientClient>();
        }
        public PatientClient ConvertPatientToPatientClient(Patient patient)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientClient>();
            });

            IMapper iMapper = config.CreateMapper();
            PatientClient newPatient = iMapper.Map<Patient, PatientClient>(patient);

            return newPatient;            
        }

        public List <PatientClient> ConvertPatientToPatientClient(List<Patient> patientList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientClient>();
            });

            IMapper iMapper = config.CreateMapper();
            foreach (Patient item in patientList)
            {
                PatientClient newPatient = iMapper.Map<Patient, PatientClient>(item);
                List.Add(newPatient);
            }
            return List;
        }

        public Patient ConvertPatientClientToPatient(PatientClient patient)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PatientClient, Patient>();
            });

            IMapper iMapper = config.CreateMapper();
            Patient newPatient = iMapper.Map<PatientClient, Patient>(patient);

            return newPatient;
        }
        public List<Patient> ConvertPatientClientToPatient(List<PatientClient> patientList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<PatientClient, Patient>();
            });

            IMapper iMapper = config.CreateMapper();

            List<Patient> listPatients = new List<Patient>();
            foreach (PatientClient item in patientList)
            {
                Patient newPatient = iMapper.Map<PatientClient, Patient>(item);
                listPatients.Add(newPatient);
            }

            return listPatients;         
        }

        public void GetPatient(int IdPatient)
        {
            Patient p = new Patient();
            p = obj.GetDataPatient(IdPatient);

            Patient=ConvertPatientToPatientClient(p);
        }

        public void AddPatient()
        {
            obj.AddPatient(ConvertPatientClientToPatient(ListToAdd).ToArray());
        }

        public void GetAllPatients()
        {
            List<Patient> lp = new List<Patient>();
            lp= obj.GetDataAllPatients().ToList();

            List = ConvertPatientToPatientClient(lp);
        }

        public void UpdatePatient()
        {
            //obj.UpdatePatient(ListToUpdate.ToArray());
        }

        public void DeletePatient()
        {
            //obj.DeletePatient(ListToDelete.ToArray());
        }
        public void GetRelativesOfPatient(PatientClient ptnt)
        {
            Patient temp=ConvertPatientClientToPatient(ptnt);
            patient.RelativeList= obj.GetRelativesOfPatient(temp).ToList();
        }

       public string SaveDataOfPatient()
        {
            String result = "";
            if (ListToAdd.Count > 0)
            {            
                AddPatient();
                ListToAdd.Clear();
                result="Data saved";
            }

            if (ListToUpdate.Count > 0)
            {
                UpdatePatient();
                ListToUpdate.Clear();
                result = "Data updated";
            }

            if (ListToDelete.Count > 0)
            {
                DeletePatient();
                ListToDelete.Clear();
                result = "Data deleted";
            }
            return result;
        }



    }
}
