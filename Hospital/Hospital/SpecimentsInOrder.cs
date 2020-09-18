using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class SpecimentsInOrder
    {
        public virtual int ID_SpecimentOrder { get; set; }
        public virtual OrderOfPatient OrderOfPatient { get; set; }
        public virtual Speciment Speciment { get; set; }
        public virtual SpecimentStatus SpecimentStatus { get; set; }
        public virtual DateTime DateOfTaking { get; set; }
        public virtual string Nurse { get; set; }

        private IList<TestsInOrder> _TestsInOrder;
        public virtual IList<TestsInOrder> TestsInOrder
        {
            get
            {
                return _TestsInOrder ?? (_TestsInOrder = new List<TestsInOrder>());
            }
            set { _TestsInOrder = value; }
        }

        public override string ToString()
        {
            return "\nSpeciment: " + Speciment.SpecimentName+
                "\nDate of speciment was taken: " + DateOfTaking+"\nNurse: "+Nurse+"\nStatus: "+SpecimentStatus.SpecimentStatusName;
        }
    }
}
