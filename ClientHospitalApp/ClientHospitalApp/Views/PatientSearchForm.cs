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
    public partial class PatientSearchForm : Form, IPatientView
    {
        Patient dataPatient;
        public Patient DataPatient
        {
            get { return getPatientData(); }
            set { setPatientData(value); }
        }

        public PatientSearchForm()
        {
            InitializeComponent();
            dataPatient = new Patient();
        }

        void setPatientData(Patient patientData)
        {
            patientDetail1.PatientData=dataPatient;
        }

        Patient getPatientData()
        {
            dataPatient = patientDetail1.PatientData;
            return dataPatient;
        }

    }
}
