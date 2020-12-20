using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public interface ISpecimentNameModel
    {
        List<Speciment> ListSpecimentNames { get; set; }
        void GetSpecimentNames();
    }
}
