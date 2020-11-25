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
        private Patient patient;
        private List<Patient> list;
        private WebServiceHospitalSoapClient obj;
        private List<Relative> listRelatives;
        private List<Patient> listToAdd;
        private List<Patient> listToUpdate;
        private List<Patient> listToDelete;
        public Patient Patient 
        { 
            get => patient; 
            set => patient = value; 
        }
        public List<Patient> List 
        { 
            get => list;
            set => list = value; 
        }
        public List<Relative> ListRelative
        {
            get => listRelatives;
            set => listRelatives = value;
        }
        public List<Patient> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List<Patient> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List<Patient> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }

        public PatientModel()
        {
            Patient = new Patient();
            List = new List<Patient>();
            ListRelative = new List<Relative>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetPatient(int IdPatient)
        {
            Patient = obj.GetDataPatient(IdPatient);
        }

        public void AddPatient()
        {
            //obj.AddPatient(Patient);
            obj.AddPatient(ListToAdd);
        }

        public void GetAllPatients()
        {
            List = obj.GetDataAllPatients().ToList();
        }

        public void UpdatePatient()
        {
            obj.UpdatePatient(Patient);
        }

        public void DeletePatient()
        {
            obj.DeletePatient(Patient);
        }
        public void GetRelativesOfPatient(int IdPatient)
        {
            ListRelative=obj.GetRelativesOfPatient(IdPatient).ToList();
        }

    }
}
