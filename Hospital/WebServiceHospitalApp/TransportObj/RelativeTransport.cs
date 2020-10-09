using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class RelativeTransport
    {
        public int ID_Relative { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime DOB { get; set; }
        public string KindOfRelationship { get; set; }
        public Patient Patient { get; set; }
        public Gender Gender { get; set; }


        public override string ToString()
        {
            return "\nRelative:" + Lastname + " " + Firstname + ", " + DOB + ", " + KindOfRelationship + ".";
        }
    }
}