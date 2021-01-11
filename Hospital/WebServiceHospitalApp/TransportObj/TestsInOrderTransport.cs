using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class TestsInOrderTransport
    {
        public int ID_TestOrder { get; set; }
        public Test Test { get; set; }
        public DateTime DateStart { get; set; }
        public TestStatus TestStatus { get; set; }
        public string Result { get; set; }

        private List<SpecimentsInOrder> specimentsInOrder;

        public List<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }
       
        public override string ToString()
        {
            return "\nTest: " + Test.TestName + "\nDate start: " + DateStart +
                "\nResult: " + Result + "\nStatus: " + TestStatus.TestStatusName;
        }
    }
}