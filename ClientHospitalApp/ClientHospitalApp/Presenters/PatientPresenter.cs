using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientHospitalApp.Views;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Models;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid;

namespace ClientHospitalApp.Presenters
{
    public class PatientPresenter
    {
        public IPatient patientSearchView;
        private IPatientModel patientModel;
        ListOfPatientsForm patientsListView;
        public List<Patient> PatientList 
        { 
            get { return patientModel.List; }
        }

        public PatientPresenter(IPatient patientSearchView, IPatientModel model)
        {
            this.patientSearchView = patientSearchView;
            this.patientModel = model;
        }

        public PatientPresenter(ListOfPatientsForm patientsListView, IPatientModel model)
        {
            this.patientsListView = patientsListView;
            this.patientModel = model;
            patientsListView.LoadDataDataEvent += GetAllPatientsFromModelEventHandler;

        }

        public PatientPresenter()
        {
           
            this.patientModel = new PatientModel();
        }

        public void GetPatientFromModel(int IdPatient)
        {
            patientModel.GetPatient(IdPatient);

            /*patientSearchView.ID_PatientText = Convert.ToString(patientModel.patient.ID_Patient);
            patientSearchView.LastnameText = patientModel.patient.Lastname;
            patientSearchView.FirstnameText = patientModel.patient.Firstname;
            patientSearchView.DOBText = Convert.ToString(patientModel.patient.DOB);
            patientSearchView.SSNText = Convert.ToString(patientModel.patient.SSN);
            patientSearchView.ID_GenderText = Convert.ToString(patientModel.patient.ID_Gender);*/
            patientSearchView.PatientData = patientModel.Patient;
        }

        private void GetAllPatientsFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllPatientsFromModel();
        }

        public void GetAllPatientsFromModel()
        {
            PatientList.Clear();
            patientModel.GetAllPatients();

            this.patientsListView.gridControl1 = new GridControl();
            this.patientsListView.gridControl1.Parent = this.patientsListView;
            this.patientsListView.gridControl1.Location = new Point(0, 170);
            this.patientsListView.gridControl1.Size = new Size(785, 485);

            this.patientsListView.gridView1 = this.patientsListView.gridControl1.MainView as GridView;
            //colID = gridView1.Columns["ID_PatientText"];
            //colLastname = gridView1.Columns["LastnameText"];
            //colFirstname = gridView1.Columns["FirstnameText"];
            //colDOB = gridView1.Columns["DOBText"];
            //colSSN = gridView1.Columns["SSNText"];
            //colGender = gridView1.Columns["ID_GenderText"];

            this.patientsListView.gridView1.Columns[1].Caption = "Lastname";
            this.patientsListView.gridView1.Columns[2].Caption = "Firstname";
            this.patientsListView.gridView1.Columns[3].Caption = "Data of birth";
            this.patientsListView.gridView1.Columns[4].Caption = "SSN";

            this.patientsListView.colID.Visible = false;
            this.patientsListView.colGender.Visible = false;

            //colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.patientsListView.gridView1.OptionsView.ShowGroupedColumns = true;
            this.patientsListView.gridView1.ExpandAllGroups();
            this.patientsListView.gridView1.OptionsBehavior.Editable = false;
            this.patientsListView.gridView1.OptionsSelection.MultiSelect = false;
            //this.patientsListView.gridView1.DoubleClick += new System.EventHandler(this.patientsListView.gridView1_DoubleClick);

            //colLastname.BestFit();
            //colGender.BestFit();
        }

        private void RefreshDataEventHandler(object sender, EventArgs args)
        {
            GetAllPatientsFromModel();
            patientsListView.gridControl1.RefreshDataSource();
            patientsListView.colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        public void SavePatientInModel()
        {
            bool flag=Program.Validate(patientSearchView);

            if (flag)
            {
                //TransformDataPatientFromViewToModel(1);
                patientModel.Patient=patientSearchView.PatientData;
                patientModel.SavePatient();
            }
        }

        public void UpdatePatientInModel()
        {
            bool flag = Program.Validate(patientSearchView);

            if (flag)
            {
                //TransformDataPatientFromViewToModel(2);
                patientModel.Patient = patientSearchView.PatientData;
                patientModel.UpdatePatient();
            }
        }

        public void DeletePatientInModel()
        {
            //TransformDataPatientFromViewToModel(2);
            patientModel.Patient = patientSearchView.PatientData;
            patientModel.DeletePatient();
        }

        /*public void TransformDataPatientFromViewToModel(int methodNumber)
        {
            if (methodNumber == 2)
            {
                patientModel.patient.ID_Patient = Convert.ToInt32(patientSearchView.ID_PatientText);
            }
            patientModel.patient.Lastname = patientSearchView.LastnameText;
            patientModel.patient.Firstname = patientSearchView.FirstnameText;
            patientModel.patient.DOB = Convert.ToDateTime(patientSearchView.DOBText);
            patientModel.patient.SSN = Convert.ToInt32(patientSearchView.SSNText);
            patientModel.patient.ID_Gender = Convert.ToInt32(patientSearchView.ID_GenderText);
        }*/
    }
}
