using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Gender
    {
        public virtual int ID_Gender { get; set; }
        public virtual string GenderName { get; set; }

        private IList<Patient> _Patient;
        public virtual IList<Patient> PatientInList
        {
            get
            {
                return _Patient ?? (_Patient = new List<Patient>());
            }
            set { _Patient = value; }
        }

        private IList<Relative> _Relative;
        public virtual IList<Relative> RelativeInList
        {
            get
            {
                return _Relative ?? (_Relative = new List<Relative>());
            }
            set { _Relative = value; }
        }

        public override string ToString()
        {
            return "\n"+ID_Gender.ToString() + ". " + GenderName + ": " + _Patient.ToString();
        }
    }
}
