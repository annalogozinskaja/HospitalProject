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
    public partial class SpecimentSearchForm : Form, ISpecimentSearchForm
    {
        public BindingList<SpecimentsInOrder> DataSourceSpeciments
        {
            set
            {
                gridControlSpeciments.DataSource = value;
                gridControlSpeciments.RefreshDataSource();
            }
            get { return (BindingList<SpecimentsInOrder>)gridControlSpeciments.DataSource; }
        }
        public List<Speciment> DataSourceSpecimentName
        {
            set { specimentDetail.DataSourceSpecimentName = value; }
            get { return (List<Speciment>)specimentDetail.DataSourceSpecimentName; }
        }
        public List<SpecimentStatus> DataSourceSpecimentStatus
        {
            set { specimentDetail.DataSourceSpecimentStatus = value; }
            get { return (List<SpecimentStatus>)specimentDetail.DataSourceSpecimentStatus; }
        }
        public List<OrderOfPatient> DataSourceOrder
        {
            set { specimentDetail.DataSourceOrder = value; }
            get { return (List<OrderOfPatient>)specimentDetail.DataSourceOrder; }
        }
        MainForm mainForm;
        public SpecimentsInOrder selectedSpeciment { get; set; }

        public event EventHandler LoadDataDataEvent;
        public event EventHandler EditSpecimentEvent;
        public event EventHandler DeleteSpecimentEvent;
        public event EventHandler SaveDataToModelEvent;
        //как вариант !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public String DataSourceGridViewSpecimentName
        {
            set { this.gridView1.Columns[2].Caption = value; }
            get { return (String)this.gridView1.Columns[2].Caption; }
        }


        public SpecimentDetail SpecimentDetailData
        {
            set { specimentDetail = value; }
            get { return specimentDetail; }
        }
        public SpecimentSearchForm()
        {
            InitializeComponent();
        }

        private void CreateGridControl()
        {
            this.gridView1.Columns[0].Caption = "ID";
            this.gridView1.Columns[1].Caption = "Type of Speciment";
            this.gridView1.Columns[2].Caption = "Status";
            this.gridView1.Columns[4].Caption = "Order ID";

            this.gridView1.Columns[1].FieldName="Speciment.SpecimentName";
            this.gridView1.Columns[2].FieldName = "SpecimentStatus.SpecimentStatusName";
            this.gridView1.Columns[4].FieldName = "Order.ID_Order";
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
            this.gridView1.Columns[1].Width=135;
            this.gridView1.Columns[2].Width = 120;
            this.gridView1.Columns[3].Width = 100;
            this.gridView1.Columns[4].Width = 70;
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
            GetSelectedSpeciment(1);
            SpecimentDetailData.buttonOK.Text = "Update";
        }

        void delete_ButtonClick(object sender, EventArgs args)
        {
            GetSelectedSpeciment(2);
        }

        //void gridView1_DoubleClick(object sender, EventArgs args)
        //{
        //    GetSelectedSpeciment(3);
        //}

        private void GetSelectedSpeciment(int numberOfMethod)
        {
            int[] selectedRowHandles = this.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                SpecimentsInOrder speciment = gridView1.GetRow(selectedRowHandles[0]) as SpecimentsInOrder;
                if (speciment == null)
                {
                    MessageBox.Show("Selected speciment is null");
                }
                else
                {
                    selectedSpeciment = speciment;
                }

                if (numberOfMethod == 1)
                {
                    EditSpecimentEvent(this, EventArgs.Empty);
                }
                else if (numberOfMethod == 2)
                {
                    DeleteSpecimentEvent(this, EventArgs.Empty);
                }
                else if (numberOfMethod == 3)
                {
                    //PatientDataInfoForm pdiForm = new PatientDataInfoForm();
                    //ShowPatientDataEvent(this, new PatientDataInfoEventArgs(pdiForm));
                    //DialogResult res = pdiForm.ShowDialog();
                }
            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose speciment");
            }
        }

        private void SpecimentSearchForm_Load(object sender, EventArgs e)
        {
            LoadDataDataEvent(this, EventArgs.Empty);
            this.mainForm = ((SpecimentSearchForm)(this)).MdiParent as MainForm;
            this.mainForm.SaveDataEvent += SaveDataEventHandler;
            CreateGridControl();
        }


    }
}
