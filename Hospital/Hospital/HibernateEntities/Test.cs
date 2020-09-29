using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Test
    {
        public virtual int ID_Test { get; set; }
        public virtual string TestName { get; set; }

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
