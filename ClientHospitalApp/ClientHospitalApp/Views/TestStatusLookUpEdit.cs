using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp.Views
{
    public partial class TestStatusLookUpEdit : UserControl, ITestStatusView
    {
        TestStatus testStatus;
        public TestStatus TestStatus
        {
            get { return getTestStatus(); }
            set { setTestStatus(value); }
        }

        public List<TestStatus> TestNameDataSource
        {
            set { lookUpEditTestStatus.Properties.DataSource = value; }
            get { return (List<TestStatus>)lookUpEditTestStatus.Properties.DataSource; }
        }
        public TestStatusLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditTestStatus();
        }

        void setTestStatus(TestStatus testStatus)
        {
            if (TestStatus != null)
            {
                lookUpEditTestStatus.EditValue = testStatus.ID_TestStatus;
            }
        }

        TestStatus getTestStatus()
        {
            testStatus = (TestStatus)lookUpEditTestStatus.GetSelectedDataRow();
            return TestStatus;
        }

        private void FillLookUpEditTestStatus()
        {
            lookUpEditTestStatus.Properties.DisplayMember = "TestStatusName";
            lookUpEditTestStatus.Properties.ValueMember = "ID_TestStatus";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TestStatusName", "TestStatus", 100);
            lookUpEditTestStatus.Properties.Columns.Add(col);
            lookUpEditTestStatus.Properties.NullText = "--choose type--";
        }
    }
}
