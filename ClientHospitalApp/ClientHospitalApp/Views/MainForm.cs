using ClientHospitalApp.Models;
using ClientHospitalApp.Presenters;
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
            ListOfPatientsForm lpForm = new ListOfPatientsForm();
            PatientPresenter patientPresenter = new PatientPresenter(lpForm, new PatientModel());

            lpForm.MdiParent = this;
            lpForm.Show();
            //Hide();
        }

        private void barButtonOrders_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
