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
    public class OrderOfPatientPresenter
    {
        public IPatient patientView;
        public OrderOfPatientModel orderModel;

        public OrderOfPatientPresenter(IPatient patientView)
        {
            this.patientView = patientView;
            this.orderModel = new OrderOfPatientModel();
        }

        public OrderOfPatientPresenter()
        {
            this.orderModel = new OrderOfPatientModel();
        }

        public void GetOrdersOfPatientInModel(int idPatient)
        {
            orderModel.GetOrdersOfPatient(idPatient);
        }
    }
}
