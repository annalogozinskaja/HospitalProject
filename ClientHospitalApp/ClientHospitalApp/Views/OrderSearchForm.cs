using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
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
    public partial class OrderSearchForm : Form, IOrderSearchForm
    {
        public BindingList<OrderOfPatientClient> DataSourceOrders
        {
            set
            {
                gridControlOrders.DataSource = value;
                gridControlOrders.RefreshDataSource();
            }
            get { return (BindingList<OrderOfPatientClient>)gridControlOrders.DataSource; }
        }
        public List<PatientClient> DataSourcePatient
        {
            set { orderDetail.DataSourcePatient = value; }
            get { return (List<PatientClient>)orderDetail.DataSourcePatient; }
        }
        public List<Doctor> DataSourceDoctor
        {
            set { orderDetail.DataSourceDoctor = value; }
            get { return (List<Doctor>)orderDetail.DataSourceDoctor; }
        }
        public List<OrderStatus> DataSourceOrderStatus
        {
            set { orderDetail.DataSourceOrderStatus = value; }
            get { return (List<OrderStatus>)orderDetail.DataSourceOrderStatus; }
        }

        MainForm mainForm;
        public OrderOfPatientClient selectedOrder { get; set; }

        public event EventHandler LoadDataDataEvent;
        public event EventHandler EditOrderEvent;
        public event EventHandler DeleteOrderEvent;
        public event EventHandler SaveDataToModelEvent;

        public OrderDetail OrderDetailData
        {
            set { orderDetail = value; }
            get { return orderDetail; }
        }
        public OrderSearchForm()
        {
            InitializeComponent();
        }

        private void CreateGridControl()
        {
            this.gridView1.Columns[0].Caption = "ID";

            //this.gridView1.Columns[4].Caption = "Order";

            this.gridView1.Columns[1].FieldName = "Patient.Lastname";
            this.gridView1.Columns[4].FieldName = "Doctor.Lastname";
            this.gridView1.Columns[5].FieldName = "OrderStatus.OrderName";
            //this.gridView1.Columns[6].Visible = false;

            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.ExpandAllGroups();
            this.gridView1.OptionsSelection.MultiSelect = false;
            this.gridView1.OptionsBehavior.Editable = true;  //когда false- не вызывается buttonclick на edit и delete          
            this.gridView1.Columns[1].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[2].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[3].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[4].OptionsColumn.AllowEdit = false;
            this.gridView1.Columns[5].OptionsColumn.AllowEdit = false;

            this.gridView1.Columns[0].Width = 5;
            this.gridView1.Columns[1].Width = 135;
            this.gridView1.Columns[2].Width = 120;
            this.gridView1.Columns[3].Width = 100;
            this.gridView1.Columns[4].Width = 70;

            GridColumn unbColumnEdit = gridView1.Columns.AddField("Edit");
            unbColumnEdit.VisibleIndex = gridView1.Columns.Count;
            unbColumnEdit.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            unbColumnEdit.Width = 45;

            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            edit.ButtonClick += edit_ButtonClick;
            edit.Buttons[0].Caption = "Edit";
            edit.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            edit.Buttons[0].ImageOptions.Image = ClientHospitalApp.Properties.Resources.editcontact_16x16;
            this.gridView1.Columns["Edit"].ColumnEdit = edit;

            GridColumn unbColumnDel = gridView1.Columns.AddField("Delete");
            unbColumnDel.VisibleIndex = gridView1.Columns.Count;
            unbColumnDel.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            unbColumnDel.Width = 45;

            RepositoryItemButtonEdit delete = new RepositoryItemButtonEdit();
            delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            delete.Click += new System.EventHandler(delete_ButtonClick);
            delete.Buttons[0].Caption = "Delete";
            delete.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            delete.Buttons[0].ImageOptions.Image = ClientHospitalApp.Properties.Resources.cancel_16x16;
            this.gridView1.Columns["Delete"].ColumnEdit = delete;
        }
        private void SaveDataEventHandler(object sender, EventArgs args)
        {
            SaveDataToModelEvent(this, EventArgs.Empty);
        }

        private void edit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            GetSelectedOrder(1);
            OrderDetailData.buttonOK.Text = "Update";
        }

        void delete_ButtonClick(object sender, EventArgs args)
        {
            GetSelectedOrder(2);
        }

        private void GetSelectedOrder(int numberOfMethod)
        {
            int[] selectedRowHandles = this.gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                OrderOfPatientClient order = gridView1.GetRow(selectedRowHandles[0]) as OrderOfPatientClient;
                if (order == null)
                {
                    MessageBox.Show("Selected order is null");
                }
                else
                {
                    selectedOrder = order;
                }

                if (numberOfMethod == 1)
                {
                    EditOrderEvent(this, EventArgs.Empty);
                }
                else
                {
                    DeleteOrderEvent(this, EventArgs.Empty);
                }
            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose order");
            }
        }

        private void OrderSearchForm_Load(object sender, EventArgs e)
        {
            LoadDataDataEvent(this, EventArgs.Empty);
            this.mainForm = ((OrderSearchForm)(this)).MdiParent as MainForm;
            this.mainForm.SaveDataEvent += SaveDataEventHandler;
            CreateGridControl();
        }
    }
}
