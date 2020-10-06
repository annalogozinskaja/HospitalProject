using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using DAOLayer;
using DAOLayer.DAO;

namespace WebServiceHospitalApp
{
    /// <summary>
    /// Summary description for WebServiceHospital
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceHospital : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            
            return "Hello World";
            
        }

        [WebMethod]
        public string GetDataPatient()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();

            SF.OpenSession();
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());

            string str = patientDao.Get(2).ToString();
            SF.CloseSession();

            return str;

        }
    }
}
