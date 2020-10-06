using System;
using System.Collections.Generic;
using System.Text;

namespace DAOLayer
{
    public class OrderStatus
    {
        public virtual int ID_OrderStatus { get; set; }
        public virtual string OrderName { get; set; }

        private IList<OrderOfPatient> orderOfPatient;
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
