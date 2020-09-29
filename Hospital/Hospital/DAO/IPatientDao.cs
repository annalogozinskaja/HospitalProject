using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
   public interface IPatientDao: IGenericDao<Patient,int> { }
}
