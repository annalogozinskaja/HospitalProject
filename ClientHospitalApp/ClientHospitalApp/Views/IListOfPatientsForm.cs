using ClientHospitalApp.ServiceReferenceDAOLayer;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;

namespace ClientHospitalApp
{
    public interface IListOfPatientsForm
    {
        List<Patient> DataSource { get; set; }
        GridControl gridControl1 { get; set; }
        GridView gridView1 { get; set; }
        int selectedIdPatient { get; set; }

        event EventHandler AddPatientEvent;
        event EventHandler DeletePatientEvent;
        event EventHandler EditPatientEvent;
        event EventHandler LoadDataDataEvent;
        event EventHandler ShowPatientDataEvent;
        event EventHandler ShowOrdersEvent;
    }
}