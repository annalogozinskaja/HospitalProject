using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Models
{
    public interface IDoctorModel
    {
        List<Doctor> ListDoctors { get; set; }

        void GetDoctors();
    }
}