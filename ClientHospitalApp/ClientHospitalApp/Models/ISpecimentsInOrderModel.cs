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
    public interface ISpecimentsInOrderModel
    {
        void GetAllSpeciments();
        void AddSpeciment();
        void UpdateSpeciment();
        void DeleteSpeciment();
        void SaveDataOfSpeciment();

        SpecimentsInOrderClient Speciment { get; set; }
        List<SpecimentsInOrderClient> ListSpeciments { get; set; }
        BindingList<SpecimentsInOrderClient> SpecimentList { get; set; }
        List<SpecimentsInOrderClient> ListToAdd { get; set; }
        List<SpecimentsInOrderClient> ListToUpdate { get; set; }
        List<SpecimentsInOrderClient> ListToDelete { get; set; }
    }
}
