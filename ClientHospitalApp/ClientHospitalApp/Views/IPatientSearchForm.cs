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
        List<Patient> DataSourcePatients { get; set; }
        List<Gender> DataSourceGender { get; set; }
        int selectedIdPatient { get; set; }
        PatientDetail PatientDetailData { get; set; }

        //event EventHandler AddPatientEvent;
        event EventHandler DeletePatientEvent;
        event EventHandler EditPatientEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler ShowPatientDataEvent;
        event EventHandler ShowOrdersEvent;
    }
}
