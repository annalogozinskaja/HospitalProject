using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ClientHospitalApp.Views.PatientSearchForm;

namespace ClientHospitalApp.Views
{
    public interface IPatientSearchForm
    {
        List<PatientClient> DataSourcePatients { get; set; }
        List<Gender> DataSourceGender { get; set; }
        PatientClient selectedPatient { get; set; }
        PatientDetail PatientDetailData { get; set; }

        event EventHandler DeletePatientEvent;
        event EventHandler EditPatientEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler SaveDataToModelEvent;
        event PatientSearchFormHandler ShowPatientDataEvent;
        event EventHandler ShowOrdersEvent;
    }
}
