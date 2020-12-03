using AutoMapper;
using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public class GenderModel: IGenderModel
    {
        private List<Gender> listGender;
        private WebServiceHospitalSoapClient obj;
       
        public List<Gender> ListGender
        {
            get => listGender;
            set => listGender = value;
        }
       
        public GenderModel()
        {
            ListGender = new List<Gender>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetGender()
        {
            ListGender = obj.GetDataGender().ToList();
        }
       
    }
}
