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
    public partial class SpecimentNameLookUpEdit : UserControl, ISpecimentNameView
    {
        Speciment specimentName;
        public Speciment SpecimentName
        {
            get { return getSpecimentName(); }
            set { setSpecimentName(value); }
        }

        public List<Speciment> SpecimentNameDataSource
        {
            set { lookUpEditSpecimentName.Properties.DataSource = value; }
            get { return (List<Speciment>)lookUpEditSpecimentName.Properties.DataSource; }
        }
        public SpecimentNameLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditSpecimentName();
        }

        void setSpecimentName(Speciment specimentName)
        {
            if (specimentName != null)
            {
                lookUpEditSpecimentName.EditValue = specimentName.ID_Speciment;
            }
        }

        Speciment getSpecimentName()
        {
            specimentName = (Speciment)lookUpEditSpecimentName.GetSelectedDataRow();
            return specimentName;
        }

        private void FillLookUpEditSpecimentName()
        {
            lookUpEditSpecimentName.Properties.DisplayMember = "SpecimentName";
            lookUpEditSpecimentName.Properties.ValueMember = "ID_Speciment";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SpecimentName", "Speciment", 100);
            lookUpEditSpecimentName.Properties.Columns.Add(col);
            lookUpEditSpecimentName.Properties.NullText = "--choose type--";
        }
    }
}
