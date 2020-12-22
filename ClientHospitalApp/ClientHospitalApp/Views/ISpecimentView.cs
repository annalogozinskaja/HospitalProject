using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface ISpecimentView
    {
        SpecimentsInOrder Speciment { get; set; }
        event EventHandler AddOrUpdateSpecimentEvent;
        void ClearAllData();
    }
}
