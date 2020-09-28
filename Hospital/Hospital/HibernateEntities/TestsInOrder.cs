using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class TestsInOrder
    {
        public virtual int ID_TestOrder { get; set; }
        public virtual Test Test { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual TestStatus TestStatus { get; set; }
        public virtual string Result { get; set; }

        private IList<SpecimentsInOrder> specimentsInOrder= new List<SpecimentsInOrder>();
        //private IList<SpecimentsInOrder> specimentsInOrder;

        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }
        //public virtual void InitSpecimentsInOrderList()
        //{
        //    specimentsInOrder = new List<SpecimentsInOrder>();
        //}

        public override string ToString()
        {
            return "\nTest: " +Test.TestName + "\nDate start: " + DateStart+
                "\nDate end: " + DateEnd + "\nResult: " + Result + "\nStatus: "+TestStatus.TestStatusName;
        }
    }
}
