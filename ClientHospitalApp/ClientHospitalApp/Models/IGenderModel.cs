using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public interface IGenderModel
    {
        List<GenderClient> ListGender { get; set; }
        void GetGender();
    }
}
