using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class PatientModel
    {
        public Patient patient;
        public List<Patient> list;
        private WebServiceHospitalSoapClient obj;

        public PatientModel()
        {
            patient = new Patient();
            list = new List<Patient>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetPatient(int IdPatient)
        {
            patient = obj.GetDataPatient(IdPatient);
        }

        public void SavePatient()
        {
            obj.SavePatient(patient);
        }

        public void GetAllPatients()
        {
            list = obj.GetDataAllPatients().ToList();
        }

        public void UpdatePatient()
        {
            obj.UpdatePatient(patient);
        }

        public void DeletePatient()
        {
            obj.DeletePatient(patient);
        }

    }
}
