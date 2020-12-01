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
        private IPatientModel patientModel;
        private IGenderModel genderModel;
        IPatientSearchForm patientSearchView;
        public List<Patient> PatientList 
        { 
            get { return patientModel.List; }
            set { patientModel.List=value; }
        }
        MainForm mainForm;
       // public List<Gender> gl;
        private GenericModelImpl<Patient> modelPatientsToDB;
        bool EditClicked = false;

        public PatientPresenter(IPatientSearchForm patientSearchView, IPatientModel model,IGenderModel modelGender)
        {
            this.patientSearchView = patientSearchView;
            this.patientModel = model;
            this.genderModel = modelGender;
            //this.gl = new List<Gender>();
            this.modelPatientsToDB = new GenericModelImpl<Patient>();
            this.mainForm = ((PatientSearchForm)(patientSearchView)).MdiParent as MainForm;
            genderModel.GetGender();
            this.patientSearchView.DataSourceGender=genderModel.ListGender;

            this.patientSearchView.LoadDataDataEvent += GetAllPatientsFromModelEventHandler;
            this.patientSearchView.PatientDetailData.AddOrUpdatePatientEvent += AddOrUpdatePatientEventHandler;
            this.patientSearchView.EditPatientEvent += EditPatientEventHandler;
            this.patientSearchView.DeletePatientEvent += DeletePatientEventHandler;
            this.mainForm.SaveDataEvent += SaveDataEventHandler;
            this.patientSearchView.ShowPatientDataEvent += ShowPatientDataEventHandler;
            this.patientSearchView.ShowOrdersEvent += ShowOrdersEventHandler;
        }

        public void GetPatientFromModel(int IdPatient)
        {
            patientModel.GetPatient(IdPatient);
            //patientSearchView.DataPatient = patientModel.Patient;
        }

        private void GetAllPatientsFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllPatientsFromModel();
        }

        public void GetAllPatientsFromModel()
        {
            PatientList.Clear();
            patientModel.GetAllPatients();
            PatientList = patientModel.List;
            this.patientSearchView.DataSourcePatients = PatientList;
        }
     

        private void RefreshData()
        {
            GetAllPatientsFromModel();
            this.patientSearchView.DataSourcePatients = PatientList;
        }


        private void GetGender()
        {
            //Get data from Gender model. try to use custom lookup. 
        }
        /*    private void GetGender()
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
                this.patientSearchView.DataSourceGender= gl;
            }*/

        private void AddOrUpdatePatientEventHandler(object sender, EventArgs args)
        {
            Patient tempPatient = this.patientSearchView.PatientDetailData.PatientData;
            MessageBox.Show(this.patientSearchView.PatientDetailData.PatientData.Gender.ToString());

            if (!EditClicked)
            {
                modelPatientsToDB.ListToAddInDB.Add(tempPatient);
                

                PatientList.Add(tempPatient);
                this.patientSearchView.PatientDetailData.ClearAllData();

            }
            else
            {
                if (this.patientSearchView.selectedIdPatient > 0)
                {
                    tempPatient.ID_Patient = this.patientSearchView.PatientDetailData.PatientData.ID_Patient;
                    modelPatientsToDB.ListToUpdateInDB.Add(tempPatient);
                    
                    for (int i=0;i<PatientList.Count;i++)
                    {
                        if (PatientList[i].ID_Patient == tempPatient.ID_Patient)
                        {
                            PatientList[i] = tempPatient;
                        }
                    }
                }
                else 
                {
                    //значит мы решили отредачить нового пациента(еще не внесенного в базу,те у него нет ид пока) кот нах-ся в гридвью
                    if(modelPatientsToDB.ListToAddInDB.Count>0)
                    {
                        for (int i = 0; i < modelPatientsToDB.ListToAddInDB.Count; i++)
                        {
                            if (modelPatientsToDB.ListToAddInDB[i].SSN == this.patientSearchView.selectedSSN)
                            {
                                modelPatientsToDB.ListToAddInDB[i] = tempPatient;
                            }
                        }

                        for (int i = 0; i < PatientList.Count; i++)
                        {
                            if (PatientList[i].SSN == this.patientSearchView.selectedSSN)
                            {
                                PatientList[i] = tempPatient;
                            }
                        }
                    }
                }
                this.patientSearchView.PatientDetailData.ClearAllData();
                EditClicked = false;
                this.patientSearchView.PatientDetailData.buttonOK.Text = "Add";
            }
            this.patientSearchView.DataSourcePatients = PatientList;
        }

        private void EditPatientEventHandler(object sender, EventArgs args)
        {
            EditClicked = true;
            
            foreach (Patient item in PatientList)
            {
                if (item.ID_Patient == this.patientSearchView.selectedIdPatient)
                {
                    this.patientSearchView.PatientDetailData.PatientData = item;
                }
            }
        }

        private void DeletePatientEventHandler(object sender, EventArgs args)
        {
            if (this.patientSearchView.selectedIdPatient > 0)
            {
                Patient p = new Patient();
                foreach (Patient item in PatientList)
                {
                    if (item.ID_Patient == this.patientSearchView.selectedIdPatient)
                    {
                        p = item;
                    }
                }

                DialogResult res = MessageBox.Show("Delete " + p.Lastname + " " + p.Firstname +
                                   "?", "Deleting patient", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    try
                    {
                        modelPatientsToDB.ListToDeleteInDB.Add(p);
                        PatientList.Remove(p);
                        this.patientSearchView.DataSourcePatients = PatientList;
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                    }
                }
            }
            else if(this.patientSearchView.selectedIdPatient == 0)  //значит мы решили удалить нового пациента,который добавлен в гридвью но еще не в базу
            {
                for (int i = 0; i < modelPatientsToDB.ListToAddInDB.Count; i++)
                {
                    if (modelPatientsToDB.ListToAddInDB[i].SSN == this.patientSearchView.selectedSSN)
                    {
                        modelPatientsToDB.ListToAddInDB.Remove(modelPatientsToDB.ListToAddInDB[i]);
                    }
                }

                for (int i = 0; i < PatientList.Count; i++)
                {
                    if (PatientList[i].SSN == this.patientSearchView.selectedSSN)
                    {
                        PatientList.Remove(PatientList[i]);
                    }
                }
                this.patientSearchView.DataSourcePatients = PatientList;
            }
        }


    private void SaveDataEventHandler(object sender, EventArgs args)
        {
           if(modelPatientsToDB.ListToAddInDB.Count>0)
           {
                patientModel.ListToAdd = modelPatientsToDB.ListToAddInDB;
                patientModel.AddPatient();
                modelPatientsToDB.ListToAddInDB.Clear();

                MessageBox.Show("Data saved");
           }

            if (modelPatientsToDB.ListToUpdateInDB.Count > 0)
            {
                patientModel.ListToUpdate = modelPatientsToDB.ListToUpdateInDB;
                patientModel.UpdatePatient();
                modelPatientsToDB.ListToUpdateInDB.Clear();

                MessageBox.Show("Data updated");
            }

            if (modelPatientsToDB.ListToDeleteInDB.Count > 0)
            {
                patientModel.ListToDelete = modelPatientsToDB.ListToDeleteInDB;
                patientModel.DeletePatient();
                modelPatientsToDB.ListToDeleteInDB.Clear();

                MessageBox.Show("Data deleted");
            }
        }

            private void ShowPatientDataEventHandler(object sender, EventArgs args)
        {
            PatientDataInfoForm pdiForm = new PatientDataInfoForm();
            pdiForm.Text= "Detailed data of patient";

            //MessageBox.Show(this.patientSearchView.selectedIdPatient.ToString());
            foreach (Patient item in PatientList)
            {
                if (item.ID_Patient == this.patientSearchView.selectedIdPatient)
                {
                    //pdiForm.patientDetail1.PatientData = item;
                }
            }

            //pdiForm.patientDetail1.DataSourceGender = gl;
            DialogResult res =pdiForm.ShowDialog();

            //PatientSearchForm psForm = new PatientSearchForm();
            // psForm.Text = "Detailed data of patient";
            // psForm.patientDetail1.buttonCancel.Hide();
            // psForm.patientDetail1.buttonOK.Hide();

            // foreach (Patient item in PatientList)
            // {
            //     if (item.ID_Patient == this.patientSearchView.selectedIdPatient)
            //     {
            //         psForm.patientDetail1.PatientData = item;
            //     }
            // }

            // psForm.patientDetail1.DataSourceGender = gl;
            // GetRelativesOfPatientFromModel(this.patientSearchView.selectedIdPatient);

            ///////////////////////////////////////////////////////////

            //psForm.gridControlRelatives.DataSource = patientModel.ListRelative;

            //GridView gridViewRelatives = psForm.gridControlRelatives.MainView as GridView;
            //gridViewRelatives.OptionsView.ShowViewCaption = true;
            //gridViewRelatives.ViewCaption = "Relatives";
            //gridViewRelatives.Columns["ID_Relative"].Visible = false;
            //gridViewRelatives.Columns["ID_Patient"].Visible = false;
            //gridViewRelatives.Columns["ID_Gender"].Visible = false;
            //gridViewRelatives.Columns["Status"].Visible = false;

            //DialogResult res = psForm.ShowDialog();
        }



        private void SavePatientInModel()
        {
            //bool flag=Program.Validate(patientSearchView);

            //if (flag)
            //{
            //    //patientModel.Patient=patientSearchView.DataPatient;
            //    patientModel.SavePatient();
            //}
        }

        public void UpdatePatientInModel()
        {
            //bool flag = Program.Validate(patientSearchView);

            //if (flag)
            //{
            //   // patientModel.Patient = patientSearchView.DataPatient;
            //    patientModel.UpdatePatient();
            //}
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
