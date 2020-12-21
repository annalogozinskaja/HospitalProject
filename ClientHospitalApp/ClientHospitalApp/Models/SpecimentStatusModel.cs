using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class SpecimentStatusModel:ISpecimentStatusModel
    {
        private List<SpecimentStatus> listSpecimentStatuses;
        private WebServiceHospitalSoapClient obj;

        public List<SpecimentStatus> ListSpecimentStatuses
        {
            get => listSpecimentStatuses;
            set => listSpecimentStatuses = value;
        }

        public SpecimentStatusModel()
        {
            ListSpecimentStatuses = new List<SpecimentStatus>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetSpecimentStatuses()
        {
            ListSpecimentStatuses = obj.GetDataSpecimentStatus().ToList();
        }
    }
}
