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
    public partial class TestSearchForm : Form, ITestSearchForm
    {
        public BindingList<TestsInOrder> DataSourceTests
        {
            set
            {
                gridControlTests.DataSource = value;
                gridControlTests.RefreshDataSource();
            }
            get { return (BindingList<TestsInOrder>)gridControlTests.DataSource; }
        }
        public List<Test> DataSourceTestName
        {
            set { testDetail.DataSourceTestName = value; }
            get { return (List<Test>)testDetail.DataSourceTestName; }
        }
        //public List<TestStatus> DataSourceTestStatus
        //{
        //    set { testDetail.DataSourceTestStatus = value; }
        //    get { return (List<TestStatus>)testDetail.DataSourceTestStatus; }
        //}
       
        MainForm mainForm;
        public TestsInOrder selectedTest { get; set; }

        public event EventHandler LoadDataDataEvent;
        public event EventHandler EditTestEvent;
        public event EventHandler DeleteTestEvent;
        public event EventHandler SaveDataToModelEvent;
       
        public String DataSourceGridViewTestName
        {
            set { this.gridView1.Columns[2].Caption = value; }
            get { return (String)this.gridView1.Columns[2].Caption; }
        }


        public TestDetail TestDetailData
        {
            set { testDetail = value; }
            get { return testDetail; }
        }
        public TestSearchForm()
        {
            InitializeComponent();
        }
    }
}
