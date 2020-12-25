using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class TestStatusModel:ITestStatusModel
    {
        private List<TestStatus> listTestStatuses;
        private WebServiceHospitalSoapClient obj;

        public List<TestStatus> ListTestStatuses
        {
            get => listTestStatuses;
            set => listTestStatuses = value;
        }

        public TestStatusModel()
        {
            ListTestStatuses = new List<TestStatus>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetTestStatuses()
        {
            ListTestStatuses = obj.GetDataTestStatus().ToList();
        }
    }
}
