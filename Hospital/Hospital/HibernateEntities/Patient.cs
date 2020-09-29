using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    public class Patient 
    {
        public virtual int ID_Patient { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual int SSN { get; set; }

        private IList<Relative> relative;
        public virtual IList<Relative> RelativeInList
        {
            get { return relative; }
            set { relative = value; }
        }

        public virtual void InitRelativeInList()
        {
            relative = new List<Relative>();
        }

        public virtual Gender Gender { get; set; }

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
            return "\nPatient: "+ ID_Patient.ToString() + "." + Lastname + " " + Firstname + ", " + DOB + ", " + SSN.ToString() + ", " + Gender.GenderName + ".";
        }
    }
}
