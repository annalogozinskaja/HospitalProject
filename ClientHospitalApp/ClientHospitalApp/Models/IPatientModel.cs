using ClientHospitalApp.ClientEntities;
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

        PatientClient Patient { get; set; }
        List<PatientClient> List { get; set; }
        List<Relative> ListRelative { get; set; }
        List<PatientClient> ListToAdd { get; set; }
        List<PatientClient> ListToUpdate { get; set; }
        List<PatientClient> ListToDelete { get; set; }

    }
}