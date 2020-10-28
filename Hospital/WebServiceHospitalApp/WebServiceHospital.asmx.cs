﻿using System;
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
        public Patient GetDataPatient(int IdPatient)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            //выведем данные пациента с id=1 и его ордера
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            Patient p = patientDao.Get(IdPatient);
            //p.orderOfPatientList = new List<int>();

            //OrderOfPatientDaoImpl orderDao = new OrderOfPatientDaoImpl(SF.GetSession());

            //foreach (OrderOfPatient item in orderDao.GetOrdersOfPatient(IdPatient).ToList())
            //{
            //    p.orderOfPatientList.Add(item.ID_Order);
            //}

            SF.CloseSession();
            return p;
        }

        [WebMethod]
        public void SavePatient(Patient patient)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            patientDao.Save(patient);
           
            SF.CloseSession();
        }

        [WebMethod]
        public void UpdatePatient(Patient patient)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());

            Patient p = patientDao.Get(patient.ID_Patient);
            p.Lastname = patient.Lastname;
            p.Firstname = patient.Firstname;
            p.DOB = patient.DOB;
            p.SSN = patient.SSN;
            p.ID_Gender = patient.ID_Gender;
            patientDao.SaveOrUpdate(p);
          
            SF.CloseSession();
        }

        [WebMethod]
        public List<Gender> GetDataGender()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(SF.GetSession());
            List<Gender> list = new List<Gender>();
            list = genderDao.GetAll().ToList();

            SF.CloseSession();
            return list;
        }

        [WebMethod]
        public List<Relative> GetRelativesOfPatient(int IdPatient)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            Patient p = patientDao.Get(IdPatient);
            p.relativeList = new List<int>();

            RelativeDaoImpl relativeDao = new RelativeDaoImpl(SF.GetSession());
            List<Relative> tempList = relativeDao.GetListRelativesOfPatient(IdPatient).ToList();

            if (tempList.Count > 0)
            {
                foreach (Relative item in tempList)
                {
                    p.relativeList.Add(item.ID_Relative);
                }
            }
            SF.CloseSession();
            return tempList;
        }

        [WebMethod]
        public int SaveRelative(Relative relative)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Relative, int> relativeDao = new GenericDaoImpl<Relative, int>(SF.GetSession());
            int id=(relativeDao.Save(relative)).ID_Relative;

            SF.CloseSession();
            return id;
        }

        [WebMethod]
        public List<Patient> GetDataAllPatients()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            List<Patient> list = new List<Patient>();
            list = patientDao.GetAll().ToList();

            SF.CloseSession();
            return list;
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
