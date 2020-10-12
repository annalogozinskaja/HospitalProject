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
        public Patient GetDataPatient()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            //выведем данные пациента с id=1 и его ордера
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            Patient p = patientDao.Get(1);
            p.orderOfPatientList = new List<int>();

            OrderOfPatientDaoImpl orderDao = new OrderOfPatientDaoImpl(SF.GetSession());

            foreach (OrderOfPatient item in orderDao.GetOrdersOfPatient(1).ToList())
            {
                p.orderOfPatientList.Add(item.ID_Order);
            }

            SF.CloseSession();
            return p;
        }

        [WebMethod]
        public OrderOfPatient GetDataOrder()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(SF.GetSession());
            OrderOfPatient ord = orderDao.Get(2);
           
            SF.CloseSession();
            return ord;
        }

        [WebMethod]
        public SpecimentsInOrder GetDataSpeciment()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            int IdSpeciment = 2;

            //вытягиваем все тесты для спесимента ,у которого id=2
            GenericDaoImpl<SpecimentsInOrder, int> specimentDao = new GenericDaoImpl<SpecimentsInOrder, int>(SF.GetSession());
            SpecimentsInOrder spec = specimentDao.Get(IdSpeciment);

            spec.testsInOrderList = new List<int>();

            TestsInOrderDaoImpl testDao = new TestsInOrderDaoImpl(SF.GetSession());

            foreach (TestsInOrder item in testDao.GetTestsOfSpeciment(IdSpeciment).ToList())
            {
                spec.testsInOrderList.Add(item.ID_TestOrder);
            }

            SF.CloseSession();
            return spec;
        }

       
    }
}
