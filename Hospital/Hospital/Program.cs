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





        public static void DataSave()
        {
            GenericImpl<Patient, int> patientDao = new GenericImpl<Patient, int>();
            Patient patient = new Patient();
            patient.Lastname = "Kovalenko3";
            patient.Firstname = "Natalya3";
            patient.SSN = 551274479;  //не забыть что поле unique
            patientDao.Save(patient);

            GenericImpl<Gender, int> genderDao = new GenericImpl<Gender, int>();
            Gender gender = new Gender();
            gender.GenderName = "bird";
            genderDao.Save(gender);

            GenericImpl<TestsInOrder, int> testsDao = new GenericImpl<TestsInOrder, int>();
            TestsInOrder tests = new TestsInOrder();
            tests.Result = " not healthy";
            testsDao.Save(tests);
        }

        public static void DataGet()
        {
            GenericImpl<Gender, int> genderDao = new GenericImpl<Gender, int>();
            Console.WriteLine("Gender is " + genderDao.Get(1).GenderName);
            Console.WriteLine(genderDao.Get(1));

            GenericImpl<Patient, int> patientDao = new GenericImpl<Patient, int>();
            Console.WriteLine(patientDao.Get(2));

            GenericImpl<SpecimentsInOrder, int> specimentDao = new GenericImpl<SpecimentsInOrder, int>();
            Console.WriteLine(specimentDao.Get(3));
        }

        public static void DataDelete()
        {
            GenericImpl<Gender, int> genderDao = new GenericImpl<Gender, int>();
            genderDao.Delete(genderDao.Get(58));
        }

        static void Main(string[] args)
        {
            try
            {
                SessionFactory.Init();
                int choice;
                do
                {
                    Console.WriteLine("Choose data you want to see:");
                    Console.WriteLine("1-Save data\n2-Get some data" +
                        "\n3-Delete Data\n4-Exit");
                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            {
                                Console.Clear();
                                DataSave();
                            } break;
                        case 2:
                            {
                                Console.Clear();
                                DataGet();
                            } break;
                        case 3:
                            {
                                Console.Clear();
                                DataDelete();
                            } break;
                    }
                } while (choice != 4);
            
               

           


           










            //Configuration nhConfig = new Configuration();
            //nhConfig.Configure();
            //ISessionFactory sessionFactory = nhConfig.BuildSessionFactory();
            //Console.WriteLine("NHibernate Configured!");
            //Console.ReadKey();
            //ISession session = sessionFactory.OpenSession();

            //using (ITransaction tx = session.BeginTransaction())
            //{                 
            //        ICriteria criteria = session.CreateCriteria<Patient>();
            //        criteria.CreateAlias("Gender", "gender", JoinType.LeftOuterJoin);
            //        criteria.CreateAlias("RelativeInList", "relative", JoinType.LeftOuterJoin);
            //        criteria.CreateAlias("OrderOfPatientInList", "order", JoinType.InnerJoin);
            //        criteria.SetResultTransformer(new DistinctRootEntityResultTransformer());
            //        IList<Patient> list = criteria.List<Patient>();
            //        patients = list.ToList();

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
            //                } break;
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
            //                } break;
            //            case 4:
            //                {
            //                    Console.Clear();
            //                    ShowSpecimentsOfPatient();
            //                } break;
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
