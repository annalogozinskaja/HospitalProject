﻿using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hospital.DAO
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
    }
}
