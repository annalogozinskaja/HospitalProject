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
    public partial class SpecimentStatusLookUpEdit : UserControl, ISpecimentStatusView
    {
        SpecimentStatus specimentStatus;
        public SpecimentStatus SpecimentStatus
        {
            get { return getSpecimentStatus(); }
            set { setSpecimentStatus(value); }
        }

        public List<SpecimentStatus> SpecimentNameDataSource
        {
            set { lookUpEditSpecimentStatus.Properties.DataSource = value; }
            get { return (List<SpecimentStatus>)lookUpEditSpecimentStatus.Properties.DataSource; }
        }

        public SpecimentStatusLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditSpecimentStatus();
        }

        void setSpecimentStatus(SpecimentStatus specimentStatus)
        {
            if (specimentStatus != null)
            {
                lookUpEditSpecimentStatus.EditValue = specimentStatus.ID_SpecimentStatus;
            }
        }

        SpecimentStatus getSpecimentStatus()
        {
            specimentStatus = (SpecimentStatus)lookUpEditSpecimentStatus.GetSelectedDataRow();
            return specimentStatus;
        }

        private void FillLookUpEditSpecimentStatus()
        {
            lookUpEditSpecimentStatus.Properties.DisplayMember = "SpecimentStatusName";
            lookUpEditSpecimentStatus.Properties.ValueMember = "ID_SpecimentStatus";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SpecimentStatusName", "SpecimentStatus", 100);
            lookUpEditSpecimentStatus.Properties.Columns.Add(col);
            lookUpEditSpecimentStatus.Properties.NullText = "--choose type--";
        }
    }
}
