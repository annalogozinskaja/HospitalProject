using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public interface ITestNameModel
    {
        List<Test> ListTestNames { get; set; }
        void GetTestNames();
    }
}
