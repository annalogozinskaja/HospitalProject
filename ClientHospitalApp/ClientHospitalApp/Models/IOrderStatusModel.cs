using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Models
{
    public interface IOrderStatusModel
    {
        List<OrderStatus> ListOrderStatuses { get; set; }

        void GetOrderStatuses();
    }
}