using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class OrderOfPatientModel: IOrderOfPatientModel
    {
        private List<OrderOfPatient> listOrders;
        private WebServiceHospitalSoapClient obj;

        public List<OrderOfPatient> ListOrders
        {
            get => listOrders;
            set => listOrders = value;
        }

        public OrderOfPatientModel()
        {
            ListOrders = new List<OrderOfPatient>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetOrders()
        {
            ListOrders = obj.GetDataAllOrders().ToList();
        }

    }
}
