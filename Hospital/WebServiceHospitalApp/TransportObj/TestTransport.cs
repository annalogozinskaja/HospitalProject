using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class TestTransport
    {
        public int ID_Test { get; set; }
        public string TestName { get; set; }

        private List<TestsInOrder> testsInOrder;

        public List<TestsInOrder> TestsInOrderList
        {
            get { return testsInOrder; }
            set { testsInOrder = value; }
        }
    }
}