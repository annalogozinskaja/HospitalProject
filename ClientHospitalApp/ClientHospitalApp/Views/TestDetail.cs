using ClientHospitalApp.ClientEntities;
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
        TestsInOrderClient test;
        
        public TestsInOrderClient Test
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
        public List<int> DataSpeciments
        {
            set { specimentsCheckedComboBoxEdit.Speciments = value; }
            get { return specimentsCheckedComboBoxEdit.Speciments; }
        }
        public List<SpecimentsInOrder> DataSourceSpeciment
        {
            set { specimentsCheckedComboBoxEdit.SpecimentDataSource = value; }
            get { return (List<SpecimentsInOrder>)specimentsCheckedComboBoxEdit.SpecimentDataSource; }
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
            test = new TestsInOrderClient();
        }

        void setTest(TestsInOrderClient test)
        {
            if (test != null)
            {
                textEditIDTest.Text = Convert.ToString(test.ID_TestOrder);

                if (test.Test != null)
                {
                    DataTestName = test.Test;
                }
                dateEditDateStart.Text = Convert.ToString(test.DateStart);
                textEditResult.Text = test.Result;
                if (test.specimentsInOrderList != null)
                {
                    DataSpeciments = test.specimentsInOrderList;
                }

                if (test.TestStatus != null)
                {
                    DataTestStatus = test.TestStatus;
                }
            }
        }

        TestsInOrderClient getTest()
        {
            if (textEditIDTest.Text != "")
            {
                test.ID_TestOrder = Convert.ToInt32(textEditIDTest.Text);
            }
            test.Test = DataTestName;
            DateTime dateStart = new DateTime();
            DateTime.TryParse(dateEditDateStart.Text, out dateStart);
            test.DateStart = dateStart;
            test.Result = textEditResult.Text;
            test.specimentsInOrderList= DataSpeciments;
            test.TestStatus = DataTestStatus;

            return test;
        }


        public void ClearAllData()
        {
            test = new TestsInOrderClient();

            textEditIDTest.Text = "";
            testNameLookUpEdit.lookUpEditTestName.EditValue = 0;
            dateEditDateStart.Text = "";
            textEditResult.Text = "";
            testStatusLookUpEdit.lookUpEditTestStatus.EditValue = 0;
            specimentsCheckedComboBoxEdit.checkedComboBoxEditSpeciment.EditValue = 0;

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
