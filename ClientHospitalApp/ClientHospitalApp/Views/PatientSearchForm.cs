﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace ClientHospitalApp.Views
{
    //[PatientValidation]
    public partial class PatientSearchForm : Form,IPatientSearchForm
    {
        public BindingList<PatientClient> DataSourcePatients
        {
            set { gridControl1.DataSource = value;
                gridControl1.RefreshDataSource();
            }
            get { return (BindingList<PatientClient>)gridControl1.DataSource; }
        }
        public List<Gender> DataSourceGender
        {
            set { patientDetailData.DataSourceGender = value; }
            get { return (List<Gender>)patientDetailData.DataSourceGender; }
        }
        MainForm mainForm;
        public PatientClient selectedPatient { get; set; }

        public event EventHandler LoadDataDataEvent;
        public event EventHandler EditPatientEvent;
        public event EventHandler DeletePatientEvent;
        public event EventHandler SaveDataToModelEvent;
        public delegate void PatientSearchFormHandler(object sender, PatientDataInfoEventArgs e);
        public event PatientSearchFormHandler ShowPatientDataEvent;
        public event EventHandler ShowOrdersEvent;
       
        public PatientDetail PatientDetailData
        {
            set { patientDetailData = value; }
            get { return patientDetailData; }
        }
        public PatientSearchForm()
        {
            InitializeComponent();
        }

        private void CreateGridControl()
        {
            this.gridView1.Columns[1].Caption = "Lastname";
            this.gridView1.Columns[2].Caption = "Firstname";
            this.gridView1.Columns[3].Caption = "Data of birth";
            this.gridView1.Columns[4].Caption = "SSN";

            this.gridView1.Columns[4].DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridView1.Columns[4].DisplayFormat.FormatString = "{0:d9}";

            this.gridView1.Columns[0].Visible = false;
            this.gridView1.Columns[5].Visible = false;

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
        private void SaveDataEventHandler(object sender, EventArgs args)
        {
            SaveDataToModelEvent(this, EventArgs.Empty);
        }

        private void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetSelectedPatient(1);
            PatientDetailData.buttonOK.Text = "Update";
        }

        void delete_ButtonClick(object sender, EventArgs args)
        {
            GetSelectedPatient(2);
        }

        void gridView1_DoubleClick(object sender, EventArgs args)
        {
            GetSelectedPatient(3);
        }

        private void GetSelectedPatient(int numberOfMethod)
        {
            int[] selectedRowHandles = this.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                PatientClient patient = gridView1.GetRow(selectedRowHandles[0]) as PatientClient;
                if (patient == null)
                {
                    MessageBox.Show("Selected patient is null");
                }
                else
                {
                    selectedPatient = patient;
                }

                if (numberOfMethod == 1)
                {
                    EditPatientEvent(this, EventArgs.Empty);
                }
                else if (numberOfMethod == 2)
                {
                    DeletePatientEvent(this, EventArgs.Empty);
                }
                else if (numberOfMethod == 3)
                {
                    PatientDataInfoForm pdiForm = new PatientDataInfoForm();
                    ShowPatientDataEvent(this, new PatientDataInfoEventArgs(pdiForm));
                    DialogResult res = pdiForm.ShowDialog();
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
            this.mainForm = ((PatientSearchForm)(this)).MdiParent as MainForm;
            this.mainForm.SaveDataEvent += SaveDataEventHandler;
            CreateGridControl();
        }


    }
}
