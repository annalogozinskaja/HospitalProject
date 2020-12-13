using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp
{
    public class PatientDataInfoEventArgs: EventArgs
    {
        public IPatientDataInfoForm patientDataInfoForm { get; set; }
        public PatientDataInfoEventArgs(IPatientDataInfoForm patientDataInfoForm)
        {
            this.patientDataInfoForm = patientDataInfoForm;
        }
    }
}
