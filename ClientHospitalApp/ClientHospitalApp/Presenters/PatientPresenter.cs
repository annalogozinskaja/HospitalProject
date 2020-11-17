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
        public IPatient patientSearchView;
        private IPatientModel patientModel;
        ListOfPatientsForm patientsListView;
        public List<Patient> PatientList 
        { 
            get { return patientModel.List; }
            set { patientModel.List= value; }
        }
        private PatientSearchForm psForm;

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
            patientsListView.EditPatientEvent += EditPatientEventHandler;
            patientsListView.DeletePatientEvent += DeletePatientEventHandler;
            patientsListView.ShowOrdersEvent += ShowOrdersEventHandler;
        }

        public void GetPatientFromModel(int IdPatient)
        {
            patientModel.GetPatient(IdPatient);
            patientSearchView.DataPatient = patientModel.Patient;
        }

        private void GetAllPatientsFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllPatientsFromModel();
            CreateGridControl();
        }

        public void GetAllPatientsFromModel()
        {
            PatientList.Clear();
            patientModel.GetAllPatients();
            PatientList = this.patientModel.List;
        }
        private void CreateGridControl()
        {
            this.patientsListView.gridControl1 = new GridControl();
            this.patientsListView.gridControl1.Parent = this.patientsListView;
            this.patientsListView.gridControl1.Location = new Point(0, 170);
            this.patientsListView.gridControl1.Size = new Size(785, 485);
            this.patientsListView.gridControl1.DataSource = PatientList;
            
            this.patientsListView.gridView1 = this.patientsListView.gridControl1.MainView as GridView;
            this.patientsListView.gridView1.Columns[1].Caption = "Lastname";
            this.patientsListView.gridView1.Columns[2].Caption = "Firstname";
            this.patientsListView.gridView1.Columns[3].Caption = "Data of birth";
            this.patientsListView.gridView1.Columns[4].Caption = "SSN";

            this.patientsListView.gridView1.Columns[0].Visible = false;
            this.patientsListView.gridView1.Columns[5].Visible = false;
            this.patientsListView.gridView1.Columns[6].Visible = false;

            this.patientsListView.gridView1.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            this.patientsListView.gridView1.OptionsView.ShowGroupedColumns = true;
            this.patientsListView.gridView1.ExpandAllGroups();
            this.patientsListView.gridView1.OptionsBehavior.Editable = false;
            this.patientsListView.gridView1.OptionsSelection.MultiSelect = false;
            this.patientsListView.gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);

            this.patientsListView.gridView1.Columns[1].BestFit();
            this.patientsListView.gridView1.Columns[5].BestFit();
        }

        private void RefreshData()
        {
            GetAllPatientsFromModel();
            this.patientsListView.gridControl1.DataSource = PatientList;
            this.patientsListView.gridView1.Columns[1].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
        }
        private void FillLookUpEditGender(PatientSearchForm form)
        {
            List<Gender> gl = new List<Gender>();
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

            form.patientDetail1.lookUpEditGender.Properties.DataSource = gl;
            form.patientDetail1.lookUpEditGender.Properties.DisplayMember = "GenderName";
            form.patientDetail1.lookUpEditGender.Properties.ValueMember = "ID_Gender";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GenderName", "Gender", 100);
            form.patientDetail1.lookUpEditGender.Properties.Columns.Add(col);
            form.patientDetail1.lookUpEditGender.Properties.NullText = "--choose gender--";
        }

        private void AddPatientEventHandler(object sender, EventArgs args)
        {
            psForm = new PatientSearchForm();
            psForm.Text = "Add patient";
            psForm.gridControlRelatives.Hide();
            psForm.Size = new Size(340, 355);

            FillLookUpEditGender(psForm);
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

                FillLookUpEditGender(psForm);
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
        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                GridColumn colID = this.patientsListView.gridView1.Columns[0];
                int valID = Convert.ToInt32(view.GetRowCellValue(info.RowHandle, colID));

                psForm = new PatientSearchForm();
                psForm.Text = "Detailed data of patient";
                psForm.patientDetail1.buttonCancel.Hide();
                psForm.patientDetail1.buttonOK.Hide();

                foreach (Patient item in PatientList)
                {
                    if (item.ID_Patient == valID)
                    {
                        psForm.patientDetail1.PatientData = item;
                    }
                }

                FillLookUpEditGender(psForm);
                GetRelativesOfPatientFromModel(valID);
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
