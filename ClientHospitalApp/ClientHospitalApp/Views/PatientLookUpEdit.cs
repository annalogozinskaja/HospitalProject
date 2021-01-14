using ClientHospitalApp.ClientEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp.Views
{
    public partial class PatientLookUpEdit : UserControl, IPatientLookUpEdit
    {
        PatientClient patient;
        public PatientClient Patient
        {
            get { return getPatient(); }
            set { setPatient(value); }
        }

        public List<PatientClient> PatientDataSource
        {
            set { lookUpEditPatient.Properties.DataSource = value; }
            get { return (List<PatientClient>)lookUpEditPatient.Properties.DataSource; }
        }
        public PatientLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditPatient();
        }

        void setPatient(PatientClient patient)
        {
            if (patient != null)
            {
                lookUpEditPatient.EditValue = patient.ID_Patient;
            }
        }

        PatientClient getPatient()
        {
            patient = (PatientClient)lookUpEditPatient.GetSelectedDataRow();
            return patient;
        }

        private void FillLookUpEditPatient()
        {
            lookUpEditPatient.Properties.DisplayMember = "Lastname";
            lookUpEditPatient.Properties.ValueMember = "ID_Patient";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lastname", "PatientClient", 100);
            lookUpEditPatient.Properties.Columns.Add(col);
            lookUpEditPatient.Properties.NullText = "--choose patient--";
        }
    }
}
