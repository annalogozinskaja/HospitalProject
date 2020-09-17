using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Test
    {
        public virtual int ID_Test { get; set; }
        public virtual string TestName { get; set; }

        private IList<TestsInOrder> _TestsInOrder;
        public virtual IList<TestsInOrder> TestsInOrderList
        {
            get
            {
                return _TestsInOrder ?? (_TestsInOrder = new List<TestsInOrder>());
            }
            set { _TestsInOrder = value; }
        }
    }
}
