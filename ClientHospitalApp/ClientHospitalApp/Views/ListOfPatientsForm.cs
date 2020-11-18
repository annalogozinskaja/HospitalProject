using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.Views;
using ClientHospitalApp.Presenters;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Windows.Controls.Ribbon;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing.Printing;
using System.ComponentModel.DataAnnotations;
using ClientHospitalApp.Reports;

namespace ClientHospitalApp
{
    public partial class ListOfPatientsForm : Form, IListOfPatientsForm
    {
        public GridControl gridControl1 { get; set; }
        public GridView gridView1 { get; set; }

        public event EventHandler LoadDataDataEvent;
        public event EventHandler AddPatientEvent;
        public event EventHandler EditPatientEvent;
        public event EventHandler DeletePatientEvent;
        public event EventHandler ShowPatientDataEvent;
        public event EventHandler ShowOrdersEvent;

        public ListOfPatientsForm()
        {
            InitializeComponent();          
        }

        public List<Patient> DataSource
        {
            set { gridControl1.DataSource = value; }
            get { return (List<Patient>)gridControl1.DataSource; }
        }

        public int selectedIdPatient { get; set; }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.gridControl1 = new GridControl();
            this.gridControl1.Parent = this;
           
            LoadDataDataEvent(this, EventArgs.Empty);
            CreateGridControl();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            AddPatientEvent(this, EventArgs.Empty);
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditPatientEvent(this, EventArgs.Empty);
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeletePatientEvent(this, EventArgs.Empty);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowOrdersEvent(this, EventArgs.Empty);
        }

        private void CreateGridControl()
        {
            this.gridControl1.Location = new Point(0, 170);
            this.gridControl1.Size = new Size(785, 485);

            this.gridView1 = this.gridControl1.MainView as GridView;
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
            this.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);

            this.gridView1.Columns[1].BestFit();
            this.gridView1.Columns[5].BestFit();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                GridColumn colID = this.gridView1.Columns[0];
                selectedIdPatient = Convert.ToInt32(view.GetRowCellValue(info.RowHandle, colID));

                ShowPatientDataEvent(this, EventArgs.Empty);              
            }
        }

    }
}
