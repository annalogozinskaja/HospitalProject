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
    public partial class TestNameLookUpEdit : UserControl,ITestNameView
    {
        Test testName;
        public Test TestName
        {
            get { return getTestName(); }
            set { setTestName(value); }
        }

        public List<Test> TestNameDataSource
        {
            set { lookUpEditTestName.Properties.DataSource = value; }
            get { return (List<Test>)lookUpEditTestName.Properties.DataSource; }
        }
        public TestNameLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditTestName();
        }

        void setTestName(Test testName)
        {
            if (testName != null)
            {
                lookUpEditTestName.EditValue = testName.ID_Test;
            }
        }

        Test getTestName()
        {
            testName = (Test)lookUpEditTestName.GetSelectedDataRow();
            return testName;
        }

        private void FillLookUpEditTestName()
        {
            lookUpEditTestName.Properties.DisplayMember = "TestName";
            lookUpEditTestName.Properties.ValueMember = "ID_Test";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TestName", "Test", 100);
            lookUpEditTestName.Properties.Columns.Add(col);
            lookUpEditTestName.Properties.NullText = "--choose type--";
        }

    }
}
