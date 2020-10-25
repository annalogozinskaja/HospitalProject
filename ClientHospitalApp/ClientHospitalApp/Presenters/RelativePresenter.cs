using ClientHospitalApp.Models;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.Presenters
{
    public class RelativePresenter
    {
        public IPatient patientView;
        public RelativeModel relativeModel;

        public RelativePresenter(IPatient patientView)
        {
            this.patientView = patientView;
            this.relativeModel = new RelativeModel();
        }

        public void SaveRelativeInModel()
        {
            relativeModel.SaveRelative();
        }
    }
}
