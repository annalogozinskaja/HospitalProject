using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface IOrderStatusLookUpEdit
    {
        OrderStatus OrderStatus { get; set; }
        List<OrderStatus> OrderStatusDataSource { get; set; }
    }
}