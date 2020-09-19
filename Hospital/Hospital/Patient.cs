using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Patient 
    {
        public virtual int ID_Patient { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual int SSN { get; set; }

        private IList<Relative> _Relative;
        public virtual IList<Relative> RelativeInList
        {
            get
            {
                return _Relative ?? (_Relative = new List<Relative>());
            }
            set { _Relative = value; }
        }

        public virtual Gender Gender { get; set; }

        private IList<OrderOfPatient> _OrderOfPatient;
        public virtual IList<OrderOfPatient> OrderOfPatientInList
        {
            get
            {
                return _OrderOfPatient ?? (_OrderOfPatient = new List<OrderOfPatient>());
            }
            set { _OrderOfPatient = value; }
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


        public override string ToString()
        {
            return "Patient: "+ ID_Patient.ToString() + "." + Lastname + " " + Firstname + ", " + DOB + ", " + SSN.ToString() + ", " + Gender.GenderName + ".";
        }
    }
}
