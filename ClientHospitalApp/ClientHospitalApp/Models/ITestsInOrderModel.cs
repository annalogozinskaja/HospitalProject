using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public interface ITestsInOrderModel
    {
        void GetAllTests();
        void AddTest();
        void UpdateTest();
        void DeleteTest();
        void SaveDataOfTest();

        TestsInOrderClient Test { get; set; }
        List<TestsInOrderClient> ListTests { get; set; }
        BindingList<TestsInOrderClient> TestList { get; set; }
        List<TestsInOrderClient> ListToAdd { get; set; }
        List<TestsInOrderClient> ListToUpdate { get; set; }
        List<TestsInOrderClient> ListToDelete { get; set; }
    }
}
