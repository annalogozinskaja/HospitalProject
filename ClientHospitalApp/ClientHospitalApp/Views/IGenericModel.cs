using System;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface IGenericModel <T>
    {
        List<T> ListToAddInDB { get; set; }
        List<T> ListToUpdateInDB { get; set; }
        List<T> ListToDeleteInDB { get; set; }
    }
}
