using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class OrderOfPatientClient : IOrderOfPatientClient
    {
        public int ID_Order { get; set; }
        public DateTime DateOrder { get; set; }
        public string Symptoms { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public OrderStatus OrderStatus { get; set; }

    }
}
