using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraGrid.Views.Grid;

namespace ClientHospitalApp.Views
{
    //[PatientValidation]
    public partial class PatientSearchForm : Form,IPatientSearchForm
    {
    //    public PatientDetail patientDetailData
    //    {
    //        set { gridControl1.DataSource = value; }
    //        get { return patientDetailData; }
    //    }
        public List<Patient> DataSourcePatients
        {
            set { gridControl1.DataSource = value;
                gridControl1.RefreshDataSource();
            }
            get { return (List<Patient>)gridControl1.DataSource; }
        }
        public List<Gender> DataSourceGender
        {
            set { patientDetailData.GenderDataSource = value; }
            get { return (List<Gender>)patientDetailData.GenderDataSource; }
        }

        public int selectedIdPatient { get; set; }

        public event EventHandler LoadDataDataEvent;
        //public event EventHandler AddPatientEvent;
        public event EventHandler EditPatientEvent;
        public event EventHandler DeletePatientEvent;
        public event EventHandler ShowPatientDataEvent;
        public event EventHandler ShowOrdersEvent;
        //Patient dataPatient;
        public PatientDetail PatientDetailData
        {
            set { patientDetailData = value; }
            get { return patientDetailData; }
        }
        public PatientSearchForm()
        {
            InitializeComponent();
            //this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);
            //dataPatient = new Patient();
        }

        private void CreateGridControl()
        {
            this.gridView1.Columns[1].Caption = "Lastname";
            this.gridView1.Columns[2].Caption = "Firstname";
            this.gridView1.Columns[3].Caption = "Data of birth";
            this.gridView1.Columns[4].Caption = "SSN";

            this.gridView1.Columns[0].Visible = false;
            this.gridView1.Columns[5].Visible = false;
            this.gridView1.Columns[6].Visible = false;

            this.gridView1.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.ExpandAllGroups();
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsSelection.MultiSelect = false;
            //this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);

            this.gridView1.Columns[1].BestFit();
            this.gridView1.Columns[5].BestFit();
          
        }

        private void PatientSearchForm_Load(object sender, EventArgs e)
        {
            LoadDataDataEvent(this, EventArgs.Empty);
            CreateGridControl();
        }

        //void setPatientData()
        //{
        //    dataPatient = patientDetail1.PatientData;
        //    //dataPatient = patientData;
        //}

        //Patient getPatientData()
        //{
        //    patientDetail1.PatientData = dataPatient;
        //    return dataPatient;
        //}

    }
}
