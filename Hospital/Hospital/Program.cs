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

        public static void ShowDataPatientAndHisDoctors()
        {
            foreach (Patient item in patients)
            {
                foreach (Doctor itemDoctor in item.DoctorInList)
                {
                    Console.WriteLine(item.ToString() + itemDoctor.ToString());
                    Console.WriteLine();
                }
            }
        }

        public static void ShowDataOrderOfPatient()
        {          
            foreach (Patient item in patients)
            {
                foreach (OrderOfPatient itemOrder in item.OrderOfPatientInList)
                {
                    Console.WriteLine(item.ToString() + itemOrder.ToString());
                    Console.WriteLine();
                }
            }          
        }

        public static void ShowSpecimentsOfPatient()
        {
            foreach (Patient item in patients)
            {
                Console.WriteLine("\n"+item.ToString());
                foreach (OrderOfPatient itemOrder in item.OrderOfPatientInList)
                {
                    Console.WriteLine("\nOrder №" + itemOrder.ID_Order);
                    foreach (SpecimentsInOrder itemSpeciment in itemOrder.SpecimentsInOrderList)
                    {
                        Console.WriteLine(itemSpeciment.ToString());
                    }
                }
                Console.WriteLine("=================================================");
            }
        }

        public static void ShowTestsOfSpeciment()
        {
            foreach (Patient item in patients)
            {
                Console.WriteLine("\n" + item.ToString());
                foreach (OrderOfPatient itemOrder in item.OrderOfPatientInList)
                {
                    Console.WriteLine("\nOrder №" + itemOrder.ID_Order);
                    foreach (SpecimentsInOrder itemSpeciment in itemOrder.SpecimentsInOrderList)
                    {
                        Console.WriteLine(itemSpeciment.ToString());
                        foreach (TestsInOrder itemTest in itemSpeciment.TestsInOrder)
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

            GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>(sessionFactory.GetSession());  
            
            GenericDaoImpl<OrderStatus, int> orderStatusDao = new GenericDaoImpl<OrderStatus, int>(sessionFactory.GetSession()); 
            
           // GenericDaoImpl<OrderOfPatient, int> orderDao = new GenericDaoImpl<OrderOfPatient, int>(sessionFactory.GetSession());

            //GenericDaoImpl<Doctor, int> doctorDao = new GenericDaoImpl<Doctor, int>(sessionFactory.GetSession());
            //Doctor doctor = new Doctor();
            ////doctor = doctorDao.Get(2);
            //doctor.Lastname = "Ivanov";
            //doctor.Firstname = "Ivan";
            //doctor.FieldOfMedicine = "terapevt";

            GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>(sessionFactory.GetSession());
            Patient patient = new Patient();
            patient.Lastname = "Stadnik2";
            patient.Firstname = "Igor2";
            patient.SSN = 859717630;  //не забыть что поле unique
            patient.Gender = genderDao.Get(1);
            patient.DOB = Convert.ToDateTime("11/03/1997");
            patient.InitOrderOfPatientList();
            patient.OrderOfPatientInList.Add(new OrderOfPatient { DateOrder= Convert.ToDateTime("20/09/2020"),Symptoms = "pain", OrderStatus = orderStatusDao.Get(1) });
            patient.InitDoctorList();
            patient.DoctorInList.Add(new Doctor { Lastname = "Cruglova2", Firstname = "Svetlana2", FieldOfMedicine = "terapevt" });
            //patient.DoctorInList.Add(doctor);
            patientDao.Save(patient);

            //ShowDataPatientAndHisDoctors();

            //GenericDaoImpl<TestsInOrder, int> testsDao = new GenericDaoImpl<TestsInOrder, int>();
            //TestsInOrder tests = new TestsInOrder();
            //tests.Result = " not healthy";
            //testsDao.Save(tests);

            sessionFactory.CloseSession();
        }

        public static void DataGet()
        {
            //GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>();
            //Console.WriteLine("Gender is " + genderDao.Get(1).GenderName);
            //Console.WriteLine(genderDao.Get(1));

            //GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>();
            //Console.WriteLine(patientDao.Get(2));

            //GenericDaoImpl<SpecimentsInOrder, int> specimentDao = new GenericDaoImpl<SpecimentsInOrder, int>();
            //Console.WriteLine(specimentDao.Get(3));
            //Console.WriteLine("\n");
        }

        public static void DataDelete()
        {
            //GenericDaoImpl<Gender, int> genderDao = new GenericDaoImpl<Gender, int>();
            //genderDao.Delete(genderDao.Get(58));
        }

        public static void DataGetAll()
        {
            //GenericDaoImpl<Patient, int> patientDao = new GenericDaoImpl<Patient, int>();

            //foreach  (Patient item in patientDao.GetAll().ToList())
            //{
            //    Console.Write(item.ToString());
            //}
            //Console.WriteLine("\n");
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
                    Console.WriteLine("1-Save data of patient\n2-Get some data" +
                        "\n3-Delete data\n4-Get all data\n5-Exit");
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
                                DataGet();
                            }
                            break;
                        case 3:
                            {
                                Console.Clear();
                                DataDelete();
                            }
                            break;
                        case 4:
                            {
                                Console.Clear();
                                DataGetAll();
                            }
                            break;
                    }
                } while (choice != 5);

















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
