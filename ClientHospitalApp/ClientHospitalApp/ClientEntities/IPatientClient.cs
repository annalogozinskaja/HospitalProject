﻿using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;

namespace ClientHospitalApp.ClientEntities
{
    public interface IPatientClient
    {
        DateTime DOB { get; set; }
        string Firstname { get; set; }
        Gender Gender { get; set; }
        int ID_Patient { get; set; }
        string Lastname { get; set; }
        List<Relative> RelativeList { get; set; }
        int SSN { get; set; }
    }
}