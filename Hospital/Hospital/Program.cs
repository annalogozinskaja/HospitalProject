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
                    }
                }
                Console.WriteLine("=================================================");
            }
        }


        static void Main(string[] args)
        {
            try
            {
                Configuration nhConfig = new Configuration();
                nhConfig.Configure();
                ISessionFactory sessionFactory = nhConfig.BuildSessionFactory();
                Console.WriteLine("NHibernate Configured!");
                Console.ReadKey();
                ISession session = sessionFactory.OpenSession();

                using (ITransaction tx = session.BeginTransaction())
                {                 
                        ICriteria criteria = session.CreateCriteria<Patient>();
                        criteria.CreateAlias("Gender", "gender", JoinType.LeftOuterJoin);
                        criteria.CreateAlias("RelativeInList", "relative", JoinType.LeftOuterJoin);
                        criteria.CreateAlias("OrderOfPatientInList", "order", JoinType.InnerJoin);
                        criteria.SetResultTransformer(new DistinctRootEntityResultTransformer());
                        IList<Patient> list = criteria.List<Patient>();
                        patients = list.ToList();

                    int choice;
                    do
                    {
                        Console.WriteLine("Choose data you want to see:");
                        Console.WriteLine("1-Patient and his relatives\n2-Orders of patients" +
                            "\n3-Speciments of order\n4-Tests of speciment\n5-Exit");
                        choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                {
                                    Console.Clear();
                                    ShowDataPatientWithRelatives();
                                } break;
                            case 2:
                                {
                                    Console.Clear();
                                    ShowDataOrderOfPatient();
                                } break;
                            case 3:
                                {
                                    Console.Clear();
                                    ShowSpecimentsOfPatient();
                                } break;
                            case 4:
                                {
                                    Console.Clear();
                                    ShowTestsOfSpeciment();
                                }
                                break;
                        }
                    } while (choice != 5);
                }
                session.Flush();
                session.Clear();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error (" + ex.GetType().Name + "): " + ex.Message);
            }
        }
    }
}
