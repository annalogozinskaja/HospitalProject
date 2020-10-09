using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class OrderOfPatientTransport
    {
        public int ID_Order { get; set; }
        public DateTime DateOrder { get; set; }
        public string Symptoms { get; set; }
        public Patient Patient { get; set; }

        public Doctor Doctor { get; set; }
        public OrderStatus OrderStatus { get; set; }

        private List<SpecimentsInOrder> specimentsInOrder;

        public List<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }

        public override string ToString()
        {
            return "\nDoctor: " + Doctor.Lastname + "\nDate of order: " + DateOrder + "\nSymptoms: " + Symptoms + "\nStatus: " + OrderStatus.OrderName;
        }
    }
}