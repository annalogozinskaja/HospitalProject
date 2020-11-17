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

        public void SavePatient()
        {
            obj.SavePatient(Patient);
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
