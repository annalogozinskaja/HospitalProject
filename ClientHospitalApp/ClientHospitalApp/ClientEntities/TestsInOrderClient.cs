using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class TestsInOrderClient
    {
        public virtual int ID_TestOrder { get; set; }
        public virtual Test Test { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual TestStatus TestStatus { get; set; }
        public virtual string Result { get; set; }
        public virtual List<int> specimentsInOrderList { get; set; }

        public TestsInOrderClient()
        {
            this.ID_TestOrder = -1;
            this.Test = new Test();
            this.DateStart = new DateTime();
            this.DateEnd = new DateTime();
            this.TestStatus = new TestStatus();
            this.Result = string.Empty;
            this.specimentsInOrderList = new List<int>();
        }
    }
}
