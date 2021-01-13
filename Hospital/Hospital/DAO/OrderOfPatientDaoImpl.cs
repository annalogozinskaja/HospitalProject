using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAOLayer
{
    public class OrderOfPatientDaoImpl: GenericDaoImpl<OrderOfPatient, int>, IOrderOfPatientDao
    {
        public ISession session;
        public OrderOfPatientDaoImpl(ISession session) : base(session)
        {
            this.session = session;
        }

        public List<OrderOfPatient> GetOrdersByDate(DateTime dateOrder)
        {
            IQueryable<OrderOfPatient> result = session.Query<OrderOfPatient>().Where(ord => ord.DateOrder.CompareTo(dateOrder)==0);
            List<OrderOfPatient> list = result.ToList();

            return list;
        }

        public List<OrderOfPatient> GetOrdersOfPatient(int PatientId)
        {
            IQueryable<OrderOfPatient> result = session.Query<OrderOfPatient>().Where(ord => ord.Patient.ID_Patient== PatientId);
            List<OrderOfPatient> list = result.ToList();

            return list;
        }

        public List<OrderOfPatient> GetListOfOrdersWithActiveStatus()
        {
            IQueryable<OrderOfPatient> result = session.Query<OrderOfPatient>().Where(s => s.Status == 1);
            List<OrderOfPatient> list = result.ToList();

            return list;
        }

    }
}
