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

        TestsInOrder Test { get; set; }
        List<TestsInOrder> ListTests { get; set; }
        BindingList<TestsInOrder> TestList { get; set; }
        List<TestsInOrder> ListToAdd { get; set; }
        List<TestsInOrder> ListToUpdate { get; set; }
        List<TestsInOrder> ListToDelete { get; set; }
    }
}
