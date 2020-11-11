using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface IPatient
    {
        /*   string ID_PatientText { get; set; }
           string LastnameText { get; set; }
           string FirstnameText { get; set; }
           string DOBText { get; set; }
           string SSNText { get; set; }
           string ID_GenderText { get; set; }*/
        Patient PatientData {get; set;}
    }
}
