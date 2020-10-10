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
using System.Threading;


namespace DAOLayer
{
    class Program
    {
       
        //private static List<Patient> patients = new List<Patient>();

        //public static void ShowDataPatientWithRelatives()
        //{
        //    foreach (Patient item in patients)
        //    {
        //  /*      foreach (Relative itemRelative in item.RelativeInList)
        //        {
        //            Console.WriteLine(item.ToString() + itemRelative.ToString());
        //            Console.WriteLine();
        //        }*/
        //    }
        //}

        //public static void ShowAllData()
        //{
        //    foreach (Patient item in patients)
        //    {
        //        foreach ( OrderOfPatient itemOrder in item.OrderOfPatientInList)
        //        {
        //            Console.WriteLine(item.ToString() + itemOrder.ToString());
        //            foreach (SpecimentsInOrder itemSpeciment in itemOrder.SpecimentsInOrderList)
        //            {
        //                Console.WriteLine(itemSpeciment.ToString());
        //                foreach (TestsInOrder itemTest in itemSpeciment.TestsInOrderList)
        //                {
        //                    Console.WriteLine(itemTest.ToString());
        //                }
        //                Console.WriteLine();
        //            }
        //        }
        //        Console.WriteLine("=================================================");
        //    }       
        //}

        
       // public static void DataPatientSave(SessionFactory sessionFactory)
       // {
       //     sessionFactory.OpenSession();

       //     //GenericDaoImpl<TestsInOrder, int> testOrderDao = new GenericDaoImpl<TestsInOrder, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<OrderStatus, int> orderStatusDao = new GenericDaoImpl<OrderStatus, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<Doctor, int> doctorDao = new GenericDaoImpl<Doctor, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<SpecimentsInOrder, int> specimentInOrderDao = new GenericDaoImpl<SpecimentsInOrder, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<Speciment, int> specimentDao = new GenericDaoImpl<Speciment, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<SpecimentStatus, int> specimentStatusDao = new GenericDaoImpl<SpecimentStatus, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<Test, int> testDao = new GenericDaoImpl<Test, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<TestStatus, int> testStatusDao = new GenericDaoImpl<TestStatus, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<TestsInOrder, int> testOrderDao = new GenericDaoImpl<TestsInOrder, int>(sessionFactory.GetSession());

       //     OrderOfPatient order = new OrderOfPatient();
       //     order.DateOrder = Convert.ToDateTime("27/09/2020");
       //     order.Symptoms = "paining throat";
       //     order.Patient = new Patient();
       //     order.Patient.InitOrderOfPatientList();
       //     order.Patient.Lastname = "Titarenko";
       //     order.Patient.Firstname = "Nikolaj";
       //     order.Patient.DOB = Convert.ToDateTime("23/07/1967");
       //     order.Patient.SSN = 961766524;
       //     order.Patient.Gender = genderDao.Get(1);
       //     order.Doctor = doctorDao.Get(2);
       //     order.OrderStatus = orderStatusDao.Get(1);
       //     OrderOfPatient tempOrder = orderDao.Save(order);

       //     TestsInOrder test1 = new TestsInOrder();
       //     test1.InitSpecimentsInOrderList();  //инициализировать в самом начале 
       //     test1.Test = testDao.Get(3);
       //     test1.DateStart = Convert.ToDateTime("28/09/2020");
       //     test1.DateEnd = Convert.ToDateTime("29/09/2020");
       //     test1.TestStatus = testStatusDao.Get(3);
       //     test1.Result = "";
       //     Thread.Sleep(1000);  //без слипа не успевает проинициализ-ся список и сейвится null
       //     TestsInOrder tempTest1 = testOrderDao.Save(test1);

       //     TestsInOrder test2 = new TestsInOrder();
       //     test2.InitSpecimentsInOrderList();
       //     test2.Test = testDao.Get(6);
       //     test2.DateStart = Convert.ToDateTime("28/09/2020");
       //     test2.DateEnd = Convert.ToDateTime("29/09/2020");
       //     test2.TestStatus = testStatusDao.Get(6);
       //     test2.Result = "";
       //     Thread.Sleep(1000);
       //     TestsInOrder tempTest2 = testOrderDao.Save(test2);

       //     SpecimentsInOrder speciment = new SpecimentsInOrder();
       //     speciment.OrderOfPatient = orderDao.Get(tempOrder.ID_Order);
       //     speciment.Speciment = specimentDao.Get(1);
       //     speciment.SpecimentStatus = specimentStatusDao.Get(4);
       //     speciment.DateOfTaking = Convert.ToDateTime("28/09/2020");
       //     speciment.Nurse = "Abramova";
       //     speciment.InitTestsInOrderList();
       //     speciment.TestsInOrderList.Add(tempTest1);
       //     speciment.TestsInOrderList.Add(tempTest2);
       //     specimentInOrderDao.Save(speciment);

       //     sessionFactory.CloseSession();
       // }

       // public static void DataPatientGet(SessionFactory sessionFactory)
       // {
       //     sessionFactory.OpenSession();
       //     GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
       //     Console.WriteLine("Data of the 2nd patient for example:\n");
       //     Console.WriteLine(patientDao.Get(2));

       //     sessionFactory.CloseSession();
       // }

       // public static void DataPatientUpdate(SessionFactory sessionFactory)
       // {
       //     sessionFactory.OpenSession();

       //     GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());

       //     Console.WriteLine("Updating patient of the 3rd order for example:\n");
       //     Console.WriteLine("Before updating: " + patientDao.Get(2) + "\n" + orderDao.Get(3));

       //     OrderOfPatient order = orderDao.Get(3);
       //     order.Patient.Lastname = "Avramenko";
       //     order.Patient.Firstname = "Elena";
       //     order.Patient.DOB = Convert.ToDateTime("07/03/1987");
       //     order.DateOrder = Convert.ToDateTime("11/10/2020");
       //     orderDao.SaveOrUpdate(order);

       //     Console.WriteLine("After updating: " + patientDao.Get(2) + "\n" + orderDao.Get(3));

       //     Console.WriteLine("\n");
       //     sessionFactory.CloseSession();
       // }

       // public static void DataPatientDelete(SessionFactory sessionFactory)
       // {
       //     sessionFactory.OpenSession();

       //     GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<Relative, int> relativeDao = new GenericDaoImpl<Relative, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<SpecimentsInOrder, int> specimentDao = new GenericDaoImpl<SpecimentsInOrder, int>(sessionFactory.GetSession());
       //     GenericDaoImpl<TestsInOrder, int> testDao = new GenericDaoImpl<TestsInOrder, int>(sessionFactory.GetSession());

       //     List<Relative> relativeList = new List<Relative>();
       //     List<OrderOfPatient> orderList = new List<OrderOfPatient>();
       //     List<SpecimentsInOrder> specimentList = new List<SpecimentsInOrder>();
       //     List<TestsInOrder> testList = new List<TestsInOrder>();

       //     Patient patient = patientDao.Get(3);
       //     IQueryable<OrderOfPatient> orders = sessionFactory.GetSession().Query<OrderOfPatient>()
       //     .Where(p => p.Patient.ID_Patient == patient.ID_Patient);

       //     Console.WriteLine(patient.ToString());
       ///*     foreach (Relative itemRelative in patient.RelativeInList)
       //     {
       //         Console.WriteLine(itemRelative.ToString());
       //         relativeList.Add(itemRelative);
       //     }*/

       //     foreach (OrderOfPatient itemOrder in orders)
       //     {
       //         Console.WriteLine(itemOrder.ToString());

       //         IQueryable <SpecimentsInOrder> speciments = sessionFactory.GetSession().Query<SpecimentsInOrder>()
       //            .Where(sp => sp.OrderOfPatient.ID_Order == itemOrder.ID_Order);
       //         orderList.Add(itemOrder);
               
       //         foreach (SpecimentsInOrder itemSpeciment in speciments)
       //         {
       //             Console.WriteLine(itemSpeciment.ToString());
       //             specimentList.Add(itemSpeciment);

       //             foreach (TestsInOrder itemTest in itemSpeciment.TestsInOrderList)
       //             {
       //                 Console.WriteLine(itemTest.ToString());
       //                 testList.Add(itemTest);
       //             }
       //         }
       //         Console.WriteLine("+++++++++++++");
       //     }

       //     Console.WriteLine("===================");
       //     foreach (Relative item in relativeList)
       //     {
       //         relativeDao.Delete(item);
       //     }
       //     foreach (TestsInOrder item in testList)
       //     {
       //         testDao.Delete(item);
       //     }
       //     foreach (SpecimentsInOrder item in specimentList)
       //     {
       //         specimentDao.Delete(item);
       //     }
       //     foreach (OrderOfPatient item in orderList)
       //     {
       //         orderDao.Delete(item);
       //     }

       //     patientDao.Delete(patient);

       //     sessionFactory.CloseSession();
       // }

       // public static void DataGetAll(SessionFactory sessionFactory)
       // {
       //     sessionFactory.OpenSession();
       //     GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());

       //     foreach (Patient item in patientDao.GetAll().ToList())
       //     {
       //         Console.Write(item.ToString());
       //     }
       //     Console.WriteLine("\n");
       //     sessionFactory.CloseSession();
       // }

       // public static void DataGetByLastname(SessionFactory sessionFactory)
       // {
       //     Console.WriteLine("Enter lastname:");
       //     String lastname = Console.ReadLine();

       //     if (lastname.CompareTo("")!= 0)
       //     {
       //         sessionFactory.OpenSession();
       //         PatientDaoImpl patientDao = new PatientDaoImpl(sessionFactory.GetSession());

       //         foreach (Patient item in patientDao.GetByLastname(lastname).ToList())
       //         {
       //             Console.Write(item.ToString());
       //         }
       //         Console.WriteLine("\n");
       //         sessionFactory.CloseSession();
       //     }
       //     else
       //     {
       //         Console.WriteLine("Lastname must be entered");
       //     }           
       // }

       // public static void DataGetOrdersByDate(SessionFactory sessionFactory)
       // {
       //     Console.WriteLine("Enter year:");
       //     String year = Console.ReadLine();
       //     Console.WriteLine("Enter month:");
       //     String month = Console.ReadLine();
       //     Console.WriteLine("Enter day:");
       //     String day = Console.ReadLine();

       //     if (day.CompareTo("")!=0 && month.CompareTo("")!= 0 && year.CompareTo("")!= 0)
       //     {
       //         sessionFactory.OpenSession();

       //         DateTime dateOrder = Convert.ToDateTime(day + "/" + month + "/" + year);
       //         OrderOfPatientDaoImpl orderDao = new OrderOfPatientDaoImpl(sessionFactory.GetSession());

       //         foreach (OrderOfPatient item in orderDao.GetOrdersByDate(dateOrder).ToList())
       //         {
       //             Console.Write(item.ToString());
       //         }
       //         Console.WriteLine("\n");
       //         sessionFactory.CloseSession();
       //     }
       //     else
       //     {
       //         Console.WriteLine("All values must be entered");
       //     }          
       // }



        static void Main(string[] args)
        {
            try
            {
                //SessionFactory SF = new SessionFactory();
                //SF.Init();

                //int choice;
                //do
                //{
                //    Console.WriteLine("Choose data you want to see:");
                //    Console.WriteLine("1-Save data of patient(ready)\n2-Get data of the patient(ready)" +
                //        "\n3-Update data of patient(ready)\n4-Delete all data about patient(ready)" +
                //        "\n5-List of patients(ready)\n6-Find patient by lastname\n7-Find orders by date\n8 -Exit");
                //    choice = Convert.ToInt32(Console.ReadLine());

                //    switch (choice)
                //    {
                //        case 1:
                //            {
                //                Console.Clear();
                //                DataPatientSave(SF);
                //            }
                //            break;
                //        case 2:
                //            {
                //                Console.Clear();
                //                DataPatientGet(SF);
                //            }
                //            break;
                //        case 3:
                //            {
                //                Console.Clear();
                //                DataPatientUpdate(SF);
                //            }
                //            break;
                //        case 4:
                //            {
                //                Console.Clear();
                //                DataPatientDelete(SF);
                //            }
                //            break;
                //        case 5:
                //            {
                //                Console.Clear();
                //                DataGetAll(SF);
                //            }
                //            break;
                //        case 6:
                //            {
                //                Console.Clear();
                //                DataGetByLastname(SF);
                //            }
                //            break;
                //        case 7:
                //            {
                //                Console.Clear();
                //                DataGetOrdersByDate(SF);
                //            }
                //            break;
                //    }
                //} while (choice != 8);

















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
