using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class Gender
    {
        public virtual int ID_Gender { get; set; }
        public virtual string GenderName { get; set; }

        public virtual List<int> patientList { get; set; }
        public virtual List<int> relativeList { get; set; }

        public override string ToString()
        {
            return GenderName.ToString();
        }
    }
}
