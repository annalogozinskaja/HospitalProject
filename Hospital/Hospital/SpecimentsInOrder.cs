using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class SpecimentsInOrder
    {
        public virtual int ID_SpecimentOrder { get; set; }
        public virtual OrderOfPatient OrderOfPatient { get; set; }
        public virtual Speciment Speciment { get; set; }
        public virtual int ID_SpecimentStatus { get; set; }
        public virtual DateTime DateOfTaking { get; set; }
        public virtual string Nurse { get; set; }

        public override string ToString()
        {
            return "\nNumber of order: " + OrderOfPatient + "\nSpeciment: " + Speciment.SpecimentName + 
                "\nDate of speciment was taken: "+ DateOfTaking+"\nNurse: "+Nurse+".";
        }
    }
}
