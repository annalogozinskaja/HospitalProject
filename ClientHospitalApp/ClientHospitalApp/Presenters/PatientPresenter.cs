using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientHospitalApp.Views;
using ClientHospitalApp.ServiceReferenceDAOLayer;

namespace ClientHospitalApp.Presenters
{
    public class PatientPresenter
    {
        IPatient patientView;
        WebServiceHospitalSoapClient obj;

        public PatientPresenter(IPatient patientView)
        {
            this.patientView = patientView;
            obj = new WebServiceHospitalSoapClient();
        }

        public void GetPatient(int IdPatient)
        {
            Patient p = new Patient();
            p=obj.GetDataPatient(IdPatient);

            patientView.ID_PatientText = p.ID_Patient;
            patientView.LastnameText = p.Lastname;
            patientView.FirstnameText = p.Firstname;
            patientView.DOBText = p.DOB;
            patientView.SSNText = p.SSN;
            patientView.ID_GenderText = p.ID_Gender;


        }
    }
}
