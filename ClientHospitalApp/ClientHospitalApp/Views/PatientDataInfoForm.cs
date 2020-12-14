using DevExpress.XtraGrid.Views.Grid;
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
    public partial class PatientDataInfoForm : Form, IPatientDataInfoForm
    {
        public PatientSearchExtendForm patientSearchExtendForm
        {
            set { patientSearchExtendForm1 = value; }
            get { return patientSearchExtendForm1; }
        }
        public void ApplyOptionsForGridViewRelatives()
        {
            GridView gridViewRelatives = this.patientSearchExtendForm1.gridControl1.MainView as GridView;
            gridViewRelatives.OptionsView.ShowViewCaption = true;
            gridViewRelatives.ViewCaption = "Relatives";
            gridViewRelatives.Columns["ID_Relative"].Visible = false;
            gridViewRelatives.Columns["ID_Patient"].Visible = false;
            gridViewRelatives.Columns["ID_Gender"].Visible = false;
            gridViewRelatives.Columns["Status"].Visible = false;
        }
        public PatientDataInfoForm()
        {
            InitializeComponent();
           
            this.Text = "Detailed data of patient";
            this.patientSearchExtendForm1.buttonCancel.Hide();
            this.patientSearchExtendForm1.buttonOK.Hide();
        }
    }
}
