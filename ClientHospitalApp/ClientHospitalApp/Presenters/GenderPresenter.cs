using ClientHospitalApp.Models;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Presenters
{
    class GenderPresenter
    {
        public IPatient patientView;
        public GenderModel genderModel;

        public GenderPresenter(IPatient patientView)
        {
            this.patientView = patientView;
            this.genderModel = new GenderModel();
        }

        public void GetListGenderFromModel()
        {
            genderModel.GetListGender();
        }
    }
}
