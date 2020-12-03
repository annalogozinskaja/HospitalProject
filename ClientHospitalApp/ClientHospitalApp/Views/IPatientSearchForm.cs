using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Views
{
    public interface IPatientSearchForm
    {
        List<PatientClient> DataSourcePatients { get; set; }
        List<Gender> DataSourceGender { get; set; }
        int selectedIdPatient { get; set; }
        int selectedSSN { get; set; }
        PatientDetail PatientDetailData { get; set; }

        //event EventHandler AddPatientEvent;
        event EventHandler DeletePatientEvent;
        event EventHandler EditPatientEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler ShowPatientDataEvent;
        event EventHandler ShowOrdersEvent;
    }
}
