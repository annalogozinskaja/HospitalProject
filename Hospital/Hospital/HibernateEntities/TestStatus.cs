using System;
using System.Collections.Generic;
using System.Text;

namespace DAOLayer
{
    public class TestStatus
    {
        public virtual int ID_TestStatus { get; set; }
        public virtual string TestStatusName { get; set; }

        private IList<TestsInOrder> testsInOrder;
        public virtual IList<TestsInOrder> TestsInOrderList
        {
            get { return testsInOrder; }
            set { testsInOrder = value; }
        }
        public virtual void InitTestsInOrderList()
        {
            testsInOrder = new List<TestsInOrder>();
        }
    }
}
