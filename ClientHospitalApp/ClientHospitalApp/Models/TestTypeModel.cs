using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class TestTypeModel:ITestNameModel
    {
        private List<Test> listTestNames;
        private WebServiceHospitalSoapClient obj;

        public List<Test> ListTestNames
        {
            get => listTestNames;
            set => listTestNames = value;
        }

        public TestTypeModel()
        {
            ListTestNames = new List<Test>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetTestNames()
        {
            ListTestNames = obj.GetDataTestName().ToList();
        }
    }
}
