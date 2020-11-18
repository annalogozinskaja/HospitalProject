using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClientHospitalApp
{
    public class PatientValidationAttribute : ValidationAttribute
    {
        string patternName = @"^[А-ЯA-Z]{1}[а-яa-z]+";
        string patternDOB = @"^(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.]\d\d";
        string patternSSN = @"^[\d]{9}";

        public override bool IsValid(object value)
        {
            //IPatientView patient = value as IPatientView;
            //if (patient.FirstnameText.CompareTo("")==0 || patient.LastnameText.CompareTo("") == 0 
            //    || patient.DOBText.CompareTo("") == 0 || patient.SSNText.CompareTo("")==0 ||
            //    patient.ID_GenderText.CompareTo("")==0)
            //{
            //    this.ErrorMessage = "All fields must be entered";
            //    return false;
            //}
            //else if(!Regex.IsMatch(patient.LastnameText, patternName))
            //{
            //    this.ErrorMessage = "Lastname must be entered correctly";
            //    return false;
            //}
            //else if (!Regex.IsMatch(patient.FirstnameText, patternName))
            //{
            //    this.ErrorMessage = "Firstname must be entered correctly";
            //    return false;
            //}
            //else if (!Regex.IsMatch(patient.DOBText, patternDOB))
            //{
            //    this.ErrorMessage = "Data of birth must be in format dd/mm/yyyy";
            //    return false;
            //}
            //else if (!Regex.IsMatch(patient.SSNText, patternSSN))
            //{
            //    this.ErrorMessage = "SSN must contain 9 numbers";
            //    return false;
            //}
            //else if (patient.ID_GenderText.CompareTo("--choose gender--") ==0)
            //{
            //    this.ErrorMessage = "Gender must be chosen";
            //    return false;
            //}


            return true;         
        }
    }
}
