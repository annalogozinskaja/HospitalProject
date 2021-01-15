using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class DoctorModel : IDoctorModel
    {
        private List<Doctor> listDoctors;
        private WebServiceHospitalSoapClient service;

        public List<Doctor> ListDoctors
        {
            get => listDoctors;
            set => listDoctors = value;
        }

        public DoctorModel()
        {
            ListDoctors = new List<Doctor>();
            service = new WebServiceHospitalSoapClient();
        }

        public void GetDoctors()
        {
            ListDoctors = service.GetDataAllDoctors().ToList();
        }
    }
}
