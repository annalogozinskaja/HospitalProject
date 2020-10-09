using DAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServiceHospitalApp.TransportObj
{
    public class SpecimentsInOrderTransport
    {
        public int ID_SpecimentOrder { get; set; }
        public OrderOfPatient OrderOfPatient { get; set; }
        public Speciment Speciment { get; set; }
        public SpecimentStatus SpecimentStatus { get; set; }
        public DateTime DateOfTaking { get; set; }
        public string Nurse { get; set; }

        private List<TestsInOrder> testsInOrder;

        public List<TestsInOrder> TestsInOrderList
        {
            get { return testsInOrder; }
            set { testsInOrder = value; }
        }
       
        public override string ToString()
        {
            return "\nSpeciment: " + Speciment.SpecimentName +
                "\nDate of speciment was taken: " + DateOfTaking + "\nNurse: " + Nurse + "\nStatus: " + SpecimentStatus.SpecimentStatusName;
        }
    }
}