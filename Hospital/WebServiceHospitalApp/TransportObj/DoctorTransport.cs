using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class DoctorTransport
    {
        public int ID_Doctor { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string FieldOfMedicine { get; set; }

        private List<OrderOfPatient> orderOfPatient;

        public List<OrderOfPatient> OrderOfPatientInList
        {
            get { return orderOfPatient; }
            set { orderOfPatient = value; }
        }

        public override string ToString()
        {
            return "\nDoctor:" + Lastname + " " + Firstname + ", fieldOfMedicine: " + FieldOfMedicine + ".";
        }
    }
}