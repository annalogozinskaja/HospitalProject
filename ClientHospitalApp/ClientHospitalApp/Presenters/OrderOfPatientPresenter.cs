using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.Models;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp.Presenters
{
    public class OrderOfPatientPresenter
    {      
        private IOrderOfPatientModel orderModel;
        private IPatientModel patientModel;
        private IDoctorModel doctorModel;
        private IOrderStatusModel orderStatusModel;       
        IOrderSearchForm orderSearchView;
        bool EditClicked = false;

        public OrderOfPatientPresenter(IOrderSearchForm orderSearchView, IOrderOfPatientModel orderModel,
           IPatientModel patientModel, IDoctorModel doctorModel, IOrderStatusModel orderStatusModel)
        {
            this.orderSearchView = orderSearchView;
            this.orderModel = orderModel;
            this.patientModel = patientModel;
            this.doctorModel = doctorModel;
            this.orderStatusModel = orderStatusModel;

            this.patientModel.GetAllPatients();
            this.doctorModel.GetDoctors();
            this.orderStatusModel.GetOrderStatuses();
            this.orderSearchView.DataSourcePatient = this.patientModel.ListPatientsForOrder;
            this.orderSearchView.DataSourceDoctor = this.doctorModel.ListDoctors;
            this.orderSearchView.DataSourceOrderStatus = this.orderStatusModel.ListOrderStatuses;

            this.orderSearchView.LoadDataDataEvent += GetAllOrdersFromModelEventHandler;
            this.orderSearchView.OrderDetailData.AddOrUpdateOrderEvent += AddOrUpdateOrderEventHandler;
            this.orderSearchView.EditOrderEvent += EditOrderEventHandler;
            this.orderSearchView.DeleteOrderEvent += DeleteOrderEventHandler;
            this.orderSearchView.SaveDataToModelEvent += SaveDataToModelEventHandler;
        }


        private void GetAllOrdersFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllOrdersFromModel();
        }

        public void GetAllOrdersFromModel()
        {
            this.orderModel.GetAllOrders();
            this.orderSearchView.DataSourceOrders = this.orderModel.OrderList;
        }

        private void AddOrUpdateOrderEventHandler(object sender, EventArgs args)
        {
            OrderOfPatientClient tempOrder = this.orderSearchView.OrderDetailData.Order;

            bool flag = ValidateOrder(tempOrder);

            if (flag)
            {
                if (!EditClicked)
                {
                    this.orderModel.OrderList.Add(tempOrder);
                    this.orderSearchView.OrderDetailData.ClearAllData();
                }
                else
                {
                    if (this.orderSearchView.selectedOrder.ID_Order <= 0)
                    {
                        this.orderModel.Order = this.orderSearchView.selectedOrder;
                    }
                    for (int i = 0; i < this.orderModel.OrderList.Count; i++)
                    {
                        if (this.orderModel.OrderList[i].Equals(this.orderSearchView.selectedOrder))
                        {
                            this.orderModel.OrderList[i] = tempOrder;
                        }
                    }

                    this.orderSearchView.OrderDetailData.ClearAllData();
                    EditClicked = false;
                }
            }
        }

        private void EditOrderEventHandler(object sender, EventArgs args)
        {
            EditClicked = true;

            foreach (OrderOfPatientClient item in this.orderModel.OrderList)
            {
                if (item.Equals(this.orderSearchView.selectedOrder))
                {
                    this.orderSearchView.OrderDetailData.Order = item;
                }
            }
        }

        private void DeleteOrderEventHandler(object sender, EventArgs args)
        {
            DialogResult res = MessageBox.Show("Delete order of patient " + this.orderSearchView.selectedOrder.Patient.Lastname +
                                                "?", "Deleting order", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.orderModel.Order = this.orderSearchView.selectedOrder;
                this.orderModel.OrderList.Remove(this.orderSearchView.selectedOrder);
            }
        }

        private void SaveDataToModelEventHandler(object sender, EventArgs args)
        {
            orderModel.SaveDataOfOrder();
            MessageBox.Show("Data saved");
        }

        public bool ValidateOrder(OrderOfPatientClient orderForCheck)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(orderForCheck);
            bool flag = Validator.TryValidateObject(orderForCheck, context, results, true);
            if (!flag)
            {
                foreach (ValidationResult error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("All data of order is OK");
            }

            return flag;
        }

    }
}
