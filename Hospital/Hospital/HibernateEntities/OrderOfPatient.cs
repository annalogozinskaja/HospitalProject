using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class OrderOfPatient
    {
        public virtual int ID_Order { get; set; }
        public virtual DateTime DateOrder { get; set; }
        public virtual string Symptoms { get; set; }
        public virtual int ID_Patient { get; set; }

        public virtual int ID_Doctor { get; set; }
        public virtual int ID_OrderStatus { get; set; }

        public virtual List<int> specimentsInOrderList { get; set; }
        public virtual int Status { get; set; }

        public override string ToString()
        {
            return "\nDoctor: "+ID_Doctor.ToString()+"\nDate of order: " + DateOrder + "\nSymptoms: " + Symptoms + "\nStatus: "+ID_OrderStatus;
        }
    }
}
