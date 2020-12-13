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
        public PatientDataInfoForm()
        {
            InitializeComponent();
            //init additional controls
           
            this.Text = "Detailed data of patient";

            //pdiForm.patientSearchExtendForm1.PatientData = this.patientSearchView.selectedPatient;
            //pdiForm.patientSearchExtendForm1.GenderDataSource = genderModel.ListGender;

            //GetRelativesOfPatientFromModel(this.patientSearchView.selectedPatient);
            //pdiForm.patientSearchExtendForm1.RelativeDataSource = patientModel.Patient.RelativeList;
            // :(
            //GridView gridViewRelatives = this.patientSearchExtendForm1.gridControl1.MainView as GridView;
            //gridViewRelatives.OptionsView.ShowViewCaption = true;
            //gridViewRelatives.ViewCaption = "Relatives";
            //gridViewRelatives.Columns["ID_Relative"].Visible = false;
            //gridViewRelatives.Columns["ID_Patient"].Visible = false;
            //gridViewRelatives.Columns["ID_Gender"].Visible = false;
            //gridViewRelatives.Columns["Status"].Visible = false;

            //this.patientSearchExtendForm1.buttonCancel.Hide();
            //this.patientSearchExtendForm1.buttonOK.Hide();

            DialogResult res = this.ShowDialog();
        }


    }
}
