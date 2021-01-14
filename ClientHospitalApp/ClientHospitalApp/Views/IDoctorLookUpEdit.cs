using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface IDoctorLookUpEdit
    {
        Doctor Doctor { get; set; }
        List<Doctor> DoctorDataSource { get; set; }
    }
}