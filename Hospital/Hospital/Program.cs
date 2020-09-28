using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using Npgsql;
using ServiceStack;
using NHibernate.Id;
using NHibernate.Tool.hbm2ddl;
using NHibernate.Util;

namespace Hospital
{
    class Program
    {
       
        private static List<Patient> patients = new List<Patient>();

        public static void ShowDataPatientWithRelatives()
        {
            foreach (Patient item in patients)
            {
                foreach (Relative itemRelative in item.RelativeInList)
                {
                    Console.WriteLine(item.ToString() + itemRelative.ToString());
                    Console.WriteLine();
                }
            }
        }

        public static void ShowAllData()
        {
            foreach (Patient item in patients)
            {
                foreach ( OrderOfPatient itemOrder in item.OrderOfPatientInList)
                {
                    Console.WriteLine(item.ToString() + itemOrder.ToString());
                    foreach (SpecimentsInOrder itemSpeciment in itemOrder.SpecimentsInOrderList)
                    {
                        Console.WriteLine(itemSpeciment.ToString());
                        foreach (TestsInOrder itemTest in itemSpeciment.TestsInOrderList)
                        {
                            Console.WriteLine(itemTest.ToString());
                        }
                        Console.WriteLine();
                    }
                }
                Console.WriteLine("=================================================");
            }       
        }

        
        public static void DataPatientSave(SessionFactory sessionFactory)
        {
            sessionFactory.OpenSession();

            //GenericDaoImpl<TestsInOrder, int> testOrderDao = new GenericDaoImpl<TestsInOrder, int>(sessionFactory.GetSession());
            GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(sessionFactory.GetSession());
            GenericDaoImpl<OrderStatus, int> orderStatusDao = new GenericDaoImpl<OrderStatus, int>(sessionFactory.GetSession());
            GenericDaoImpl<Doctor, int> doctorDao = new GenericDaoImpl<Doctor, int>(sessionFactory.GetSession());
            GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());
            GenericDaoImpl<SpecimentsInOrder, int> specimentInOrderDao = new GenericDaoImpl<SpecimentsInOrder, int>(sessionFactory.GetSession());
            GenericDaoImpl<Speciment, int> specimentDao = new GenericDaoImpl<Speciment, int>(sessionFactory.GetSession());
            GenericDaoImpl<SpecimentStatus, int> specimentStatusDao = new GenericDaoImpl<SpecimentStatus, int>(sessionFactory.GetSession());
            GenericDaoImpl<Test, int> testDao = new GenericDaoImpl<Test, int>(sessionFactory.GetSession());
            GenericDaoImpl<TestStatus, int> testStatusDao = new GenericDaoImpl<TestStatus, int>(sessionFactory.GetSession());

            OrderOfPatient order = new OrderOfPatient();
            order.DateOrder = Convert.ToDateTime("27/09/2020");
            order.Symptoms = "paining throat";
            order.Patient = new Patient();
            order.Patient.InitOrderOfPatientList();
            order.Patient.Lastname = "Titarenko";
            order.Patient.Firstname = "Nikolaj";
            order.Patient.DOB = Convert.ToDateTime("23/07/1967");
            order.Patient.SSN = 295959865;
            order.Patient.Gender = genderDao.Get(1);
            order.Doctor = doctorDao.Get(2);
            order.OrderStatus = orderStatusDao.Get(1);
            OrderOfPatient tempOrder = orderDao.Save(order);

            SpecimentsInOrder speciment = new SpecimentsInOrder();
            speciment.OrderOfPatient = orderDao.Get(tempOrder.ID_Order);
            speciment.Speciment = specimentDao.Get(1);
            speciment.SpecimentStatus = specimentStatusDao.Get(4);
            speciment.DateOfTaking = Convert.ToDateTime("28/09/2020");
            speciment.Nurse = "Abramova";
            speciment.InitTestsInOrderList();

            speciment.TestsInOrderList.Add(new TestsInOrder()
            {
                Test = testDao.Get(3),
                DateStart = Convert.ToDateTime("28/09/2020"),
                DateEnd = Convert.ToDateTime("29/09/2020"),
                TestStatus = testStatusDao.Get(3),
                Result = ""
            });

            speciment.TestsInOrderList.Add(new TestsInOrder()
            {
                Test = testDao.Get(6),
                DateStart = Convert.ToDateTime("28/09/2020"),
                DateEnd = Convert.ToDateTime("29/09/2020"),
                TestStatus = testStatusDao.Get(6),
                Result = ""
            });
            specimentInOrderDao.Save(speciment);

           

            //1 Variant (if all initilizing in main)-GenericADOException couldn't insert into TestsInOrder
            //speciment.TestsInOrderList.Add(new TestsInOrder()
            //{
            //    SpecimentsInOrderList = new List<SpecimentsInOrder>(),
            //    Test = testDao.Get(3),
            //    DateStart = Convert.ToDateTime("28/09/2020"),
            //    DateEnd = Convert.ToDateTime("29/09/2020"),
            //    TestStatus = testStatusDao.Get(3),
            //    Result = ""               
            //});

            //speciment.TestsInOrderList.Add(new TestsInOrder()
            //{
            //    SpecimentsInOrderList = new List<SpecimentsInOrder>(),
            //    Test = testDao.Get(6),
            //    DateStart = Convert.ToDateTime("28/09/2020"),
            //    DateEnd = Convert.ToDateTime("29/09/2020"),
            //    TestStatus = testStatusDao.Get(6),
            //    Result = ""
            //});



            //2 Variant (if all initilizing in main)-GenericADOException couldn't insert into TestsInOrder
            //SpecimentsInOrder speciment = new SpecimentsInOrder();
            //speciment.OrderOfPatient = orderDao.Get(tempOrder.ID_Order);
            //speciment.Speciment = specimentDao.Get(1);
            //speciment.SpecimentStatus = specimentStatusDao.Get(4);
            //speciment.DateOfTaking = Convert.ToDateTime("28/09/2020");
            //speciment.Nurse = "Abramova";
            //speciment.InitTestsInOrderList();
            //SpecimentsInOrder tempSpeciment=specimentInOrderDao.Save(speciment);

            //TestsInOrder test1 = new TestsInOrder();
            //test1.InitSpecimentsInOrderList();
            //test1.Test = testDao.Get(3);
            //test1.DateStart = Convert.ToDateTime("28/09/2020");
            //test1.DateEnd = Convert.ToDateTime("29/09/2020");
            //test1.TestStatus = testStatusDao.Get(3);
            //test1.Result = "";
            //TestsInOrder tempTest1 = testOrderDao.Save(test1);

            //SpecimentsInOrder specimentUpd = specimentInOrderDao.Get(tempSpeciment.ID_SpecimentOrder);
            //specimentUpd.TestsInOrderList.Add(testOrderDao.Get(tempTest1.ID_TestOrder));
            //specimentInOrderDao.SaveOrUpdate(specimentUpd);

            //TestsInOrder testUpd = testOrderDao.Get(tempTest1.ID_TestOrder);
            //testUpd.SpecimentsInOrderList.Add(specimentInOrderDao.Get(tempSpeciment.ID_SpecimentOrder));
            //testOrderDao.SaveOrUpdate(testUpd);

            sessionFactory.CloseSession();
        }

        public static void DataPatientGet(SessionFactory sessionFactory)
        {
            sessionFactory.OpenSession();
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
            Console.WriteLine("Data of the 2nd patient for example:\n");
            Console.WriteLine(patientDao.Get(2));

            sessionFactory.CloseSession();
        }

        public static void DataPatientUpdate(SessionFactory sessionFactory)
        {
            sessionFactory.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
            GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());

            Console.WriteLine("Updating patient of the 3rd order for example:\n");
            Console.WriteLine("Before updating: "+patientDao.Get(2)+"\n"+ orderDao.Get(3));

            OrderOfPatient order = orderDao.Get(3);
            order.Patient.Lastname= "Avramenko";
            order.Patient.Firstname = "Elena";
            order.Patient.DOB = Convert.ToDateTime("07/03/1987");
            order.DateOrder= Convert.ToDateTime("11/10/2020");
            orderDao.SaveOrUpdate(order);

            Console.WriteLine("After updating: " + patientDao.Get(2) + "\n" + orderDao.Get(3));

            Console.WriteLine("\n");
            sessionFactory.CloseSession();
        }

        public static void DataPatientDelete(SessionFactory sessionFactory)
        {
            sessionFactory.OpenSession();

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
            GenericDaoImpl<Relative, int> relativeDao = new GenericDaoImpl<Relative, int>(sessionFactory.GetSession());
            GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());
            GenericDaoImpl<SpecimentsInOrder, int> specimentDao = new GenericDaoImpl<SpecimentsInOrder, int>(sessionFactory.GetSession());
            GenericDaoImpl<TestsInOrder, int> testDao = new GenericDaoImpl<TestsInOrder, int>(sessionFactory.GetSession());

            List<Relative> relativeList = new List<Relative>();
            List<OrderOfPatient> orderList = new List<OrderOfPatient>();
            List<SpecimentsInOrder> specimentList = new List<SpecimentsInOrder>();
            List<TestsInOrder> testList = new List<TestsInOrder>();

            Patient patient = patientDao.Get(3);
            var orders = sessionFactory.GetSession().Query<OrderOfPatient>()
            .Where(p => p.Patient.ID_Patient == patient.ID_Patient);

            Console.WriteLine(patient.ToString());
            foreach (Relative itemRelative in patient.RelativeInList)
            {
                Console.WriteLine(itemRelative.ToString());
                relativeList.Add(itemRelative);
            }

            foreach (OrderOfPatient itemOrder in orders)
            {
                Console.WriteLine(itemOrder.ToString());

                var speciments = sessionFactory.GetSession().Query<SpecimentsInOrder>()
                   .Where(sp => sp.OrderOfPatient.ID_Order == itemOrder.ID_Order);
                orderList.Add(itemOrder);
               
                foreach (SpecimentsInOrder itemSpeciment in speciments)
                {
                    Console.WriteLine(itemSpeciment.ToString());
                    specimentList.Add(itemSpeciment);

                    foreach (TestsInOrder itemTest in itemSpeciment.TestsInOrderList)
                    {
                        Console.WriteLine(itemTest.ToString());
                        testList.Add(itemTest);
                    }
                }
                Console.WriteLine("+++++++++++++");
            }

            Console.WriteLine("===================");
            foreach (Relative item in relativeList)
            {
                relativeDao.Delete(item);
            }
            foreach (TestsInOrder item in testList)
            {
                testDao.Delete(item);
            }
            foreach (SpecimentsInOrder item in specimentList)
            {
                specimentDao.Delete(item);
            }
            foreach (OrderOfPatient item in orderList)
            {
                orderDao.Delete(item);
            }

            patientDao.Delete(patient);

            sessionFactory.CloseSession();
        }

        public static void DataGetAll(SessionFactory sessionFactory)
        {
            sessionFactory.OpenSession();
            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());

            foreach (Patient item in patientDao.GetAll().ToList())
            {
                Console.Write(item.ToString());
            }
            Console.WriteLine("\n");
            sessionFactory.CloseSession();
        }

            static void Main(string[] args)
        {
            try
            {
                SessionFactory SF = new SessionFactory();
                SF.Init();

                int choice;
                do
                {
                    Console.WriteLine("Choose data you want to see:");
                    Console.WriteLine("1-Save data of patient(ready)\n2-Get data of the patient(ready)"+
                        "\n3-Update data of patient(ready)\n4-Delete all data about patient(ready)"+
                        "\n5-List of patients(ready)\n6-Exit");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Clear();
                                DataPatientSave(SF);
                            }
                            break;
                        case 2:
                            {
                                Console.Clear();
                                DataPatientGet(SF);
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                DataPatientUpdate(SF);
                            }
                            break;
                        case 4:
                            {
                                Console.Clear();
                                DataPatientDelete(SF);
                            }
                            break;
                        case 5:
                            {
                                Console.Clear();
                                DataGetAll(SF);
                            }
                            break;
                    }
                } while (choice != 6);

















                //Configuration nhConfig = new Configuration();
                //nhConfig.Configure();
                //ISessionFactory sessionFactory = nhConfig.BuildSessionFactory();
                //Console.WriteLine("NHibernate Configured!");
                //Console.ReadKey();
                //ISession session = sessionFactory.OpenSession();

                //using (ITransaction tx = session.BeginTransaction())
                //{
                //    ICriteria criteria = session.CreateCriteria<Patient>();
                //    criteria.CreateAlias("Gender", "gender", JoinType.LeftOuterJoin);
                //    criteria.CreateAlias("RelativeInList", "relative", JoinType.LeftOuterJoin);
                //    criteria.CreateAlias("OrderOfPatientInList", "order", JoinType.InnerJoin);
                //    criteria.SetResultTransformer(new DistinctRootEntityResultTransformer());
                //    IList<Patient> list = criteria.List<Patient>();
                //    patients = list.ToList();

                //    int choice;
                //    do
                //    {
                //        Console.WriteLine("Choose data you want to see:");
                //        Console.WriteLine("1-Patient and his relatives\n2-Patient and his doctors" +
                //            "\n3-Orders of patients\n4-Speciments of order\n5-Tests of speciment\n6-Exit");
                //        choice = Convert.ToInt32(Console.ReadLine());

                //        switch (choice)
                //        {
                //            case 1:
                //                {
                //                    Console.Clear();
                //                    ShowDataPatientWithRelatives();
                //                }
                //                break;
                //            case 2:
                //                {
                //                    Console.Clear();
                //                    ShowDataPatientAndHisDoctors();
                //                }
                //                break;
                //            case 3:
                //                {
                //                    Console.Clear();
                //                    ShowDataOrderOfPatient();
                //                }
                //                break;
                //            case 4:
                //                {
                //                    Console.Clear();
                //                    ShowSpecimentsOfPatient();
                //                }
                //                break;
                //            case 5:
                //                {
                //                    Console.Clear();
                //                    ShowTestsOfSpeciment();
                //                }
                //                break;
                //        }
                //    } while (choice != 6);
                //}
                //session.Flush();
                //session.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error (" + ex.GetType().Name + "): " + ex.Message);
            }
        }
    }
}
