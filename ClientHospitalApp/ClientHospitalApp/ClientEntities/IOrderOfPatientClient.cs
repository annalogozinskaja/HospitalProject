using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;

namespace ClientHospitalApp.ClientEntities
{
    public interface IOrderOfPatientClient
    {
        int ID_Order { get; set; }
        DateTime DateOrder { get; set; }
        PatientClient Patient { get; set; }
        Doctor Doctor { get; set; }
        OrderStatus OrderStatus { get; set; }
        string Symptoms { get; set; }
    }
}