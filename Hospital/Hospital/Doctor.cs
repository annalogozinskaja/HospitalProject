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

        private IList<Patient> _Patient;
        public virtual IList<Patient> PatientInList
        {
            get
            {
                return _Patient ?? (_Patient = new List<Patient>());
            }
            set { _Patient = value; }
        }

        private IList<OrderOfPatient> _OrderOfPatient;
        public virtual IList<OrderOfPatient> OrderOfPatientInList
        {
            get
            {
                return _OrderOfPatient ?? (_OrderOfPatient = new List<OrderOfPatient>());
            }
            set { _OrderOfPatient = value; }
        }


        public override string ToString()
        {
            return "\nDoctor:" + Lastname + " " + Firstname + ", fieldOfMedicine: " + FieldOfMedicine + ".";
        }
    }
}
