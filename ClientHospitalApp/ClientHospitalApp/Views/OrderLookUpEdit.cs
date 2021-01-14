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
    public partial class OrderLookUpEdit : UserControl,IOrderView
    {
        OrderOfPatientClient order;
        public OrderOfPatientClient Order
        {
            get { return getOrder(); }
            set { setOrder(value); }
        }

        public List<OrderOfPatientClient> OrderDataSource
        {
            set { lookUpEditOrder.Properties.DataSource = value; }
            get { return (List<OrderOfPatientClient>)lookUpEditOrder.Properties.DataSource; }
        }

        public OrderLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditOrder();
        }

        void setOrder(OrderOfPatientClient order)
        {
            if (order != null)
            {
                lookUpEditOrder.EditValue = order.ID_Order;
            }
        }

        OrderOfPatientClient getOrder()
        {
            order = (OrderOfPatientClient)lookUpEditOrder.GetSelectedDataRow();
            return order;
        }

        private void FillLookUpEditOrder()
        {
            lookUpEditOrder.Properties.DisplayMember = "ID_Order";
            lookUpEditOrder.Properties.ValueMember = "ID_Order";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Order", "OrderOfPatientClient", 100);
            lookUpEditOrder.Properties.Columns.Add(col);
            lookUpEditOrder.Properties.NullText = "--choose type--";
        }
    }
}
