using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using ClientHospitalApp.ClientEntities;

namespace ClientHospitalApp
{
    public partial class PatientDetail : UserControl,IPatientView
    {
        PatientClient patientData;
        public PatientClient PatientData
        {
            get { return getPatientData(); }
            set { setPatientData(value); }
        }
        
        public Gender DataGender
        {
            set { genderLookUpEdit1.GenderData = value; }
            get { return genderLookUpEdit1.GenderData; }
        }
        public List<Gender> DataSourceGender
        {
            set { genderLookUpEdit1.GenderDataSource = value; }
            get { return (List<Gender>)genderLookUpEdit1.GenderDataSource; }
        }
        public event EventHandler AddOrUpdatePatientEvent;


        public PatientDetail()
        {
            InitializeComponent();
            patientData = new PatientClient();          
        }
     
        void setPatientData(PatientClient patientData)
        {
            if (patientData != null)
            {
                textEditIdPatient.Text = Convert.ToString(patientData.ID_Patient);
                textEditLnm.Text = patientData.Lastname;
                textEditFnm.Text = patientData.Firstname;
                dateEditDOB.Text = Convert.ToString(patientData.DOB);
                textEditSSN.Text = patientData.SSN.ToString();

                if (patientData.Gender != null)
                {
                    DataGender = patientData.Gender;
                }
             }
        }

        PatientClient getPatientData()
        {
            if (textEditIdPatient.Text != "")
            {
                patientData.ID_Patient = Convert.ToInt32(textEditIdPatient.Text);
            }
            patientData.Lastname = textEditLnm.Text;
            patientData.Firstname = textEditFnm.Text;
            DateTime dob = new DateTime();
            DateTime.TryParse(dateEditDOB.Text,out dob);
            patientData.DOB = dob;
            int ssn = -1;
            Int32.TryParse(textEditSSN.Text,out ssn);
            patientData.SSN = ssn;
            patientData.Gender = DataGender;
            
            return patientData;
        }


        public void ClearAllData()
        {
            patientData = new PatientClient();

            textEditIdPatient.Text = "";
            textEditLnm.Text = "";
            textEditFnm.Text = "";
            dateEditDOB.Text = "";
            textEditSSN.Text = "";
            genderLookUpEdit1.lookUpEditGender.EditValue = 0;
            buttonOK.Text = "Add";
        }

        private void textEditLnm_KeyPress(object sender, KeyPressEventArgs e)
        {            char number = e.KeyChar;

            if (!Char.IsLetter(number) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void textEditSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AddOrUpdatePatientEvent(this, EventArgs.Empty);
            buttonOK.Text = "Add";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }
    }
}
