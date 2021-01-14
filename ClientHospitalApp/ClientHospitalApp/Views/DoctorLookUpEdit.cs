using ClientHospitalApp.ServiceReferenceDAOLayer;
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
    public partial class DoctorLookUpEdit : UserControl, IDoctorLookUpEdit
    {
        Doctor doctor;
        public Doctor Doctor
        {
            get { return getDoctor(); }
            set { setDoctor(value); }
        }

        public List<Doctor> DoctorDataSource
        {
            set { lookUpEditDoctor.Properties.DataSource = value; }
            get { return (List<Doctor>)lookUpEditDoctor.Properties.DataSource; }
        }
        public DoctorLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditDoctor();
        }

        void setDoctor(Doctor doctor)
        {
            if (doctor != null)
            {
                lookUpEditDoctor.EditValue = doctor.ID_Doctor;
            }
        }

        Doctor getDoctor()
        {
            doctor = (Doctor)lookUpEditDoctor.GetSelectedDataRow();
            return doctor;
        }

        private void FillLookUpEditDoctor()
        {
            lookUpEditDoctor.Properties.DisplayMember = "Lastname";
            lookUpEditDoctor.Properties.ValueMember = "ID_Doctor";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Lastname", "Doctor", 100);
            lookUpEditDoctor.Properties.Columns.Add(col);
            lookUpEditDoctor.Properties.NullText = "--choose doctor--";
        }

    }
}
