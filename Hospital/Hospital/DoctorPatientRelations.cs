using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class DoctorPatientRelations
    {
        public virtual int ID_DoctorPatient { get; set; }

        private IList<OrderOfPatient> orderOfPatient;
        public virtual IList<OrderOfPatient> OrderOfPatientInList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }
    }
}
