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
        public int ID_Patient { get; set; }
        public int ID_Doctor { get; set; }
        public int ID_OrderStatus { get; set; }

        public List<int> specimentsInOrderList { get; set; }

    }
}
