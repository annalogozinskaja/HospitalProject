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
    public partial class OrderStatusLookUpEdit : UserControl, IOrderStatusLookUpEdit
    {
        OrderStatus orderStatus;
        public OrderStatus OrderStatus
        {
            get { return getOrderStatus(); }
            set { setOrderStatus(value); }
        }

        public List<OrderStatus> OrderStatusDataSource
        {
            set { lookUpEditOrderStatus.Properties.DataSource = value; }
            get { return (List<OrderStatus>)lookUpEditOrderStatus.Properties.DataSource; }
        }

        public OrderStatusLookUpEdit()
        {
            InitializeComponent();
            FillLookUpEditOrderStatus();
        }

        void setOrderStatus(OrderStatus orderStatus)
        {
            if (orderStatus != null)
            {
                lookUpEditOrderStatus.EditValue = orderStatus.ID_OrderStatus;
            }
        }

        OrderStatus getOrderStatus()
        {
            orderStatus = (OrderStatus)lookUpEditOrderStatus.GetSelectedDataRow();
            return orderStatus;
        }

        private void FillLookUpEditOrderStatus()
        {
            lookUpEditOrderStatus.Properties.DisplayMember = "OrderName";
            lookUpEditOrderStatus.Properties.ValueMember = "ID_OrderStatus";
            DevExpress.XtraEditors.Controls.LookUpColumnInfo col;
            col = new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrderName", "OrderStatus", 100);
            lookUpEditOrderStatus.Properties.Columns.Add(col);
            lookUpEditOrderStatus.Properties.NullText = "--choose status--";
        }
    }
}
