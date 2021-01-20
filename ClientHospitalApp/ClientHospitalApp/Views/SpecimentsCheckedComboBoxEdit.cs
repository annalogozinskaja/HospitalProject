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

        public List<SpecimentsInOrder> SpecimentDataSource
        {
            set { checkedComboBoxEditSpeciment.Properties.DataSource = value; }
            get { return (List<SpecimentsInOrder>)checkedComboBoxEditSpeciment.Properties.DataSource; }
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

            //checkedComboBoxEditSpeciment.Properties.GetItems().GetCheckedValues().ForEach( n=> speciments.Add((SpecimentsInOrder)n ));
            // MessageBox.Show("GetCheckedItems:" + checkedComboBoxEditSpeciment.Properties.GetCheckedItems().ToString());

            //it works for getting as a object not int
            //List<object> checkedIDs = checkedComboBoxEditSpeciment.Properties.GetItems().GetCheckedValues() as List<object>;
            //IList<SpecimentsInOrder> listSpec = checkedComboBoxEditSpeciment.Properties.DataSource as IList<SpecimentsInOrder>;

            //foreach (object checkedID in checkedIDs)
            //{
            //    speciments.Add(listSpec.FirstOrDefault(x => x.ID_SpecimentOrder == Convert.ToInt32(checkedID)));
            //}

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
