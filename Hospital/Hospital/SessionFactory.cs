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
        private ISessionFactory sessionFactory; //Объект фабрики сессий, реализованный в хибере
        private ISession session;
        public void Init() //Инициализация фабрики сессий
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            sessionFactory = cfg.BuildSessionFactory();
            Console.WriteLine("NHibernate Configured!");
            Console.ReadKey();         
        }

        public void OpenSession()
        {
            session = sessionFactory.OpenSession();
        }
        public ISession GetSession()
        {
            return session; 
        }
        public void CloseSession()
        {
            session.Flush();
            session.Clear();
        }
    }
}
