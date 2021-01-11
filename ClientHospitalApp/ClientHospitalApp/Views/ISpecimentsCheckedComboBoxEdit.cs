using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System.Collections.Generic;

namespace ClientHospitalApp.Views
{
    public interface ISpecimentsCheckedComboBoxEdit
    {
        SpecimentsInOrderClient Speciment { get; set; }
        List<SpecimentsInOrderClient> SpecimentDataSource { get; set; }
    }
}