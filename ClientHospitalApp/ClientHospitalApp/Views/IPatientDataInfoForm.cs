﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface IPatientDataInfoForm
    {
        PatientSearchExtendForm patientSearchExtendForm { get; set; }
        void ApplyOptionsForGridViewRelatives();
    }
}
