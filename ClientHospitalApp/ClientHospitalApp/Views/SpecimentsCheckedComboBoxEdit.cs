using ClientHospitalApp.ClientEntities;
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
    public partial class SpecimentsCheckedComboBoxEdit : UserControl, ISpecimentsCheckedComboBoxEdit
    {
        SpecimentsInOrderClient speciment;
        public SpecimentsInOrderClient Speciment
        {
            get { return getSpeciment(); }
            set { setSpeciment(value); }
        }

        public List<SpecimentsInOrderClient> SpecimentDataSource
        {
            set { checkedComboBoxEditSpeciment.Properties.DataSource = value; }
            get { return (List<SpecimentsInOrderClient>)checkedComboBoxEditSpeciment.Properties.DataSource; }
        }

        public SpecimentsCheckedComboBoxEdit()
        {
            InitializeComponent();
            FillCheckedComboBoxEditSpeciment();
        }

        void setSpeciment(SpecimentsInOrderClient speciment)
        {
            if (speciment != null)
            {
                //checkedComboBoxEditSpeciment.EditValue = speciment.ID_SpecimentOrder;
            }
        }

        SpecimentsInOrderClient getSpeciment()
        {
           // speciment = (SpecimentsInOrder)checkedComboBoxEditSpeciment.Properties.GetCheckedItems();
            return speciment;
        }

        private void FillCheckedComboBoxEditSpeciment()
        {
            checkedComboBoxEditSpeciment.Properties.DisplayMember = "ID_SpecimentOrder";
            checkedComboBoxEditSpeciment.Properties.ValueMember = "ID_SpecimentOrder";
            checkedComboBoxEditSpeciment.Properties.NullText = "--choose type--";
        }
    }
}
