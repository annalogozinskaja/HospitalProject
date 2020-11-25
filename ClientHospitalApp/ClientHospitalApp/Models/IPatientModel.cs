using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Models
{
    public interface IPatientModel
    {       
        void GetAllPatients();
        void GetPatient(int IdPatient);
        void AddPatient();
        void UpdatePatient();
        void DeletePatient();
        void GetRelativesOfPatient(int IdPatient);

        Patient Patient { get; set; }
        List<Patient> List { get; set; }
        List<Relative> ListRelative { get; set; }
        List<Patient> ListToAdd { get; set; }
        List<Patient> ListToUpdate { get; set; }
        List<Patient> ListToDelete { get; set; }

    }
}