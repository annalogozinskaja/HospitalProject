using System;
using System.Collections.Generic;
using System.Text;

namespace DAOLayer
{
    public interface IGenericDao <T,ID>
    {
        T Get(ID id);
        T Save(T obj);
        T SaveOrUpdate(T obj);
        void Delete(T obj);
    }
}
