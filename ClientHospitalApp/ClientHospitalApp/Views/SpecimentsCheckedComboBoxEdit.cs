using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraEditors.Controls;
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
        List<int> speciments;
        public List<int> Speciments
        {
            get { return getSpeciments(); }
            set { setSpeciments(value); }
        }

        public List<SpecimentsInOrderClient> SpecimentDataSource
        {
            set { checkedComboBoxEditSpeciment.Properties.DataSource = value; }
            get { return (List<SpecimentsInOrderClient>)checkedComboBoxEditSpeciment.Properties.DataSource; }
        }

        public SpecimentsCheckedComboBoxEdit()
        {
            InitializeComponent();
            speciments = new List<int>();
            FillCheckedComboBoxEditSpeciment();
        }

        void setSpeciments(List<int> speciments)
        {
            if (speciments != null)
            {
                checkedComboBoxEditSpeciment.EditValue = speciments;
            }
        }

        List<int> getSpeciments()
        {
            foreach (CheckedListBoxItem item in checkedComboBoxEditSpeciment.Properties.GetItems())
            {
                if (item.CheckState == CheckState.Checked) 
                {
                    speciments.Add((int)item.Value); 
                }
            }

            List<SpecimentsInOrderClient> lsp = new List<SpecimentsInOrderClient>();

            checkedComboBoxEditSpeciment.Properties.GetItems().GetCheckedValues().ForEach( n=> lsp.Add((SpecimentsInOrderClient)n ));
            MessageBox.Show("GetCheckedItems:" + checkedComboBoxEditSpeciment.Properties.GetCheckedItems().ToString());
           
            return speciments;
        }

        private void FillCheckedComboBoxEditSpeciment()
        {
            checkedComboBoxEditSpeciment.Properties.DisplayMember = "ID_SpecimentOrder";
            checkedComboBoxEditSpeciment.Properties.ValueMember = "ID_SpecimentOrder";
            checkedComboBoxEditSpeciment.Properties.NullText = "--choose type--";
        }
    }
}
