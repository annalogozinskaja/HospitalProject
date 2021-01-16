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
        PatientClient DataPatient { get; set; }
        List<Doctor> DataSourceDoctor { get; set; }
        List<OrderStatus> DataSourceOrderStatus { get; set; }
        List<PatientClient> DataSourcePatient { get; set; }
        OrderOfPatientClient Order { get; set; }

        event EventHandler AddOrUpdateOrderEvent;

        void ClearAllData();
    }
}