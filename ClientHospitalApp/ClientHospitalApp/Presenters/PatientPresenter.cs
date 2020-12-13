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
using ClientHospitalApp.ClientEntities;

namespace ClientHospitalApp.Presenters
{
    public class PatientPresenter
    {
        private IPatientModel patientModel;
        private IGenderModel genderModel;
        IPatientSearchForm patientSearchView;
        public List<PatientClient> PatientList 
        { 
            get { return patientModel.List; }
            set { patientModel.List=value; }
        }
        MainForm mainForm;
        bool EditClicked = false;

        public PatientPresenter(IPatientSearchForm patientSearchView, IPatientModel model,IGenderModel modelGender)
        {
            this.patientSearchView = patientSearchView;
            this.patientModel = model;
            this.genderModel = modelGender;
            //:(
            this.mainForm = ((PatientSearchForm)(patientSearchView)).MdiParent as MainForm;
            genderModel.GetGender();
            this.patientSearchView.DataSourceGender = genderModel.ListGender;

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

        private void AddOrUpdatePatientEventHandler(object sender, EventArgs args)
        {
            PatientClient tempPatient = this.patientSearchView.PatientDetailData.PatientData;

            if (!EditClicked)
            {
                patientModel.ListToAdd.Add(tempPatient);
                PatientList.Add(tempPatient);
                this.patientSearchView.PatientDetailData.ClearAllData();

            }
            else
            {
                if (this.patientSearchView.selectedPatient.ID_Patient > 0)
                {
                    tempPatient.ID_Patient = this.patientSearchView.PatientDetailData.PatientData.ID_Patient;
                    patientModel.ListToUpdate.Add(tempPatient);
                    
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
                    if(patientModel.ListToAdd.Count>0)
                    {
                        for (int i = 0; i < patientModel.ListToAdd.Count; i++)
                        {
                            if (patientModel.ListToAdd[i].Equals(this.patientSearchView.selectedPatient))
                            {
                                patientModel.ListToAdd[i] = tempPatient;
                            }
                        }

                        for (int i = 0; i < PatientList.Count; i++)
                        {
                            if (PatientList[i] == this.patientSearchView.selectedPatient)
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
            
            foreach (PatientClient item in PatientList)
            {
                if (item.ID_Patient == this.patientSearchView.selectedPatient.ID_Patient)
                {
                    this.patientSearchView.PatientDetailData.PatientData = item;
                }
            }
        }

        private void DeletePatientEventHandler(object sender, EventArgs args)
        {
            DialogResult res = MessageBox.Show("Delete " + this.patientSearchView.selectedPatient.Lastname + " " +
                                  this.patientSearchView.selectedPatient.Firstname + "?", "Deleting patient", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                if (this.patientSearchView.selectedPatient.ID_Patient > 0)
                {
                    try
                    {
                        patientModel.ListToDelete.Add(this.patientSearchView.selectedPatient);
                        PatientList.Remove(this.patientSearchView.selectedPatient);
                        this.patientSearchView.DataSourcePatients = PatientList;
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                    }

                }
                else         //значит мы решили удалить нового пациента,который добавлен в гридвью но еще не в базу
                {
                    for (int i = 0; i < patientModel.ListToAdd.Count; i++)
                    {
                        if (patientModel.ListToAdd[i].Equals(this.patientSearchView.selectedPatient))
                        {
                            patientModel.ListToAdd.Remove(patientModel.ListToAdd[i]);
                        }
                    }

                    for (int i = 0; i < PatientList.Count; i++)
                    {
                        if (PatientList[i].Equals(this.patientSearchView.selectedPatient))
                        {
                            PatientList.Remove(PatientList[i]);
                        }
                    }
                    this.patientSearchView.DataSourcePatients = PatientList;
                }
            }
        }


        private void SaveDataEventHandler(object sender, EventArgs args)
        {
            patientModel.SaveDataOfPatient();
            MessageBox.Show("Data saved");
        }

        private void ShowPatientDataEventHandler(object sender, PatientDataInfoEventArgs args)
        {

            //прямое обращение из презентера к контролам формы и их методам
            //презентер связан с класом формы - нужно развязать интерфейсом (как вариант расширить EventArgs и передать форму через них)
            //PatientDataInfoForm pdiForm = new PatientDataInfoForm();
            //pdiForm.Text= "Detailed data of patient";

            //pdiForm.patientSearchExtendForm1.PatientData = this.patientSearchView.selectedPatient;
            //pdiForm.patientSearchExtendForm1.GenderDataSource = genderModel.ListGender;

            //GetRelativesOfPatientFromModel(this.patientSearchView.selectedPatient);
            //pdiForm.patientSearchExtendForm1.RelativeDataSource = patientModel.Patient.RelativeList;
            //// :(
            //GridView gridViewRelatives = pdiForm.patientSearchExtendForm1.gridControl1.MainView as GridView;
            //gridViewRelatives.OptionsView.ShowViewCaption = true;
            //gridViewRelatives.ViewCaption = "Relatives";
            //gridViewRelatives.Columns["ID_Relative"].Visible = false;
            //gridViewRelatives.Columns["ID_Patient"].Visible = false;
            //gridViewRelatives.Columns["ID_Gender"].Visible = false;
            //gridViewRelatives.Columns["Status"].Visible = false;

            //pdiForm.patientSearchExtendForm1.buttonCancel.Hide();
            //pdiForm.patientSearchExtendForm1.buttonOK.Hide();

            //DialogResult res =pdiForm.ShowDialog();
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
            //patientModel.DeletePatient();
        }

        private void GetRelativesOfPatientFromModel(PatientClient ptnt)
        {
            patientModel.GetRelativesOfPatient(ptnt);
        }

        private void ShowOrdersEventHandler(object sender, EventArgs args)
        {
            OrdersReport OrdRep = new OrdersReport();
            OrdRep.Text = "Orders of the patient";

            OrdRep.ShowDialog();
        }

    }
}
