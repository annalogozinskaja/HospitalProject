using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace ClientHospitalApp.Views
{
    public interface IOrderSearchForm
    {
        List<Doctor> DataSourceDoctor { get; set; }
        BindingList<OrderOfPatientClient> DataSourceOrders { get; set; }
        List<Patient> DataSourcePatient { get; set; }
        List<OrderStatus> DataSourceOrderStatus { get; set; }
        OrderDetail OrderDetailData { get; set; }
        OrderOfPatientClient selectedOrder { get; set; }

        event EventHandler DeleteOrderEvent;
        event EventHandler EditOrderEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler SaveDataToModelEvent;
    }
}