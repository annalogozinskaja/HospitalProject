using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Speciment
    {
        public virtual int ID_Speciment { get; set; }
        public virtual string SpecimentName { get; set; }

        private IList<SpecimentsInOrder> specimentsInOrder = new List<SpecimentsInOrder>();
        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }
    }
}
