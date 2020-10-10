using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class OrderStatus
    {
        public virtual int ID_OrderStatus { get; set; }
        public virtual string OrderName { get; set; }
        public virtual List<int> orderOfPatientList { get; set; }

    }
}
