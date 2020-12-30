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
    public partial class TestDetail : UserControl, ITestView
    {
        TestsInOrder test;
        
        public TestsInOrder Test
        {
            get { return getTest(); }
            set { setTest(value); }
        }

        public Test DataTestName
        {
            set { testNameLookUpEdit.TestName = value; }
            get { return testNameLookUpEdit.TestName; }
        }
        public List<Test> DataSourceTestName
        {
            set { testNameLookUpEdit.TestNameDataSource = value; }
            get { return (List<Test>)testNameLookUpEdit.TestNameDataSource; }
        }

        public TestStatus DataTestStatus
        {
            set { testStatusLookUpEdit.TestStatus = value; }
            get { return testStatusLookUpEdit.TestStatus; }
        }
        public List<TestStatus> DataSourceTestStatus
        {
            set { testStatusLookUpEdit.TestNameDataSource = value; }
            get { return (List<TestStatus>)testStatusLookUpEdit.TestNameDataSource; }
        }
        public event EventHandler AddOrUpdateTestEvent;
        public TestDetail()
        {
            InitializeComponent();
            test = new TestsInOrder();
        }

        void setTest(TestsInOrder test)
        {
            if (test != null)
            {
                textEditIDTest.Text = Convert.ToString(test.ID_TestOrder);

                if (test.Test != null)
                {
                    DataTestName = test.Test;
                }
                dateEditDateStart.Text = Convert.ToString(test.DateStart);
                dateEditDateEnd.Text = Convert.ToString(test.DateEnd);
                textEditResult.Text = test.Result;

                if (test.TestStatus != null)
                {
                    DataTestStatus = test.TestStatus;
                }
            }
        }

        TestsInOrder getTest()
        {
            if (textEditIDTest.Text != "")
            {
                test.ID_TestOrder = Convert.ToInt32(textEditIDTest.Text);
            }
            test.Test = DataTestName;
            DateTime dateStart = new DateTime();
            DateTime.TryParse(dateEditDateStart.Text, out dateStart);
            test.DateStart = dateStart;
            DateTime dateEnd = new DateTime();
            DateTime.TryParse(dateEditDateEnd.Text, out dateEnd);
            test.DateEnd = dateEnd;
            test.Result = textEditResult.Text;
            test.TestStatus = DataTestStatus;

            return test;
        }


        public void ClearAllData()
        {
            test = new TestsInOrder();

            textEditIDTest.Text = "";
            testNameLookUpEdit.lookUpEditTestName.EditValue = 0;
            dateEditDateStart.Text = "";
            dateEditDateEnd.Text = "";
            textEditResult.Text = "";
            testStatusLookUpEdit.lookUpEditTestStatus.EditValue = 0;

            buttonOK.Text = "Add";
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            AddOrUpdateTestEvent(this, EventArgs.Empty);
            buttonOK.Text = "Add";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

    }
}
