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
    public partial class OrderDetail : UserControl
    {
        OrderOfPatientClient order;
        public OrderOfPatientClient Order
        {
            get { return getOrder(); }
            set { setOrder(value); }
        }

        public PatientClient DataPatient
        {
            set { patientLookUpEdit.Patient = value; }
            get { return patientLookUpEdit.Patient; }
        }
        public List<PatientClient> DataSourcePatient
        {
            set { patientLookUpEdit.PatientDataSource = value; }
            get { return (List<PatientClient>)patientLookUpEdit.PatientDataSource; }
        }

        public Doctor DataDoctor
        {
            set { doctorLookUpEdit.Doctor = value; }
            get { return doctorLookUpEdit.Doctor; }
        }
        public List<Doctor> DataSourceDoctor
        {
            set { doctorLookUpEdit.DoctorDataSource = value; }
            get { return (List<Doctor>)doctorLookUpEdit.DoctorDataSource; }
        }

        public OrderStatus DataOrderStatus
        {
            set { orderStatusLookUpEdit.OrderStatus = value; }
            get { return orderStatusLookUpEdit.OrderStatus; }
        }
        public List<OrderStatus> DataSourceOrderStatus
        {
            set { orderStatusLookUpEdit.OrderStatusDataSource = value; }
            get { return (List<OrderStatus>)orderStatusLookUpEdit.OrderStatusDataSource; }
        }
        public event EventHandler AddOrUpdateOrderEvent;

        public OrderDetail()
        {
            InitializeComponent();
            order = new OrderOfPatientClient();
        }


        void setOrder(OrderOfPatientClient order)
        {
            if (order != null)
            {
                textEditID.Text = Convert.ToString(order.ID_Order);

                if (order.Patient != null)
                {
                    DataPatient = order.Patient;
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

        SpecimentsInOrderClient getSpeciment()
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
            speciment = new SpecimentsInOrderClient();

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

            if (!Char.IsLetter(number) && e.KeyChar != (char)Keys.Back && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }
    }
}
