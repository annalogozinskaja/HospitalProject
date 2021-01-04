using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class SpecimentsInOrderClient
    {
        public int ID_SpecimentOrder { get; set; }
        public Speciment Speciment { get; set; }
        public SpecimentStatus SpecimentStatus { get; set; }
        public DateTime DateOfTaking { get; set; }
        public OrderOfPatient Order { get; set; }
        public string Nurse { get; set; }
        public List<int> testsInOrderList { get; set; }

        public SpecimentsInOrderClient()
        {
            this.ID_SpecimentOrder = -1;
            this.Speciment = new Speciment();
            this.SpecimentStatus = new SpecimentStatus();
            this.DateOfTaking = new DateTime();
            this.Order = new OrderOfPatient();
            this.Nurse = string.Empty;          
            this.testsInOrderList = new List<int>();
        }
    }
}
