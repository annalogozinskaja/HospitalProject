using System;
using System.Collections.Generic;
using System.Text;

namespace DAOLayer
{
    public class Doctor
    {
        public virtual int ID_Doctor { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string FieldOfMedicine { get; set; }

        private IList<OrderOfPatient> orderOfPatient;
        public virtual IList<OrderOfPatient> OrderOfPatientInList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }

        public virtual void InitOrderOfPatientList()
        {
            orderOfPatient = new List<OrderOfPatient>();
        }
        public override string ToString()
        {
            return "\nDoctor:" + Lastname + " " + Firstname + ", fieldOfMedicine: " + FieldOfMedicine + ".";
        }
    }
}
