using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Test
    {
        public virtual int ID_Test { get; set; }
        public virtual string TestName { get; set; }

        private IList<TestsInOrder> testsInOrder = new List<TestsInOrder>();
        public virtual IList<TestsInOrder> TestsInOrderList
        {
            get { return testsInOrder; }
            set { testsInOrder = value; }
        }
    }
}
