using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using AutoMapper;
using DAOLayer;
using DAOLayer.DAO;
using WebServiceHospitalApp.TransportObj;
//using System.Web.Script.Services;

namespace WebServiceHospitalApp
{
    /// <summary>
    /// Summary description for WebServiceHospital
    /// </summary>
    //[ScriptService] 
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceHospital : System.Web.Services.WebService
    {
        //public WebServiceHospital()
        //{
        //    //CODEGEN: This call is required by the ASP.NET Web Services Designer
        //    InitializeComponent();
        //}

        //private void InitializeComponent()
        //{
        //}

        //[System.Web.Script.Services.ScriptMethod()]
        [WebMethod]
        public string HelloWorld()
        {
            
            return "Hello World";
            
        }

        [WebMethod]
        public PatientTransport GetDataPatient()
        {
            //Patient pt;
            //SessionFactory SF = new SessionFactory();
            //SF.Init();

            //SF.OpenSession();
            //GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());

            //pt = patientDao.Get(1);
            //SF.CloseSession();
            //return pt;

            //return new PatientTransport(pt);




            SessionFactory SF = new SessionFactory();
            SF.Init();

            SF.OpenSession();
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            Patient p = patientDao.Get(1);

            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Patient, PatientTransport>();
            });

            IMapper iMapper = config.CreateMapper();
            PatientTransport pt = iMapper.Map<Patient, PatientTransport>(p);

            SF.CloseSession();
            return pt;
        }
    }
}
