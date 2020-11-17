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

        public event EventHandler LoadDataDataEvent;
        public event EventHandler AddPatientEvent;
        public event EventHandler EditPatientEvent;
        public event EventHandler DeletePatientEvent;
        public event EventHandler ShowOrdersEvent;

        public ListOfPatientsForm()
        {
            InitializeComponent();
        }

     
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataDataEvent(this, EventArgs.Empty);
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
    }
}
