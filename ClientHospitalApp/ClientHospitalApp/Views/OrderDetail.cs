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
    public partial class OrderDetail : UserControl, IOrderDetail
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
                dateEditDateOrder.Text = Convert.ToString(order.DateOrder);
                textEditSymptoms.Text = order.Symptoms;

                if (order.Doctor != null)
                {
                    DataDoctor = order.Doctor;
                }

                if (order.OrderStatus != null)
                {
                    DataOrderStatus = order.OrderStatus;
                }
            }
        }

        OrderOfPatientClient getOrder()
        {
            if (textEditID.Text != "")
            {
                order.ID_Order = Convert.ToInt32(textEditID.Text);
            }
            DateTime dateOrder = new DateTime();
            DateTime.TryParse(dateEditDateOrder.Text, out dateOrder);
            order.DateOrder = dateOrder;
            order.Symptoms = textEditSymptoms.Text;
            order.Patient = DataPatient;
            order.Doctor = DataDoctor;
            order.OrderStatus = DataOrderStatus;

            return order;
        }


        public void ClearAllData()
        {
            order = new OrderOfPatientClient();

            textEditID.Text = "";
            dateEditDateOrder.Text = "";
            textEditSymptoms.Text = "";
            patientLookUpEdit.lookUpEditPatient.EditValue = 0;
            doctorLookUpEdit.lookUpEditDoctor.EditValue = 0;
            orderStatusLookUpEdit.lookUpEditOrderStatus.EditValue = 0;

            buttonOK.Text = "Add";
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            AddOrUpdateOrderEvent(this, EventArgs.Empty);
            buttonOK.Text = "Add";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

    }
}
