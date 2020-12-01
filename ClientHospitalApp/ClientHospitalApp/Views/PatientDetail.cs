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
        Patient patientData;
        public Patient PatientData
        {
            get { return getPatientData(); }
            set { setPatientData(value); }
        }
        public List<GenderClient> GenderDataSource
        {
            set { lookUpEditGender.Properties.DataSource = value; }
            get { return (List<GenderClient>)lookUpEditGender.Properties.DataSource; }
        }
        public event EventHandler AddOrUpdatePatientEvent;


        public PatientDetail()
        {
            InitializeComponent();
            patientData = new Patient();
            FillLookUpEditGender();
        }
     
        void setPatientData(Patient patientData)
        {
            try
            {
                if (patientData != null)
                { 
                    textEditIdPatient.Text = Convert.ToString(patientData.ID_Patient);
                    textEditLnm.Text = patientData.Lastname;
                    textEditFnm.Text = patientData.Firstname;
                    dateEditDOB.Text = Convert.ToString(patientData.DOB);
                    textEditSSN.Text = patientData.SSN.ToString();
                    lookUpEditGender.EditValue = patientData.Gender;
                }              
            }
            catch(Exception e) {}
        }

        Patient getPatientData()
        {
                if (textEditIdPatient.Text != "")
                {
                    patientData.ID_Patient = Convert.ToInt32(textEditIdPatient.Text);
                }
                patientData.Lastname = textEditLnm.Text;
                patientData.Firstname = textEditFnm.Text;
                //patientData.DOB = Convert.ToDateTime(dateEditDOB.Text);
                int ssn = -1;
                Int32.TryParse(textEditSSN.Text,out ssn);
                patientData.SSN = ssn;
            //patientData.Gender = new Gender { ID_Gender = Convert.ToInt32(lookUpEditGender.EditValue), GenderName = lookUpEditGender.Text };
            //patientData.Gender = (Gender)lookUpEditGender.EditValue;
                patientData.Gender = (Gender)lookUpEditGender.Properties.GetDataSourceRowByKeyValue(lookUpEditGender.EditValue);

                return patientData;
        }


        private void FillLookUpEditGender()
        {
            lookUpEditGender.Properties.DisplayMember = "GenderClient";
            lookUpEditGender.Properties.ValueMember = "GenderClient";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GenderClient", "GenderClient", 100);
            lookUpEditGender.Properties.Columns.Add(col);
            //lookUpEditGender.Properties.NullText = "--choose gender--";
        }

        public void ClearAllData()
        {
            /*   patientData.ID_Patient = -1;
               patientData.Lastname = "";
               patientData.Firstname = "";
               patientData.DOB = new DateTime();
               patientData.SSN = -1;
               patientData.Gender = new Gender();*/
            patientData = new Patient();

            textEditIdPatient.Text = "";
            textEditLnm.Text = "";
            textEditFnm.Text = "";
            dateEditDOB.Text = "";
            textEditSSN.Text = "";
            lookUpEditGender.EditValue =0;
        }

        private void textEditLnm_KeyPress(object sender, KeyPressEventArgs e)
        {            char number = e.KeyChar;

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

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AddOrUpdatePatientEvent(this, EventArgs.Empty);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }
    }
}
