using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class OrderStatus
    {
        public virtual int ID_OrderStatus { get; set; }
        public virtual string OrderName { get; set; }

        private IList<OrderOfPatient> orderOfPatient = new List<OrderOfPatient>();
        public virtual IList<OrderOfPatient> OrderOfPatientList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }
    }
}
