using System;
using System.Collections.Generic;
using NHibernate.Cfg;
using System.Text;
using NHibernate;
using Microsoft.IdentityModel.Tokens;

namespace DAOLayer
{
    public class SessionFactory
    {
        private ISessionFactory sessionFactory; //Объект фабрики сессий, реализованный в хибере
        private ISession session;
        public void Init() //Инициализация фабрики сессий
        {
            Configuration cfg = new Configuration();
            cfg.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
            cfg.SetProperty("dialect", "NHibernate.Dialect.PostgreSQLDialect");
            cfg.SetProperty("query.substitutions", "hqlFunction=SQLFUNC");
            cfg.SetProperty("connection.driver_class", "NHibernate.Driver.NpgsqlDriver");
            cfg.SetProperty("connection.connection_string", "Server=localhost;Port=5432;User Id=postgres;Password=postgres;Database=Hospital");
            cfg.SetProperty("show_sql", "true");
            //cfg.SetProperty("proxyfactory.factory_class", "NHibernate.ByteCode.LinFu.ProxyFactoryFactory, NHibernate.ByteCode.LinFu");
            cfg.AddAssembly("DAOLayer");
            //cfg.Configure();
            sessionFactory = cfg.BuildSessionFactory();
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
