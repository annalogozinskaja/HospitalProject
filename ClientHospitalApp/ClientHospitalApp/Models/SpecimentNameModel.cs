using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class SpecimentNameModel:ISpecimentNameModel
    {
        private List<Speciment> listSpecimentNames;
        private WebServiceHospitalSoapClient obj;

        public List<Speciment> ListSpecimentNames
        {
            get => listSpecimentNames;
            set => listSpecimentNames = value;
        }

        public SpecimentNameModel()
        {
            ListSpecimentNames = new List<Speciment>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetSpecimentNames()
        {
            ListSpecimentNames = obj.GetDataSpecimentName().ToList();
        }
    }
}
