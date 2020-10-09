using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class GenderTransport
    {
        public int ID_Gender { get; set; }
        public string GenderName { get; set; }

        private List<Patient> patient;

        public List<Patient> PatientInList
        {
            get { return patient; }
            set { patient = value; }
        }
        private List<Relative> relative;

        public List<Relative> RelativeInList
        {
            get { return relative; }
            set { relative = value; }
        }

        public override string ToString()
        {
            return "\n" + ID_Gender.ToString() + ". " + GenderName + ": " + patient.ToString();
        }
    }
}