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
        public Patient GetDataPatient(int IdPatient)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

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
        public void AddPatient(List<Patient> listPatients)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(SF.GetSession());

            Gender male = genderDao.Get(1);
            Gender female = genderDao.Get(2);

            foreach (Patient item in listPatients)
            {
                if(item.Gender.ID_Gender== male.ID_Gender)
                {
                    item.Gender = male;
                }
                else if(item.Gender.ID_Gender == female.ID_Gender)
                {
                    item.Gender = female;
                }
                item.Status = 1;
                patientDao.Save(item);
            }
                    
            SF.CloseSession();
        }

        [WebMethod]
        public void UpdatePatient(List<Patient> listPatients)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(SF.GetSession());

            Gender male = genderDao.Get(1);
            Gender female = genderDao.Get(2);

            foreach (Patient item in listPatients)
            {
                Patient p = patientDao.Get(item.ID_Patient);
                p.Lastname = item.Lastname;
                p.Firstname = item.Firstname;
                p.DOB = item.DOB;
                p.SSN = item.SSN;

                if (item.Gender.ID_Gender == male.ID_Gender)
                {
                    p.Gender = male;
                }
                else if (item.Gender.ID_Gender == female.ID_Gender)
                {
                    p.Gender = female;
                }
                patientDao.SaveOrUpdate(p);             
            }
            SF.CloseSession();
        }

        [WebMethod]
        public void DeletePatient(List<Patient> listPatients)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());         
            RelativeDaoImpl relativeDao = new RelativeDaoImpl(SF.GetSession());
            OrderOfPatientDaoImpl orderDao = new OrderOfPatientDaoImpl(SF.GetSession());
            SpecimentsInOrderDaoImpl specimentDao = new SpecimentsInOrderDaoImpl(SF.GetSession());
            TestsInOrderDaoImpl testDao = new TestsInOrderDaoImpl(SF.GetSession());
            GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(SF.GetSession());

            List<Relative> listRel;          
            List<OrderOfPatient> listOrd;          
            List<SpecimentsInOrder> listSpec;           
            List<TestsInOrder> listTest;

            Gender male = genderDao.Get(1);
            Gender female = genderDao.Get(2);

            foreach (Patient patient in listPatients)
            {
                if (patient.Gender.ID_Gender == male.ID_Gender)
                {
                    patient.Gender = male;
                }
                else if (patient.Gender.ID_Gender == female.ID_Gender)
                {
                    patient.Gender = female;
                }

                listRel = relativeDao.GetListRelativesOfPatient(patient.ID_Patient).ToList();
                listOrd = orderDao.GetOrdersOfPatient(patient.ID_Patient).ToList();

                if (listRel.Count == 0 && listOrd.Count == 0)
                {
                    patientDao.Delete(patient);
                }
                else if (listRel.Count > 0 || listOrd.Count > 0)
                {
                    if (listRel.Count > 0)
                    {
                        foreach (Relative item in listRel)
                        {
                            item.Status = 0;
                            relativeDao.SaveOrUpdate(item);
                        }
                    }
                    if (listOrd.Count > 0)
                    {
                        foreach (OrderOfPatient item in listOrd)
                        {
                            item.Status = 0;
                            orderDao.SaveOrUpdate(item);

                            listSpec = specimentDao.GetSpecimentsOfOrder(item.ID_Order).ToList();

                            if (listSpec.Count > 0)
                            {
                                foreach (SpecimentsInOrder itemSpec in listSpec)
                                {
                                    itemSpec.Status = 0;
                                    specimentDao.SaveOrUpdate(itemSpec);

                                    listTest = testDao.GetTestsOfSpeciment(itemSpec.ID_SpecimentOrder).ToList();

                                    if (listTest.Count > 0)
                                    {
                                        foreach (TestsInOrder itemTest in listTest)
                                        {
                                            itemTest.Status = 0;
                                            testDao.SaveOrUpdate(itemTest);
                                        }
                                    }
                                }
                            }
                        }
                    }

                    patient.Status = 0;
                    patientDao.SaveOrUpdate(patient);
                }
            }
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
        public List<Relative> GetRelativesOfPatient(Patient patient)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
            Patient p = patientDao.Get(patient.ID_Patient);
            p.relativeList = new List<int>();

            RelativeDaoImpl relativeDao = new RelativeDaoImpl(SF.GetSession());
            List<Relative> tempList = relativeDao.GetListRelativesOfPatient(patient.ID_Patient).ToList();

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

        //[WebMethod]
        //public List<OrderOfPatient> GetOrdersOfPatient(int IdPatient)
        //{
        //    SessionFactory SF = new SessionFactory();
        //    SF.Init();
        //    SF.OpenSession();

        //    GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(SF.GetSession());
        //    Patient p = patientDao.Get(IdPatient);
        //    p.orderOfPatientList = new List<int>();

        //    OrderOfPatientDaoImpl orderDao = new OrderOfPatientDaoImpl(SF.GetSession());
        //    List<OrderOfPatient> tempList = orderDao.GetOrdersOfPatient(IdPatient).ToList();

        //    if (tempList.Count > 0)
        //    {
        //        foreach (OrderOfPatient item in tempList)
        //        {
        //            p.orderOfPatientList.Add(item.ID_Order);
        //        }
        //    }
        //    SF.CloseSession();
        //    return tempList;
        //}

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

            PatientDaoImpl patientDao = new PatientDaoImpl(SF.GetSession());
            List<Patient> list = new List<Patient>();
            list = patientDao.GetListOfPatientsWithActiveStatus().ToList();

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

        [WebMethod]
        public List<SpecimentsInOrder> GetDataAllSpeciments()
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            SpecimentsInOrderDaoImpl specimentDao = new SpecimentsInOrderDaoImpl(SF.GetSession());
            List<SpecimentsInOrder> list = new List<SpecimentsInOrder>();
            list = specimentDao.GetListOfSpecimentsWithActiveStatus().ToList();

            SF.CloseSession();
            return list;
        }

        [WebMethod]
        public void AddSpeciment(List<SpecimentsInOrder> listSpeciments)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            GenericDaoImpl<SpecimentsInOrder, int> specimentDao = new GenericDaoImpl<SpecimentsInOrder, int>(SF.GetSession());
            GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(SF.GetSession());
            GenericDaoImpl<Speciment, int> specimentNameDao = new GenericDaoImpl<Speciment, int>(SF.GetSession());
            GenericDaoImpl<SpecimentStatus, int> specimentStatusDao = new GenericDaoImpl<SpecimentStatus, int>(SF.GetSession());

            //Gender male = genderDao.Get(1);
            //Gender female = genderDao.Get(2);

            foreach (SpecimentsInOrder item in listSpeciments)
            {
                //if (item.Gender.ID_Gender == male.ID_Gender)
                //{
                //    item.Gender = male;
                //}
                //else if (item.Gender.ID_Gender == female.ID_Gender)
                //{
                //    item.Gender = female;
                //}
                item.Status = 1;
                specimentDao.Save(item);
            }

            SF.CloseSession();
        }

        [WebMethod]
        public void UpdateSpeciment(List<SpecimentsInOrder> listSpeciments)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

            
            SF.CloseSession();
        }

        [WebMethod]
        public void DeleteSpeciment(List<SpecimentsInOrder> listSpeciments)
        {
            SessionFactory SF = new SessionFactory();
            SF.Init();
            SF.OpenSession();

           
            SF.CloseSession();
        }

    }
}
