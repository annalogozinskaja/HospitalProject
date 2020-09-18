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

        private IList<Patient> _Patient;
        public virtual IList<Patient> PatientInList
        {
            get
            {
                return _Patient ?? (_Patient = new List<Patient>());
            }
            set { _Patient = value; }
        }

        private IList<Doctor> _Doctor;
        public virtual IList<Doctor> DoctorInList
        {
            get
            {
                return _Doctor ?? (_Doctor = new List<Doctor>());
            }
            set { _Doctor = value; }
        }

        private IList<SpecimentsInOrder> _SpecimentsInOrder;
        public virtual IList<SpecimentsInOrder> SpecimentsInOrderList
        {
            get
            {
                return _SpecimentsInOrder ?? (_SpecimentsInOrder = new List<SpecimentsInOrder>());
            }
            set { _SpecimentsInOrder = value; }
        }

        public virtual OrderStatus OrderStatus { get; set; }

        public override string ToString()
        {
            return "\nDate of order: " + DateOrder + "\nSymptoms: " + Symptoms + "\nStatus: "+OrderStatus.OrderName;
        }
    }
}
