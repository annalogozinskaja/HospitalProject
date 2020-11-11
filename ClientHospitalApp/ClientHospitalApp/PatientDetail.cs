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

namespace ClientHospitalApp
{
    public partial class PatientDetail : UserControl
    {
        Patient patientData;
        public PatientDetail()
        {
            InitializeComponent();
        }
        public Patient PatientData
        {
            get { return getPatientData(); }
            set { setPatientData(value); }
        }
        void setPatientData(Patient patientData)
        {
            textEditIdPatient.Text = patientData.ID_Patient.ToString();
            textEditLnm.Text = patientData.Lastname;
            textEditFnm.Text = patientData.Firstname;
            //TO DO: add other fields
        }

        Patient getPatientData()
        {
            patientData.ID_Patient = Convert.ToInt32(textEditIdPatient.Text);
            patientData.Lastname = textEditLnm.Text;
            patientData.Firstname = textEditFnm.Text;
            //TO DO: add other fields
            return patientData;
        }
    }
}
