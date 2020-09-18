using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class OrderStatus
    {
        public virtual int ID_OrderStatus { get; set; }
        public virtual string OrderName { get; set; }

        private IList<OrderOfPatient> _OrderOfPatient;
        public virtual IList<OrderOfPatient> OrderOfPatientList
        {
            get
            {
                return _OrderOfPatient ?? (_OrderOfPatient = new List<OrderOfPatient>());
            }
            set { _OrderOfPatient = value; }
        }
    }
}
