using DAOLayer.HibernateEntities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOLayer;

namespace DAOLayer.DAO
{
    public class TestsInOrderDaoImpl: GenericDaoImpl<TestsInOrder, int>, ITestsInOrderDao
    {
        public ISession session;
        public TestsInOrderDaoImpl(ISession session) : base(session)
        {
            this.session = session;
        }

        public List<TestsInOrder> GetTestsOfSpeciment(int SpecimentId)
        {
            IQueryable<TestsOfSpeciment> result1 = session.Query<TestsOfSpeciment>().Where(test => test.ID_SpecimentOrder == SpecimentId);
            List<TestsOfSpeciment> listTS = result1.ToList();
            List<TestsInOrder> list = new List<TestsInOrder>();

            foreach (TestsOfSpeciment item in listTS)
            {
               IQueryable<TestsInOrder> result2 = session.Query<TestsInOrder>().Where(test => test.ID_TestOrder == item.ID_TestOrder);
               list.Add((TestsInOrder)result2.FirstOrDefault());
            }

            return list;
        }

        public List<TestsInOrder> GetListOfTestsWithActiveStatus()
        {
            IQueryable<TestsInOrder> result = session.Query<TestsInOrder>().Where(s => s.Status == 1);
            List<TestsInOrder> list = result.ToList();

            return list;
        }
    }
}
