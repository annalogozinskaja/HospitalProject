using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class OrderStatusModel : IOrderStatusModel
    {
        private List<OrderStatus> listOrderStatuses;
        private WebServiceHospitalSoapClient service;

        public List<OrderStatus> ListOrderStatuses
        {
            get => listOrderStatuses;
            set => listOrderStatuses = value;
        }

        public OrderStatusModel()
        {
            ListOrderStatuses = new List<OrderStatus>();
            service = new WebServiceHospitalSoapClient();
        }

        public void GetOrderStatuses()
        {
            ListOrderStatuses = service.GetDataOrderStatus().ToList();
        }
    }
}
