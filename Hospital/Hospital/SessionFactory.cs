using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using System.Text;
using NHibernate;
using Microsoft.IdentityModel.Tokens;

namespace Hospital
{
    public class SessionFactory
    {
        private static ISessionFactory sessionFactory; //Объект фабрики сессий, реализованный в хибере
        private static ISession session;
        public static void Init() //Инициализация фабрики сессий
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            sessionFactory = cfg.BuildSessionFactory();
            Console.WriteLine("NHibernate Configured!");
            Console.ReadKey();

            session = sessionFactory.OpenSession();
        }

        public static ISession GetSession() //Метод возвращающий нам сессию.
        {
            return session; 
        }
    }
}
