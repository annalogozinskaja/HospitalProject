using NHibernate;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOLayer
{
    public class GenericDaoImpl<T, ID> : IGenericDao<T, ID> //Реализуем интерфейс IGenericDao
    {
        public ISession session;
        public GenericDaoImpl(ISession session)
        {
            this.session = session;
        }

        public T Get(ID id) 
        {           
            T result = (T)session.Get<T>(id);                                
            return result;  
        }

        public List<T> GetAll() 
        {
            ICriteria criteria = session.CreateCriteria(typeof(T));
            List<T> list = criteria.List<T>().ToList();

            return list;
        }

        public T Save(T obj)
        {
              try
              {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.Save(obj);
                    tx.Commit();
                }
               
                return obj;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public T SaveOrUpdate(T obj)
        {      
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.SaveOrUpdate(obj);
                    tx.Commit();
                }
                return obj;
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.StackTrace.ToString());
                throw e;
            }
        }

        public void Delete(T obj)
        {          
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.Delete(obj);
                    tx.Commit();
                }
            }
            catch (Exception e) {}
        }
    }

}
