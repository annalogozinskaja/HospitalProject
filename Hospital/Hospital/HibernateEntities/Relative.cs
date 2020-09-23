using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Relative
    {
        public virtual int ID_Relative { get; set; }
        public virtual string Lastname { get; set; }
        public virtual string Firstname { get; set; }
        public virtual DateTime DOB { get; set; }
        public virtual string KindOfRelationship { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Gender Gender { get; set; }


        public override string ToString()
        {
            return "\nRelative:" + Lastname + " " + Firstname + ", " + DOB + ", " + KindOfRelationship +".";
        }
    }
}
