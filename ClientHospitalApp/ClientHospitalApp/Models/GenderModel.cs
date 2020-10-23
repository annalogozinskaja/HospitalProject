using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientHospitalApp.ServiceReferenceDAOLayer;

namespace ClientHospitalApp.Models
{
    public class GenderModel
    {
        public Gender gender;
        public List<Gender> list;
        private WebServiceHospitalSoapClient obj;

        public GenderModel()
        {
            gender=new Gender();
            list = new List<Gender>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetListGender()
        {
            list = obj.GetDataGender().ToList();
        }
    }
}
