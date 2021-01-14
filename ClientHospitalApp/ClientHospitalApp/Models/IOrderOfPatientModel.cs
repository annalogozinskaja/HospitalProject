using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Models
{
    public interface IOrderOfPatientModel
    {       
        void GetAllOrders();     
        void AddOrder();
        void UpdateOrder();
        void DeleteOrder();
        void SaveDataOfOrder();

        OrderOfPatientClient Order { get; set; }
        List<OrderOfPatientClient> ListOrders { get; set; }
        BindingList<OrderOfPatientClient> OrderList { get; set; }
        List<OrderOfPatientClient> ListToAdd { get; set; }
        List<OrderOfPatientClient> ListToUpdate { get; set; }
        List<OrderOfPatientClient> ListToDelete { get; set; }
    }
}
