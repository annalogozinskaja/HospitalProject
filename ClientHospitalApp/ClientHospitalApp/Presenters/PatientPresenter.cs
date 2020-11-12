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
            set { patientModel.List= value; }
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
            patientsListView.AddPatientEvent += AddPatientEventHandler;
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
            PatientList = this.patientModel.List;
            FillGridControl();           
        }
        private void FillGridControl()
        {
            this.patientsListView.gridControl1 = new GridControl();
            this.patientsListView.gridControl1.Parent = this.patientsListView;
            this.patientsListView.gridControl1.Location = new Point(0, 170);
            this.patientsListView.gridControl1.Size = new Size(785, 485);
            this.patientsListView.gridControl1.DataSource = PatientList;
            foreach (var item in PatientList)
            {
                MessageBox.Show(item.Gender.GenderName);
            }
           

            this.patientsListView.gridView1 = this.patientsListView.gridControl1.MainView as GridView;
            this.patientsListView.gridView1.Columns[1].Caption = "Lastname";
            this.patientsListView.gridView1.Columns[2].Caption = "Firstname";
            this.patientsListView.gridView1.Columns[3].Caption = "Data of birth";
            this.patientsListView.gridView1.Columns[4].Caption = "SSN";

            this.patientsListView.gridView1.Columns[0].Visible = false;
            //this.patientsListView.gridView1.Columns[5].Visible = false;
            this.patientsListView.gridView1.Columns[6].Visible = false;

            this.patientsListView.gridView1.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.patientsListView.gridView1.OptionsView.ShowGroupedColumns = true;
            this.patientsListView.gridView1.ExpandAllGroups();
            this.patientsListView.gridView1.OptionsBehavior.Editable = false;
            this.patientsListView.gridView1.OptionsSelection.MultiSelect = false;
            //this.patientsListView.gridView1.DoubleClick += new System.EventHandler(this.patientsListView.gridView1_DoubleClick);

            this.patientsListView.gridView1.Columns[1].BestFit();
            this.patientsListView.gridView1.Columns[5].BestFit();
        }

        private void RefreshDataEventHandler(object sender, EventArgs args)
        {
            GetAllPatientsFromModel();
            patientsListView.gridControl1.RefreshDataSource();
            this.patientsListView.gridView1.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }

        private void AddPatientEventHandler(object sender, EventArgs args)
        {
            PatientSearchForm psForm = new PatientSearchForm();
            psForm.Text = "Add patient";

            psForm.comboBoxEditGndr.EditValue = "--choose gender--";

            bool flag=false;
            foreach (Patient itemP in PatientList)
            {
                flag = false;
                foreach (var itemG in psForm.comboBoxEditGndr.Properties.Items)
                {                 
                    if(itemG.ToString()== itemP.Gender.GenderName)
                    {
                        flag = true;
                    }                      
                }
                if(!flag)
                {
                    psForm.comboBoxEditGndr.Properties.Items.Add(itemP.Gender.GenderName);
                }
            }

            //GenderPresenter genderPresenter = new GenderPresenter(psForm);
            //genderPresenter.GetListGenderFromModel();

            //psForm.comboBoxEditGndr.EditValue = "--choose gender--";
            //foreach (Gender item in genderPresenter.genderModel.list)
            //{
            //    psForm.comboBoxEditGndr.Properties.Items.Add(item.GenderName);
            //}

            // psForm.comboBoxEditGndr.SelectedIndexChanged += new System.EventHandler(comboBoxEditGndr_SelectedIndexChanged);
            psForm.gridControlRelatives.Hide();
            psForm.Size = new Size(350, 355);

            DialogResult res = psForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    //bool flagGender = false;
                    //foreach (Gender item in genderPresenter.genderModel.list)
                    //{
                    //    if (strGender.CompareTo(item.GenderName) == 0)
                    //    {
                    //        F.ID_GenderText = Convert.ToString(item.ID_Gender);
                    //        flagGender = true;
                    //    }
                    //}

                    //if (!flagGender)
                    //{
                    //    F.ID_GenderText = strGender;
                    //}

                    patientSearchView = psForm;
                    SavePatientInModel();
                }
                catch (Exception s)
                {
                    Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                }

                //RefreshData();
            }
        }


        private void SavePatientInModel()
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
