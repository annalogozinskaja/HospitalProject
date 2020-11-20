using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.ServiceReferenceDAOLayer;

namespace ClientHospitalApp.Views
{
    //[PatientValidation]
    public partial class PatientSearchForm : Form
    {
        Patient dataPatient;
        public Patient DataPatient
        {
            get { return getPatientData(); }
            set { setPatientData(); }
        }
        public PatientSearchForm()
        {
            InitializeComponent();
            dataPatient = new Patient();
        }

        void setPatientData()
        {
            dataPatient = patientDetail1.PatientData;
            //dataPatient = patientData;
        }

        Patient getPatientData()
        {
            patientDetail1.PatientData = dataPatient;
            return dataPatient;
        }

    }
}
