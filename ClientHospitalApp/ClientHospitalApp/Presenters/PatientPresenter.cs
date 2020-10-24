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
        public IPatient patientView;
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

            patientView.ID_PatientText = Convert.ToString(patientModel.patient.ID_Patient);
            patientView.LastnameText = patientModel.patient.Lastname;
            patientView.FirstnameText = patientModel.patient.Firstname;
            patientView.DOBText = Convert.ToString(patientModel.patient.DOB);
            patientView.SSNText = Convert.ToString(patientModel.patient.SSN);
            patientView.ID_GenderText = Convert.ToString(patientModel.patient.ID_Gender);
        }

        public void GetAllPatientsFromModel()
        {
            patientModel.GetAllPatients();

            for (int i = 0; i < patientModel.list.Count; i++)
            {
                IPatient tempView=new Form2();
                tempView.ID_PatientText = Convert.ToString(patientModel.list[i].ID_Patient);
                tempView.LastnameText = patientModel.list[i].Lastname;
                tempView.FirstnameText = patientModel.list[i].Firstname;
                tempView.DOBText = Convert.ToString(patientModel.list[i].DOB);
                tempView.SSNText = Convert.ToString(patientModel.list[i].SSN);
                tempView.ID_GenderText = Convert.ToString(patientModel.list[i].ID_Gender);

                patientViewList.Add(tempView);
            }
        }

        public void SavePatientInModel()
        {
            patientModel.patient.Lastname=patientView.LastnameText;
            patientModel.patient.Firstname=patientView.FirstnameText;
            patientModel.patient.DOB = Convert.ToDateTime(patientView.DOBText);
            patientModel.patient.SSN = Convert.ToInt32(patientView.SSNText);
            patientModel.patient.ID_Gender = Convert.ToInt32(patientView.ID_GenderText);

            patientModel.SavePatient();
        }
    }
}
