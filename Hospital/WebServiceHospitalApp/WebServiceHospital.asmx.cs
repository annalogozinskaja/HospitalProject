using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
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
            Patient pt;
            SessionFactory SF = new SessionFactory();
            SF.Init();

            SF.OpenSession();
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());

            pt = patientDao.Get(2);
            SF.CloseSession();

            return new PatientTransport(pt);

        }
    }
}
