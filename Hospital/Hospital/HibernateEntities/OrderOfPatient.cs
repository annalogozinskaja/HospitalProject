using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class OrderOfPatient
    {
        public virtual int ID_Order { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual DateTime DateOrder { get; set; }
        public virtual string Symptoms { get; set; }
       
        public virtual Doctor Doctor { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }

        public virtual List<int> specimentsInOrderList { get; set; }
        public virtual int Status { get; set; }

        public override string ToString()
        {
            return "\nDate of order: " + DateOrder + "\nSymptoms: " + Symptoms;
        }
    }
}
