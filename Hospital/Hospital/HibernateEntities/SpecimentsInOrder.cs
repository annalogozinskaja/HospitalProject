using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DAOLayer
{
    public class SpecimentsInOrder
    {
        public virtual int ID_SpecimentOrder { get; set; }
        public virtual OrderOfPatient Order { get; set; }
        public virtual Speciment Speciment { get; set; }
        public virtual SpecimentStatus SpecimentStatus { get; set; }
        public virtual DateTime DateOfTaking { get; set; }
        public virtual string Nurse { get; set; }
        public virtual List<int> testsInOrderList { get; set; }
        public virtual int Status { get; set; }

        public override string ToString()
        {
            return " \nDate of speciment was taken: " + DateOfTaking+"\nNurse: "+Nurse;
        }
    }
}
