using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    
    public class Patient
    {
        public virtual int ID_Patient { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual int SSN { get; set; }     
        public virtual int ID_Gender { get; set; }
        public virtual List<int> relativeList { get; set; }
        public virtual List<int> orderOfPatientList { get; set; }

        public virtual int Status { get; set; }

        public override string ToString()
        {
            return "\nPatient: "+ ID_Patient.ToString() + "." + Lastname + " " + Firstname + ", " + DOB + ", " + SSN.ToString() + ", " + ID_Gender.ToString() + ".";
        }
    }
}
