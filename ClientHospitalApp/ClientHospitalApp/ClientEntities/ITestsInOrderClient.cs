using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;

namespace ClientHospitalApp.ClientEntities
{
    public interface ITestsInOrderClient
    {
        DateTime DateStart { get; set; }
        int ID_TestOrder { get; set; }
        string Result { get; set; }
        List<int> specimentsInOrderList { get; set; }
        Test Test { get; set; }
        TestStatus TestStatus { get; set; }
    }
}