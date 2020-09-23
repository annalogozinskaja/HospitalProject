using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Gender
    {
        public virtual int ID_Gender { get; set; }
        public virtual string GenderName { get; set; }

        private IList<Patient> patient= new List<Patient>();
        public virtual IList<Patient> PatientInList
        {
            get { return patient; }
            set { patient = value; }
        }

        private IList<Relative> relative= new List<Relative>();
        public virtual IList<Relative> RelativeInList
        {
            get { return relative; }
            set { relative = value; }
        }

        public override string ToString()
        {
            return "\n"+ID_Gender.ToString() + ". " + GenderName + ": " + patient.ToString();
        }
    }
}
