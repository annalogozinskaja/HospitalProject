using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class OrderStatusTransport
    {
        public int ID_OrderStatus { get; set; }
        public string OrderName { get; set; }

        private List<OrderOfPatient> orderOfPatient;

        public List<OrderOfPatient> OrderOfPatientList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }
    }
}