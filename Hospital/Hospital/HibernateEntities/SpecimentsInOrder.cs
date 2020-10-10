using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class SpecimentsInOrder
    {
        public virtual int ID_SpecimentOrder { get; set; }
        public virtual int ID_Order { get; set; }
        public virtual int ID_Speciment { get; set; }
        public virtual int ID_SpecimentStatus { get; set; }
        public virtual DateTime DateOfTaking { get; set; }
        public virtual string Nurse { get; set; }
        public virtual List<int> testsInOrderList { get; set; }

        public override string ToString()
        {
            return "\nName of Speciment:"+ ID_Speciment.ToString()+" \nDate of speciment was taken: " + DateOfTaking+"\nNurse: "+Nurse+"\nStatus: "+ID_SpecimentStatus;
        }
    }
}
