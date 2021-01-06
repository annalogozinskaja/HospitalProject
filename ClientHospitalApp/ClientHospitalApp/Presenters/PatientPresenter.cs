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
using System.ComponentModel.DataAnnotations;

namespace ClientHospitalApp.Presenters
{
    public class PatientPresenter
    {
        private IPatientModel patientModel;
        private IGenderModel genderModel;
        IPatientSearchForm patientSearchView;
        bool EditClicked = false;

        public PatientPresenter(IPatientSearchForm patientSearchView, IPatientModel model,IGenderModel modelGender)
        {
            this.patientSearchView = patientSearchView;
            this.patientModel = model;
            this.genderModel = modelGender;
            genderModel.GetGender();
            this.patientSearchView.DataSourceGender = genderModel.ListGender;

            this.patientSearchView.LoadDataDataEvent += GetAllPatientsFromModelEventHandler;
            this.patientSearchView.PatientDetailData.AddOrUpdatePatientEvent += AddOrUpdatePatientEventHandler;
            this.patientSearchView.EditPatientEvent += EditPatientEventHandler;
            this.patientSearchView.DeletePatientEvent += DeletePatientEventHandler;
            this.patientSearchView.SaveDataToModelEvent += SaveDataToModelEventHandler;
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
            this.patientModel.GetAllPatients();
            this.patientSearchView.DataSourcePatients = this.patientModel.PatientList;
        }
     
        private void AddOrUpdatePatientEventHandler(object sender, EventArgs args)
        {
            PatientClient tempPatient = this.patientSearchView.PatientDetailData.PatientData;

            bool flag = ValidatePatient(tempPatient);

            if (flag)
            {
                if (!EditClicked)
                {
                    this.patientModel.PatientList.Add(tempPatient);
                    this.patientSearchView.PatientDetailData.ClearAllData();
                }
                else
                {
                    if (this.patientSearchView.selectedPatient.ID_Patient <= 0)
                    {
                        this.patientModel.Patient = this.patientSearchView.selectedPatient;
                    }
                    for (int i = 0; i < this.patientModel.PatientList.Count; i++)
                    {
                        if (this.patientModel.PatientList[i].Equals(this.patientSearchView.selectedPatient))
                        {
                            this.patientModel.PatientList[i] = tempPatient;
                        }
                    }

                    this.patientSearchView.PatientDetailData.ClearAllData();
                    EditClicked = false;
                }
            }
        }

        private void EditPatientEventHandler(object sender, EventArgs args)
        {
            EditClicked = true;
            
            foreach (PatientClient item in this.patientModel.PatientList)
            {
                if (item.Equals(this.patientSearchView.selectedPatient))
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
                this.patientModel.Patient = this.patientSearchView.selectedPatient;
                this.patientModel.PatientList.Remove(this.patientSearchView.selectedPatient);
            }
        }


        private void SaveDataToModelEventHandler(object sender, EventArgs args)
        {
            patientModel.SaveDataOfPatient();
            MessageBox.Show("Data saved");
        }

        private void ShowPatientDataEventHandler(object sender, PatientDataInfoEventArgs args)
        {
            args.patientDataInfoForm.patientSearchExtendForm.PatientData = this.patientSearchView.selectedPatient;
            args.patientDataInfoForm.patientSearchExtendForm.DataSourceGender = genderModel.ListGender;
            GetRelativesOfPatientFromModel(this.patientSearchView.selectedPatient);
            args.patientDataInfoForm.patientSearchExtendForm.RelativeDataSource = patientModel.Patient.RelativeList;
            args.patientDataInfoForm.ApplyOptionsForGridViewRelatives();
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

        public bool ValidatePatient(PatientClient patientForCheck)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(patientForCheck);
            bool flag = Validator.TryValidateObject(patientForCheck, context, results, true);
            if (!flag)
            {
                foreach (ValidationResult error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                MessageBox.Show(results.Count.ToString());
            }
            else
            {
                MessageBox.Show("All data patient is OK");
            }

            return flag;
        }

    }
}
