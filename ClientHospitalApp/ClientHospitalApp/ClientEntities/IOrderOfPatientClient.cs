using System;
using System.Collections.Generic;

namespace ClientHospitalApp.ClientEntities
{
    public interface IOrderOfPatientClient
    {
        int ID_Order { get; set; }
        DateTime DateOrder { get; set; }
        int ID_Doctor { get; set; }     
        int ID_OrderStatus { get; set; }
        int ID_Patient { get; set; }
        List<int> specimentsInOrderList { get; set; }
        string Symptoms { get; set; }
    }
}