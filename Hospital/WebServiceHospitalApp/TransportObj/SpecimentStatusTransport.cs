using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class SpecimentStatusTransport
    {
        public int ID_SpecimentStatus { get; set; }
        public string SpecimentStatusName { get; set; }

        private List<SpecimentsInOrder> specimentsInOrder;

        public List<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }
    }
}