using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class OrderOfPatientModel
    {
        public OrderOfPatient order;
        public List<OrderOfPatient> list;
        private WebServiceHospitalSoapClient obj;

        public OrderOfPatientModel()
        {
            order = new OrderOfPatient();
            list = new List<OrderOfPatient>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetOrdersOfPatient(int IdPatient)
        {
            list = obj.GetOrdersOfPatient(IdPatient).ToList();
        }
    }
}
