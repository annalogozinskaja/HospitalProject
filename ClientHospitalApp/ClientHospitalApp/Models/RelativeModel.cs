using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class RelativeModel
    {
        public Relative relative;
        public List<Relative> list;
        private WebServiceHospitalSoapClient obj;

        public RelativeModel()
        {
            relative = new Relative();
            list = new List<Relative>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void SaveRelative()
        {
           int id= obj.SaveRelative(relative);
        }

    }
}
