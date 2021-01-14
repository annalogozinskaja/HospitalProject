using ClientHospitalApp.ClientEntities;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface IPatientLookUpEdit
    {
        PatientClient Patient { get; set; }
        List<PatientClient> PatientDataSource { get; set; }
    }
}