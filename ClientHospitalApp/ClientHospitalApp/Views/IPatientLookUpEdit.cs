using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface IPatientLookUpEdit
    {
        Patient Patient { get; set; }
        List<Patient> PatientDataSource { get; set; }
    }
}