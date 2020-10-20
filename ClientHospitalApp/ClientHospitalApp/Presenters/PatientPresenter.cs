using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientHospitalApp.Views;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Models;
using System.Windows.Forms;

namespace ClientHospitalApp.Presenters
{
    public class PatientPresenter
    {
        private IPatient patientView;
        public List<IPatient> patientViewList;
        private PatientModel patientModel;

        public PatientPresenter(IPatient patientView)
        {
            this.patientView = patientView;
            this.patientModel = new PatientModel();
        }

        public PatientPresenter()
        {
            this.patientViewList = new List<IPatient>();
            this.patientModel = new PatientModel();
        }

        public void GetPatientFromModel(int IdPatient)
        {
            patientModel.GetPatient(IdPatient);

            patientView.ID_PatientText = patientModel.patient.ID_Patient;
            patientView.LastnameText = patientModel.patient.Lastname;
            patientView.FirstnameText = patientModel.patient.Firstname;
            patientView.DOBText = patientModel.patient.DOB;
            patientView.SSNText = patientModel.patient.SSN;
            patientView.ID_GenderText = patientModel.patient.ID_Gender;
        }

        public void GetAllPatientsFromModel()
        {
            patientModel.GetAllPatients();

            for (int i = 0; i < patientModel.list.Count; i++)
            {
                IPatient tempView=new Form2();
                tempView.ID_PatientText = patientModel.list[i].ID_Patient;
                tempView.LastnameText = patientModel.list[i].Lastname;
                tempView.FirstnameText = patientModel.list[i].Firstname;
                tempView.DOBText = patientModel.list[i].DOB;
                tempView.SSNText = patientModel.list[i].SSN;
                tempView.ID_GenderText = patientModel.list[i].ID_Gender;

                patientViewList.Add(tempView);
            }

        }
    }
}
