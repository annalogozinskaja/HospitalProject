using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface ISpecimentSearchForm
    {
        BindingList<SpecimentsInOrder> DataSourceSpeciments { get; set; }
        List<Speciment> DataSourceSpecimentName { get; set; }
        List<SpecimentStatus> DataSourceSpecimentStatus { get; set; }
        List<OrderOfPatient> DataSourceOrder { get; set; }
        SpecimentsInOrder selectedSpeciment { get; set; }
        SpecimentDetail SpecimentDetailData { get; set; }

        event EventHandler DeleteSpecimentEvent;
        event EventHandler EditSpecimentEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler SaveDataToModelEvent;
    }
}
