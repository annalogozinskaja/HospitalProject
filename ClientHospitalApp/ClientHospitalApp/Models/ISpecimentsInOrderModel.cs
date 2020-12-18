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
        void GetSpeciment(int IdPatient);
        void AddSpeciment();
        void UpdateSpeciment();
        void DeleteSpeciment();
        void SaveDataOfSpeciment();

        SpecimentsInOrder Speciment { get; set; }
        List<SpecimentsInOrder> ListSpeciments { get; set; }
        BindingList<SpecimentsInOrder> SpecimentList { get; set; }
        List<SpecimentsInOrder> ListToAdd { get; set; }
        List<SpecimentsInOrder> ListToUpdate { get; set; }
        List<SpecimentsInOrder> ListToDelete { get; set; }
    }
}
