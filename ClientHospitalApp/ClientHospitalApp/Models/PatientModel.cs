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
        private List<Relative> listRelatives;
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
        public List<Relative> ListRelative
        {
            get => listRelatives;
            set => listRelatives = value;
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
            ListRelative = new List<Relative>();
            obj = new WebServiceHospitalSoapClient();
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

        public void GetPatient(int IdPatient)
        {
            Patient p = new Patient();
            p = obj.GetDataPatient(IdPatient);

            Patient=ConvertPatientToPatientClient(p);
        }

        public void AddPatient()
        {
            //obj.AddPatient(ListToAdd.ToArray());
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
        public void GetRelativesOfPatient(int IdPatient)
        {
            ListRelative=obj.GetRelativesOfPatient(IdPatient).ToList();
        }

    }
}
