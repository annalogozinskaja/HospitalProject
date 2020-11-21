using ClientHospitalApp.Models;
using ClientHospitalApp.Presenters;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonPatients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PatientSearchForm patientSearchForm = new PatientSearchForm();
            //PatientPresenter patientPresenter = new PatientPresenter(patientSearchForm, new PatientModel());

            patientSearchForm.MdiParent = this;
            patientSearchForm.Show();
        }

        private void barButtonOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
