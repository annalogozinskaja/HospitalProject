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


namespace WebServiceHospitalApp
{
    /// <summary>
    /// Summary description for WebServiceHospital
    /// </summary>
   
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.   
    public class WebServiceHospital : System.Web.Services.WebService
    {
     
        [WebMethod]
        public string HelloWorld()
        {           
            return "Hello World";            
        }

        [WebMethod]
        public PatientTransport GetDataPatient()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();

            SF.OpenSession();
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            Patient p = patientDao.Get(1);

            GenericAutoMapper<Patient, PatientTransport> gam = new GenericAutoMapper<Patient, PatientTransport>();
            PatientTransport pt=gam.CreateMapping(p);

            SF.CloseSession();
            return pt;
        }

        [WebMethod]
        public OrderOfPatientTransport GetDataOrder()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();

            SF.OpenSession();
            GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(SF.GetSession());
            OrderOfPatient ord = orderDao.Get(1);

            GenericAutoMapper<OrderOfPatient, OrderOfPatientTransport> gam = new GenericAutoMapper<OrderOfPatient, OrderOfPatientTransport>();
            OrderOfPatientTransport ot = gam.CreateMapping(ord);

            SF.CloseSession();
            return ot;
        }
    }
}
