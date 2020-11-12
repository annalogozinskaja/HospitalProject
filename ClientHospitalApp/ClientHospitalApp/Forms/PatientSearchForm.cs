using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp
{
    //[PatientValidation]
    public partial class PatientSearchForm : Form, IPatient
    {
        Patient patientData;
        public PatientSearchForm()
        {
            InitializeComponent();
            patientData = new Patient();
        }

        /*      public string ID_PatientText
              {
                  get { return textEditIdPatient.Text; }
                  set { textEditIdPatient.Text = value; }
              }

              public string LastnameText 
              {
                  get { return textEditLnm.Text; }
                  set { textEditLnm.Text = value; } 
              }

              public string FirstnameText
              {
                  get { return textEditFnm.Text; }
                  set { textEditFnm.Text = value; }
              }

              public string DOBText 
              {
                  get { return dateEditDOB.Text; }
                  set { dateEditDOB.Text = value; }
              }

              public string SSNText
              {
                  get { return textEditSSN.Text; }
                  set { textEditSSN.Text = value; }
              }*/
              //public string ID_GenderText { get; set; }

        void setPatientData(Patient patientData)
        {
            textEditIdPatient.Text = patientData.ID_Patient.ToString();
            textEditLnm.Text = patientData.Lastname;
            textEditFnm.Text = patientData.Firstname;
            dateEditDOB.Text = patientData.DOB.ToString();
            textEditSSN.Text = patientData.SSN.ToString();
            comboBoxEditGndr.Properties.Items.Add(patientData.Gender.GenderName);
           
        }

        Patient getPatientData()
        {
            if(textEditIdPatient.Text!="")
            {
                patientData.ID_Patient = Convert.ToInt32(textEditIdPatient.Text);
            }          
            patientData.Lastname = textEditLnm.Text;
            patientData.Firstname = textEditFnm.Text;
            patientData.DOB = Convert.ToDateTime(dateEditDOB.Text);
            patientData.SSN = Convert.ToInt32(textEditSSN.Text);
            //patientData.Gender= (Gender)comboBoxEditGndr.SelectedItem;
           
            return patientData;
        }

        public Patient PatientData 
        {
            get { return getPatientData(); }
            set { setPatientData(value); } 
        }

        private void textEditLnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.OemMinus)
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
    }
}
