using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Doctor
    {
        public virtual int ID_Doctor { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string FieldOfMedicine { get; set; }

        private IList<Patient> patient= new List<Patient>();
        public virtual IList<Patient> PatientInList
        {
            get { return patient; }
            set { patient = value; }
        }

        //private IList<OrderOfPatient> orderOfPatient = new List<OrderOfPatient>();
        //public virtual IList<OrderOfPatient> OrderOfPatientInList
        //{
        //    get { return orderOfPatient; }
        //    set { orderOfPatient = value; }
        //}


        public override string ToString()
        {
            return "\nDoctor:" + Lastname + " " + Firstname + ", fieldOfMedicine: " + FieldOfMedicine + ".";
        }
    }
}
