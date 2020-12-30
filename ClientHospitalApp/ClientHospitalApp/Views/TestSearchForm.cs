using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
        public List<TestStatus> DataSourceTestStatus
        {
            set { testDetail.DataSourceTestStatus = value; }
            get { return (List<TestStatus>)testDetail.DataSourceTestStatus; }
        }

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

        private void CreateGridControl()
        {
            this.gridView1.Columns[0].Caption = "ID";
            this.gridView1.Columns[1].Caption = "Type of Test";
            this.gridView1.Columns[4].Caption = "Status";

            this.gridView1.Columns[1].FieldName = "Test.TestName";
            this.gridView1.Columns[4].FieldName = "TestStatus.TestStatusName";
            this.gridView1.Columns[6].Visible = false;

            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.ExpandAllGroups();
            this.gridView1.OptionsSelection.MultiSelect = false;
            this.gridView1.OptionsBehavior.Editable = true;  //когда false- не вызывается buttonclick на edit и delete          
            this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[5].OptionsColumn.AllowEdit = false;
            //this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);

            this.gridView1.Columns[0].Width = 5;
            this.gridView1.Columns[1].Width = 120;
            this.gridView1.Columns[2].Width = 100;
            this.gridView1.Columns[3].Width = 100;
            this.gridView1.Columns[4].Width = 105;
            //this.gridView1.Columns[1].BestFit();

            GridColumn unbColumnEdit = gridView1.Columns.AddField("Edit");
            unbColumnEdit.VisibleIndex = gridView1.Columns.Count;
            unbColumnEdit.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            unbColumnEdit.Width = 45;

            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            edit.ButtonClick += edit_ButtonClick;
            edit.Buttons[0].Caption = "Edit";
            edit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            edit.Buttons[0].ImageOptions.Image = ClientHospitalApp.Properties.Resources.editcontact_16x16;
            this.gridView1.Columns["Edit"].ColumnEdit = edit;

            GridColumn unbColumnDel = gridView1.Columns.AddField("Delete");
            unbColumnDel.VisibleIndex = gridView1.Columns.Count;
            unbColumnDel.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            unbColumnDel.Width = 45;

            RepositoryItemButtonEdit delete = new RepositoryItemButtonEdit();
            delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            delete.Click += new System.EventHandler(delete_ButtonClick);
            delete.Buttons[0].Caption = "Delete";
            delete.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            delete.Buttons[0].ImageOptions.Image = ClientHospitalApp.Properties.Resources.cancel_16x16;
            this.gridView1.Columns["Delete"].ColumnEdit = delete;
        }
        private void SaveDataEventHandler(object sender, EventArgs args)
        {
            SaveDataToModelEvent(this, EventArgs.Empty);
        }

        private void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetSelectedTest(1);
            TestDetailData.buttonOK.Text = "Update";
        }

        void delete_ButtonClick(object sender, EventArgs args)
        {
            GetSelectedTest(2);
        }

        private void GetSelectedTest(int numberOfMethod)
        {
            int[] selectedRowHandles = this.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                TestsInOrder test = gridView1.GetRow(selectedRowHandles[0]) as TestsInOrder;
                if (test == null)
                {
                    MessageBox.Show("Selected test is null");
                }
                else
                {
                    selectedTest = test;
                }

                if (numberOfMethod == 1)
                {
                    EditTestEvent(this, EventArgs.Empty);
                }
                else 
                {
                    DeleteTestEvent(this, EventArgs.Empty);
                }
            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose test");
            }
        }

        private void TestSearchForm_Load(object sender, EventArgs e)
        {
            LoadDataDataEvent(this, EventArgs.Empty);
            this.mainForm = ((TestSearchForm)(this)).MdiParent as MainForm;
            this.mainForm.SaveDataEvent += SaveDataEventHandler;
            CreateGridControl();
        }
    }
}
