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

        private IList<OrderOfPatient> orderOfPatient;

        [XmlIgnore]
        public virtual IList<OrderOfPatient> OrderOfPatientList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }
        public virtual void InitOrderOfPatientList()
        {
            orderOfPatient = new List<OrderOfPatient>();
        }
    }
}
