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
    public partial class SpecimentDetail : UserControl, ISpecimentView
    {
        SpecimentsInOrder speciment;
        public SpecimentsInOrder Speciment
        {
            get { return getSpeciment(); }
            set { setSpeciment(value); }
        }

        public OrderOfPatient DataOrder
        {
            set { orderLookUpEdit.Order = value; }
            get { return orderLookUpEdit.Order; }
        }
        public List<OrderOfPatient> DataSourceOrder
        {
            set { orderLookUpEdit.OrderDataSource= value; }
            get { return (List<OrderOfPatient>)orderLookUpEdit.OrderDataSource; }
        }

        public Speciment DataSpecimentName
        {
            set { specimentNameLookUpEdit.SpecimentName = value; }
            get { return specimentNameLookUpEdit.SpecimentName; }
        }
        public List<Speciment> DataSourceSpecimentName
        {
            set { specimentNameLookUpEdit.SpecimentNameDataSource = value; }
            get { return (List<Speciment>)specimentNameLookUpEdit.SpecimentNameDataSource; }
        }

        public SpecimentStatus DataSpecimentStatus
        {
            set { specimentStatusLookUpEdit.SpecimentStatus = value; }
            get { return specimentStatusLookUpEdit.SpecimentStatus; }
        }
        public List<SpecimentStatus> DataSourceSpecimentStatus
        {
            set { specimentStatusLookUpEdit.SpecimentNameDataSource = value; }
            get { return (List<SpecimentStatus>)specimentStatusLookUpEdit.SpecimentNameDataSource; }
        }
        public event EventHandler AddOrUpdateSpecimentEvent;

        public SpecimentDetail()
        {
            InitializeComponent();
            speciment = new SpecimentsInOrder();
        }


        void setSpeciment(SpecimentsInOrder speciment)
        {
            if (speciment != null)
            {
                textEditIdSpeciment.Text = Convert.ToString(speciment.ID_SpecimentOrder);

                if (speciment.Speciment != null)
                {
                    DataSpecimentName = speciment.Speciment;
                }
                dateEditDate.Text = Convert.ToString(speciment.DateOfTaking);
                textEditNurse.Text = speciment.Nurse;

                if (speciment.Order != null)
                {
                    DataOrder = speciment.Order;
                }

                if (speciment.SpecimentStatus != null)
                {
                    DataSpecimentStatus = speciment.SpecimentStatus;
                }
            }
        }

        SpecimentsInOrder getSpeciment()
        {
            if (textEditIdSpeciment.Text != "")
            {
                speciment.ID_SpecimentOrder = Convert.ToInt32(textEditIdSpeciment.Text);
            }
            speciment.Speciment = DataSpecimentName;
            DateTime date = new DateTime();
            DateTime.TryParse(dateEditDate.Text, out date);
            speciment.DateOfTaking = date;
            speciment.Nurse = textEditNurse.Text;
            speciment.Order = DataOrder;
            speciment.SpecimentStatus = DataSpecimentStatus;

            return speciment;
        }


        public void ClearAllData()
        {
            speciment = new SpecimentsInOrder();

            textEditIdSpeciment.Text = "";
            specimentNameLookUpEdit.lookUpEditSpecimentName.EditValue = 0;
            dateEditDate.Text = "";
            textEditNurse.Text = "";
            orderLookUpEdit.lookUpEditOrder.EditValue = 0;
            specimentStatusLookUpEdit.lookUpEditSpecimentStatus.EditValue = 0;
         
            buttonOK.Text = "Add";
        }

        
        private void buttonOK_Click(object sender, EventArgs e)
        {
            AddOrUpdateSpecimentEvent(this, EventArgs.Empty);
            buttonOK.Text = "Add";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void textEditNurse_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.OemMinus)
            {
                e.Handled = true;
            }
        }
    }
}
