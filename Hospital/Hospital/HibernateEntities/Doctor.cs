﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class Doctor
    {
        public virtual int ID_Doctor { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual string FieldOfMedicine { get; set; }

        public virtual List<int> orderOfPatientList { get; set; }

        public override string ToString()
        {
            return "\nDoctor:" + Lastname + " " + Firstname + ", fieldOfMedicine: " + FieldOfMedicine + ".";
        }
    }
}
