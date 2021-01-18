using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClientHospitalApp.Models
{
    public interface IPatientModel
    {       
        void GetAllPatients();
        void GetPatient(int IdPatient);
        void AddPatient();
        void UpdatePatient();
        void DeletePatient();
        void GetRelativesOfPatient(PatientClient ptnt);
        void SaveDataOfPatient();

        PatientClient Patient { get; set; }
        List<PatientClient> ListPatients { get; set; }
        BindingList<PatientClient> PatientList { get; set; }
        List<PatientClient> ListToAdd { get; set; }
        List<PatientClient> ListToUpdate { get; set; }
        List<PatientClient> ListToDelete { get; set; }
        List<Patient> ListPatientsForOrder { get; set; }

    }
}