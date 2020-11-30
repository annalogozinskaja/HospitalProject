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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
        public int selectedSSN { get; set; }

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
            this.gridView1.OptionsSelection.MultiSelect = false;
            this.gridView1.OptionsBehavior.Editable = true;  //когда false- не вызывается buttonclick на edit и delete          
            this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
            this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);

            this.gridView1.Columns[1].BestFit();
            this.gridView1.Columns[5].BestFit();

            GridColumn unbColumnEdit = gridView1.Columns.AddField("Edit");
            unbColumnEdit.VisibleIndex = gridView1.Columns.Count;
            unbColumnEdit.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;

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

            RepositoryItemButtonEdit delete = new RepositoryItemButtonEdit();
            delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            delete.Click += new System.EventHandler(delete_ButtonClick);
            delete.Buttons[0].Caption = "Delete";
            delete.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            delete.Buttons[0].ImageOptions.Image = ClientHospitalApp.Properties.Resources.cancel_16x16;
            this.gridView1.Columns["Delete"].ColumnEdit = delete;
        }

        private void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetSelectedIdPatient(1);
            PatientDetailData.buttonOK.Text = "Update";
        }

        void delete_ButtonClick(object sender, EventArgs args)
        {
            GetSelectedIdPatient(2);
        }

        void gridView1_DoubleClick(object sender, EventArgs args)
        {
            GetSelectedIdPatient(3);
        }

        private void GetSelectedIdPatient(int numberOfMethod)
        {
            int[] selectedRowHandles = this.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                selectedIdPatient = Convert.ToInt32(this.gridView1.GetRowCellDisplayText(selectedRowHandles[0], this.gridView1.Columns[0]));
                selectedSSN= Convert.ToInt32(this.gridView1.GetRowCellDisplayText(selectedRowHandles[0], this.gridView1.Columns[4]));

                if (numberOfMethod == 1)
                {
                    EditPatientEvent(this, EventArgs.Empty);
                }
                else if(numberOfMethod==2)
                {
                    DeletePatientEvent(this, EventArgs.Empty);
                }
                else if (numberOfMethod == 3)
                {
                    ShowPatientDataEvent(this, EventArgs.Empty);
                }
            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose the patient");
            }
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
