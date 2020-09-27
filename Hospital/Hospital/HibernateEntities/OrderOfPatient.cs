using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class OrderOfPatient
    {
        public virtual int ID_Order { get; set; }
        public virtual DateTime DateOrder { get; set; }
        public virtual string Symptoms { get; set; }
        public virtual Patient Patient { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        private IList<SpecimentsInOrder> specimentsInOrder;
        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get { return specimentsInOrder; }
            set { specimentsInOrder = value; }
        }

        public virtual void InitRelativeInList()
        {
            specimentsInOrder = new List<SpecimentsInOrder>();
        }

        public override string ToString()
        {
            return "\nDoctor: "+Doctor.Lastname+"\nDate of order: " + DateOrder + "\nSymptoms: " + Symptoms + "\nStatus: "+OrderStatus.OrderName;
        }
    }
}
