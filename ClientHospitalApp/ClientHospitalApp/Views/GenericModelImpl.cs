using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public class GenericModelImpl<T>: IGenericModel<T>
    {
        List<T> listToAddInDB;
        List<T> listToUpdateInDB;
        List<T> listToDeleteInDB;

        public List<T> ListToAddInDB 
        {
            get { return listToAddInDB; }
            set { listToAddInDB = value; }
        }
        public List<T> ListToUpdateInDB
        {
            get { return listToUpdateInDB; }
            set { listToUpdateInDB = value; }
        }
        public List<T> ListToDeleteInDB
        {
            get { return listToDeleteInDB; }
            set { listToDeleteInDB = value; }
        }
        public GenericModelImpl()
        {
            listToAddInDB = new List<T>();
            listToUpdateInDB = new List<T>();
            listToDeleteInDB = new List<T>();
        }
    }
}
