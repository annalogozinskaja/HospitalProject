using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface IOrderDetail
    {
        Doctor DataDoctor { get; set; }
        OrderStatus DataOrderStatus { get; set; }
        Patient DataPatient { get; set; }
        List<Doctor> DataSourceDoctor { get; set; }
        List<OrderStatus> DataSourceOrderStatus { get; set; }
        List<Patient> DataSourcePatient { get; set; }
        OrderOfPatientClient Order { get; set; }

        event EventHandler AddOrUpdateOrderEvent;

        void ClearAllData();
    }
}