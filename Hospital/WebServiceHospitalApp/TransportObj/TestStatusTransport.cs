using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class TestStatusTransport
    {
        public int ID_TestStatus { get; set; }
        public string TestStatusName { get; set; }

        private List<TestsInOrder> testsInOrder;

        public List<TestsInOrder> TestsInOrderList
        {
            get { return testsInOrder; }
            set { testsInOrder = value; }
        }
    }
}