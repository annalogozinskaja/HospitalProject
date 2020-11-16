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
    public partial class ListOfPatientsForm : Form
    {
        public GridControl gridControl1;
        public GridView gridView1;
      
        public ListOfPatientsForm()
        {
            InitializeComponent();
        }


        public List<IPatient> DataSource
        {
            private get { return (List<IPatient>)gridControl1.DataSource; }
            set 
            {
                gridControl1.DataSource = value;
            }
        }

        public event EventHandler LoadDataDataEvent;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataDataEvent(this, EventArgs.Empty);
        }


        //private void comboBoxEditGndr_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    ComboBoxEdit combo = sender as ComboBoxEdit;
        //    strGender = combo.SelectedItem.ToString();
        //}

        //public event EventHandler RefreshDataEvent; 
        //public void RefreshData()
        //{
        //    RefreshDataEvent(this, EventArgs.Empty);
        //   // presenter.GetAllPatientsFromModel();
        //  //  gridControl1.RefreshDataSource();
        //   // colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        //}

        public event EventHandler AddPatientEvent;
        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddPatientEvent(this, EventArgs.Empty);
        }

        public event EventHandler EditPatientEvent;
        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditPatientEvent(this, EventArgs.Empty);
        }

        public event EventHandler DeletePatientEvent;
        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeletePatientEvent(this, EventArgs.Empty);
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //DXMouseEventArgs ea = e as DXMouseEventArgs;
            //GridView view = sender as GridView;
            //GridHitInfo info = view.CalcHitInfo(ea.Location);
            //if (info.InRow || info.InRowCell)
            //{
            //    string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
            //    GridColumn col = gridView1.Columns[2];
            //    object val = view.GetRowCellValue(info.RowHandle, col);
            //    // MessageBox.Show(val.ToString());
            //    // MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.InRow, colCaption));

            //    PatientSearchForm F = new PatientSearchForm();
            //    F.Text = "Detailed data of patient";

            //    GenderPresenter genderPresenter = new GenderPresenter(F);
            //    genderPresenter.GetListGenderFromModel();

            //    F.textEditIdPatient.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[0])).ToString();
            //    F.textEditLnm.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[1])).ToString();
            //    F.textEditFnm.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[2])).ToString();
            //    F.dateEditDOB.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[3])).ToString();
            //    F.textEditSSN.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[4])).ToString();
            //    string tempGender = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[5])).ToString();

            //    foreach (Gender item in genderPresenter.genderModel.list)
            //    {
            //        if (tempGender.CompareTo(Convert.ToString(item.ID_Gender)) == 0)
            //        {
            //            F.comboBoxEditGndr.EditValue = item.GenderName;
            //        }
            //    }

            //    RelativePresenter relativePresenter = new RelativePresenter(F);
            //    relativePresenter.GetRelativesOfPatientInModel(Convert.ToInt32(F.textEditIdPatient.Text));
            //    F.gridControlRelatives.DataSource = relativePresenter.relativeModel.list;

            //    GridView gridViewRelatives = F.gridControlRelatives.MainView as GridView;
            //    gridViewRelatives.OptionsView.ShowViewCaption = true;
            //    gridViewRelatives.ViewCaption = "Relatives";
            //    gridViewRelatives.Columns["ID_Relative"].Visible = false;
            //    gridViewRelatives.Columns["ID_Patient"].Visible = false;
            //    gridViewRelatives.Columns["ID_Gender"].Visible = false;

            //    F.buttonCancel.Hide();
            //    F.buttonOK.Hide();
            //    F.Size = new Size(822, 305);
            //    F.textEditIdPatient.Enabled = true;
            //    DialogResult res = F.ShowDialog();

            //}
        }



       

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrdersReport OrdRep = new OrdersReport();
            OrdRep.Text = "Orders of the patient";

            OrdRep.ShowDialog();
        }
    }
}
