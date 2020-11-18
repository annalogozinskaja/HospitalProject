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
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using ClientHospitalApp.Reports;

namespace ClientHospitalApp.Presenters
{
    public class PatientPresenter
    {
        public IPatientView patientSearchView;
        private IPatientModel patientModel;
        IListOfPatientsForm patientsListView;
        public List<Patient> PatientList 
        { 
            get { return patientModel.List; }
            set { patientModel.List= value; }
        }
        private PatientSearchForm psForm;
        public List<Gender> gl;


        public PatientPresenter(IListOfPatientsForm patientsListView, IPatientModel model)
        {
            this.patientsListView = patientsListView;
            this.patientModel = model;
            this.gl = new List<Gender>();
            this.patientsListView.LoadDataDataEvent += GetAllPatientsFromModelEventHandler;
            this.patientsListView.AddPatientEvent += AddPatientEventHandler;
            this.patientsListView.EditPatientEvent += EditPatientEventHandler;
            this.patientsListView.DeletePatientEvent += DeletePatientEventHandler;
            this.patientsListView.ShowPatientDataEvent += ShowPatientDataEventHandler;
            this.patientsListView.ShowOrdersEvent += ShowOrdersEventHandler;          
        }

        public void GetPatientFromModel(int IdPatient)
        {
            patientModel.GetPatient(IdPatient);
            patientSearchView.DataPatient = patientModel.Patient;
        }

        private void GetAllPatientsFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllPatientsFromModel();
            GetGender();
        }

        public void GetAllPatientsFromModel()
        {
            PatientList.Clear();
            patientModel.GetAllPatients();
            PatientList = patientModel.List;
            this.patientsListView.DataSource = PatientList;
        }
     

        private void RefreshData()
        {
            GetAllPatientsFromModel();
            this.patientsListView.DataSource = PatientList;
        }

        private void GetGender()
        {
            bool flag = false;

            foreach (Patient itemP in PatientList)
            {
                flag = false;
                foreach (Gender itemG in gl)
                {
                    if (itemG.GenderName == itemP.Gender.GenderName)
                    {
                        flag = true;
                    }
                }
                if (!flag)
                {
                    gl.Add(itemP.Gender);
                }
            }
        }

        private void AddPatientEventHandler(object sender, EventArgs args)
        {
            psForm = new PatientSearchForm();
            psForm.Text = "Add patient";
            psForm.gridControlRelatives.Hide();
            psForm.Size = new Size(340, 355);

            psForm.patientDetail1.DataSourceGender = gl;
            DialogResult res = psForm.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    patientSearchView = psForm;
                    SavePatientInModel();
                }
                catch (Exception s)
                {
                    Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                }
                RefreshData();
            }
        }

        private void EditPatientEventHandler(object sender, EventArgs args)
        {
            int[] selectedRowHandles = this.patientsListView.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                psForm = new PatientSearchForm();
                psForm.Text = "Update patient";
                psForm.gridControlRelatives.Hide();
                psForm.Size = new Size(340, 355);

                psForm.patientDetail1.DataSourceGender = gl;
                int idPatient = Convert.ToInt32(this.patientsListView.gridView1.GetRowCellDisplayText(selectedRowHandles[0], this.patientsListView.gridView1.Columns[0]));

                foreach (Patient item in PatientList)
                {
                    if(item.ID_Patient==idPatient)
                    {
                        psForm.patientDetail1.PatientData = item;
                    }
                }
               
                DialogResult res = psForm.ShowDialog();

                if (res == DialogResult.OK)
                {
                    try
                    {
                        patientSearchView = psForm;
                        UpdatePatientInModel();
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                    }
                    RefreshData();
                }

            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose the patient");
            }
        }

        private void DeletePatientEventHandler(object sender, EventArgs args)
        {
            int[] selectedRowHandles = this.patientsListView.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                DialogResult res = MessageBox.Show("Delete " + 
                        this.patientsListView.gridView1.GetRowCellDisplayText(selectedRowHandles[0], this.patientsListView.gridView1.Columns[1]) +
                        " " + this.patientsListView.gridView1.GetRowCellDisplayText(selectedRowHandles[0], this.patientsListView.gridView1.Columns[2]) + 
                        "?", "Deleting patient", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        int idPatient = Convert.ToInt32(this.patientsListView.gridView1.GetRowCellDisplayText(selectedRowHandles[0], this.patientsListView.gridView1.Columns[0]));

                        foreach (Patient item in PatientList)
                        {
                            if (item.ID_Patient == idPatient)
                            {
                                patientModel.Patient = item;
                            }
                        }
                        DeletePatientInModel();
                        RefreshData();
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                    }
                }
            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose the patient");
            }
        }

        private void ShowPatientDataEventHandler(object sender, EventArgs args)
        {
            PatientSearchForm psForm = new PatientSearchForm();
            psForm.Text = "Detailed data of patient";
            psForm.patientDetail1.buttonCancel.Hide();
            psForm.patientDetail1.buttonOK.Hide();

            foreach (Patient item in PatientList)
            {
                if (item.ID_Patient == this.patientsListView.selectedIdPatient)
                {
                    psForm.patientDetail1.PatientData = item;
                }
            }

            psForm.patientDetail1.DataSourceGender = gl;
            GetRelativesOfPatientFromModel(this.patientsListView.selectedIdPatient);

            ///////////////////////////////////////////////////////////
            psForm.gridControlRelatives.DataSource = patientModel.ListRelative;

            GridView gridViewRelatives = psForm.gridControlRelatives.MainView as GridView;
            gridViewRelatives.OptionsView.ShowViewCaption = true;
            gridViewRelatives.ViewCaption = "Relatives";
            gridViewRelatives.Columns["ID_Relative"].Visible = false;
            gridViewRelatives.Columns["ID_Patient"].Visible = false;
            gridViewRelatives.Columns["ID_Gender"].Visible = false;
            gridViewRelatives.Columns["Status"].Visible = false;

            DialogResult res = psForm.ShowDialog();
        }



        private void SavePatientInModel()
        {
            bool flag=Program.Validate(patientSearchView);

            if (flag)
            {
                patientModel.Patient=patientSearchView.DataPatient;
                patientModel.SavePatient();
            }
        }

        public void UpdatePatientInModel()
        {
            bool flag = Program.Validate(patientSearchView);

            if (flag)
            {
                patientModel.Patient = patientSearchView.DataPatient;
                patientModel.UpdatePatient();
            }
        }

        public void DeletePatientInModel()
        {
            patientModel.DeletePatient();
        }

        private void GetRelativesOfPatientFromModel(int IdPatient)
        {
            patientModel.GetRelativesOfPatient(IdPatient);
        }

        private void ShowOrdersEventHandler(object sender, EventArgs args)
        {
            OrdersReport OrdRep = new OrdersReport();
            OrdRep.Text = "Orders of the patient";

            OrdRep.ShowDialog();
        }

    }
}
