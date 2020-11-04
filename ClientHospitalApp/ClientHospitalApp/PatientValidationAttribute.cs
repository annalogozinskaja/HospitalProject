using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp
{
    public class PatientValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            IPatient patient = value as IPatient;
            if (patient.FirstnameText.CompareTo("")==0 || patient.LastnameText.CompareTo("") == 0 
                || patient.DOBText.CompareTo("") == 0 || patient.SSNText.CompareTo("")==0 ||
                patient.ID_GenderText.CompareTo("")==0)
            {
                this.ErrorMessage = "All fields must be entered";
                return false;
            }
          
            return true;         
        }
    }
}
