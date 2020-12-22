using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp
{
    public partial class GenderLookUpEdit : UserControl, IGenderView
    {
        Gender genderData;
        public Gender GenderData
        {
            get { return getGenderData(); }
            set { setGenderData(value); }
        }

        public List<Gender> GenderDataSource
        {
            set { lookUpEditGender.Properties.DataSource = value; }
            get { return (List<Gender>)lookUpEditGender.Properties.DataSource; }
        }
        public GenderLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditGender();
        }

        void setGenderData(Gender genderData)
        {
            if (genderData != null)
            {
                lookUpEditGender.EditValue = genderData.ID_Gender;
            }
        }

        Gender getGenderData()
        {
            genderData = (Gender)lookUpEditGender.GetSelectedDataRow();
            return genderData;
        }

        private void FillLookUpEditGender()
        {
            lookUpEditGender.Properties.DisplayMember = "GenderName";
            lookUpEditGender.Properties.ValueMember = "ID_Gender";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GenderName", "Gender", 100);
            lookUpEditGender.Properties.Columns.Add(col);
            lookUpEditGender.Properties.NullText = "--choose gender--";
        }

        private void lookUpEditGender_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
