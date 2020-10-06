using System;
using System.Collections.Generic;
using System.Text;

namespace DAOLayer
{
    public class Gender
    {
        public virtual int ID_Gender { get; set; }
        public virtual string GenderName { get; set; }

        private IList<Patient> patient;
        public virtual IList<Patient> PatientInList
        {
            get { return patient; }
            set { patient = value; }
        }
        public virtual void InitPatientInList()
        {
            patient = new List<Patient>();
        }

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

        public override string ToString()
        {
            return "\n"+ID_Gender.ToString() + ". " + GenderName + ": " + patient.ToString();
        }
    }
}
