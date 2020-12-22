using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLayer.DAO
{
    public class SpecimentsInOrderDaoImpl : GenericDaoImpl<SpecimentsInOrder, int>, ISpecimentsInOrderDao
    {
        public ISession session;
        public SpecimentsInOrderDaoImpl(ISession session) : base(session)
        {
            this.session = session;
        }

        public List<SpecimentsInOrder> GetSpecimentsOfOrder(int OrderId)
        {
            IQueryable<SpecimentsInOrder> result = session.Query<SpecimentsInOrder>().Where(spec => spec.Order.ID_Order == OrderId);
            List<SpecimentsInOrder> list = result.ToList();

            return list;
        }

        public List<SpecimentsInOrder> GetListOfSpecimentsWithActiveStatus()
        {
            IQueryable<SpecimentsInOrder> result = session.Query<SpecimentsInOrder>().Where(s => s.Status == 1);
            List<SpecimentsInOrder> list = result.ToList();

            return list;
        }
    }
}
