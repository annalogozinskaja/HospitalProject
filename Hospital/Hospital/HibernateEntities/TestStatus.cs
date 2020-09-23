using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class TestStatus
    {
        public virtual int ID_TestStatus { get; set; }
        public virtual string TestStatusName { get; set; }

        private IList<TestsInOrder> testsInOrder = new List<TestsInOrder>();
        public virtual IList<TestsInOrder> TestsInOrderList
        {
            get { return testsInOrder; }
            set { testsInOrder = value; }
        }
    }
}
