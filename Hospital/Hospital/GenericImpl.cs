using NHibernate;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using ServiceStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class GenericImpl<T, ID> : IGenericDao<T, ID> //Реализуем интерфейс IGenericDao
    {
        public ISession session //Здесь метод на взятие сессии
        {
            get
            {
                return SessionFactory.GetSession(); //Используем нашу фабрику сессий.
            }
        }

        private Type _type = typeof(T); //Тип хибер класса, с которым работаем.
        private static List<Patient> patients = new List<Patient>();

        public T Get(ID id) //Метод взятия данных
        {           
            T result = (T)session.Get<T>(id);//Говорим что возвращаем тип T и загружаем его используя сессию через метод Load                                
            return result; //Возвращаем     
        }

        public T Save(T obj)
        {
              try
              {
                using (ITransaction tx = session.BeginTransaction())
                {
                    session.Save(obj);
                    tx.Commit();

                    //ICriteria criteria = session.CreateCriteria<Patient>();
                    ////criteria.CreateAlias("Gender", "gender", JoinType.LeftOuterJoin);
                    ////criteria.CreateAlias("RelativeInList", "relative", JoinType.LeftOuterJoin);
                    ////criteria.CreateAlias("OrderOfPatientInList", "order", JoinType.InnerJoin);
                    ////criteria.SetResultTransformer(new DistinctRootEntityResultTransformer());
                    //IList<Patient> list = criteria.List<Patient>();
                    //patients = list.ToList();

                    //foreach (Patient item in patients)
                    //{
                    //    Console.WriteLine(item.ToString());
                    //}
                }
                //session.Flush();
                //session.Clear();
                return obj;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
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
                Console.WriteLine(e.StackTrace.ToString());
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
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace.ToString());
            }
        }
    }

}
