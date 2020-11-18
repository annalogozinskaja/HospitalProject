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

namespace ClientHospitalApp
{
    public partial class PatientDetail : UserControl
    {
        Patient patientData;
        public Patient PatientData
        {
            get { return getPatientData(); }
            set { setPatientData(value); }
        }
        public List<Gender> DataSourceGender
        {
            set { lookUpEditGender.Properties.DataSource = value; }
            get { return (List<Gender>)lookUpEditGender.Properties.DataSource; }
        }


        public PatientDetail()
        {
            InitializeComponent();
            patientData = new Patient();
            FillLookUpEditGender();
        }
     
        void setPatientData(Patient patientData)
        {
            textEditIdPatient.Text = patientData.ID_Patient.ToString();
            textEditLnm.Text = patientData.Lastname;
            textEditFnm.Text = patientData.Firstname;
            dateEditDOB.Text = patientData.DOB.ToString();
            textEditSSN.Text = patientData.SSN.ToString();
            lookUpEditGender.EditValue = patientData.Gender.ID_Gender;
        }

        Patient getPatientData()
        {
            if (textEditIdPatient.Text != "")
            {
                patientData.ID_Patient = Convert.ToInt32(textEditIdPatient.Text);
            }
            patientData.Lastname = textEditLnm.Text;
            patientData.Firstname = textEditFnm.Text;
            patientData.DOB = Convert.ToDateTime(dateEditDOB.Text);
            patientData.SSN = Convert.ToInt32(textEditSSN.Text);
            patientData.Gender = new Gender { ID_Gender = Convert.ToInt32(lookUpEditGender.EditValue), GenderName = lookUpEditGender.Text };

            return patientData;
        }


        private void FillLookUpEditGender()
        {
            //lookUpEditGender.Properties.DataSource = gl;
            lookUpEditGender.Properties.DisplayMember = "GenderName";
            lookUpEditGender.Properties.ValueMember = "ID_Gender";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GenderName", "Gender", 100);
            lookUpEditGender.Properties.Columns.Add(col);
            lookUpEditGender.Properties.NullText = "--choose gender--";
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
