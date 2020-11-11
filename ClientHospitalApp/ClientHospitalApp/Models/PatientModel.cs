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

        public PatientModel()
        {
            Patient = new Patient();
            List = new List<Patient>();
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

    }
}
