using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface ITestSearchForm
    {
        BindingList<TestsInOrderClient> DataSourceTests { get; set; }
        List<Test> DataSourceTestName { get; set; }
        List<SpecimentsInOrder> DataSourceSpeciment { get; set; }
        List<TestStatus> DataSourceTestStatus { get; set; }
        TestsInOrderClient selectedTest { get; set; }
        TestDetail TestDetailData { get; set; }

        event EventHandler DeleteTestEvent;
        event EventHandler EditTestEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler SaveDataToModelEvent;
    }
}
