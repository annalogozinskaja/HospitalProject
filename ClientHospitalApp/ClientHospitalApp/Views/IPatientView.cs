using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface IPatientView
    {
        Patient PatientData {get; set;}
        event EventHandler AddPatientEvent;
        void ClearAllData();
    }
}
