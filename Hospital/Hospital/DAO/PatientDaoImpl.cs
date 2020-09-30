using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital
{
    public class PatientDaoImpl : GenericDaoImpl<Patient, int>, IPatientDao
    {
        public ISession session;
        public PatientDaoImpl(ISession session) : base(session)
        {
            this.session = session;
        }

        public List<Patient> GetByLastname(String lstnm)
        {
            IQueryable <Patient> result = session.Query<Patient>().Where(p => p.Lastname == lstnm);
            List<Patient> list = result.ToList();

            return list;
        }

    }
}
