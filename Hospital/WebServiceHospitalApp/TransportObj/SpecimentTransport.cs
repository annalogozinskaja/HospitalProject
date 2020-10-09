using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class SpecimentTransport
    {
        public int ID_Speciment { get; set; }
        public string SpecimentName { get; set; }

        private List<SpecimentsInOrder> specimentsInOrder;

        public List<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }
    }
}