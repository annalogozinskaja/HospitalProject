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
        private List<GenderClient> listGender;
        private WebServiceHospitalSoapClient obj;
       
        public List<GenderClient> ListGender
        {
            get => listGender;
            set => listGender = value;
        }
       
        public GenderModel()
        {
            ListGender = new List<GenderClient>();
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetGender()
        {
            List<Gender> lg = new List<Gender>();
            lg= obj.GetDataGender().ToList();

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Gender, GenderClient>();
            });

            IMapper iMapper = config.CreateMapper();
            foreach (Gender item in lg)
            {
                GenderClient newGender = iMapper.Map<Gender, GenderClient>(item);
                ListGender.Add(newGender);
            }
            
        }
       
    }
}
