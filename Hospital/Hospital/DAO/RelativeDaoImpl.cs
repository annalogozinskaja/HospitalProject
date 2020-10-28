using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOLayer.DAO
{
    public class RelativeDaoImpl:GenericDaoImpl<Relative, int>, IRelativeDao
    {
        public ISession session;
        public RelativeDaoImpl(ISession session) : base(session)
        {
            this.session = session;
        }

        public List<Relative> GetListRelativesOfPatient(int PatientId)
        {
            IQueryable<Relative> result = session.Query<Relative>().Where(rel => rel.ID_Patient == PatientId);
            List<Relative> list = result.ToList();

            return list;
        }
    }
}
