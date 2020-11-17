using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Models
{
    public interface IPatientModel
    {
        void DeletePatient();
        void GetAllPatients();
        void GetPatient(int IdPatient);
        void SavePatient();
        void UpdatePatient();
        void GetRelativesOfPatient(int IdPatient);

        Patient Patient { get; set; }
        List<Patient> List { get; set; }
        List<Relative> ListRelative { get; set; }
    }
}