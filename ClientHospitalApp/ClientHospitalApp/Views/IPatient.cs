using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface IPatient
    {
        int ID_PatientText { get; set; }
        string LastnameText { get; set; }
        string FirstnameText { get; set; }
        DateTime DOBText { get; set; }
        int SSNText { get; set; }
        int ID_GenderText { get; set; }
    }
}
