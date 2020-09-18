using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class SpecimentStatus
    {
        public virtual int ID_SpecimentStatus { get; set; }
        public virtual string SpecimentStatusName { get; set; }

        private IList<SpecimentsInOrder> _SpecimentsInOrder;
        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get
            {
                return _SpecimentsInOrder ?? (_SpecimentsInOrder = new List<SpecimentsInOrder>());
            }
            set { _SpecimentsInOrder = value; }
        }
    }
}
