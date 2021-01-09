using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClientHospitalApp.ClientEntities
{
    public interface ISpecimentsInOrderClient
    {
        DateTime DateOfTaking { get; set; }
        int ID_SpecimentOrder { get; set; }
        string Nurse { get; set; }
        OrderOfPatient Order { get; set; }
        Speciment Speciment { get; set; }
        SpecimentStatus SpecimentStatus { get; set; }
        List<int> testsInOrderList { get; set; }
    }
}