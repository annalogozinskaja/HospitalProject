using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOLayer
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

            //additional load patient by relativ id's and then pack to transport objevt

            return list;
        }

        public List<Patient> GetListOfPatientsWithActiveStatus()
        {
            IQueryable<Patient> result = session.Query<Patient>().Where(s => s.Status==1);
            List<Patient> list = result.ToList();

            return list;
        }
    }
}
