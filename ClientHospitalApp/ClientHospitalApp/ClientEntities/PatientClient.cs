using AutoMapper;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class PatientClient : IPatientClient, IValidatableObject
    {
        public int ID_Patient { get; set; }
        //[Required(ErrorMessage = "Enter Lastname")]
        [RegularExpression(@"^[А-ЯA-Z]{1}[а-яa-z]+", ErrorMessage = "Lastname must be entered correctly")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Enter Firstname")]
        [RegularExpression(@"^[А-ЯA-Z]{1}[а-яa-z]+", ErrorMessage = "Firstname must be entered correctly")]
        public string Firstname { get; set; }
        [Required(ErrorMessage = "Enter Date of Birth")]
        [RegularExpression("^(0[1-9]|[12][0-9]|3[01])[-/.](0[1-9]|1[012])[-/.](19|20)\\d\\d$", ErrorMessage = "Date Of Birth must be entered correctly")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Enter SSN of patient")]
        [Range(000000001, 999999999, ErrorMessage = "SSN must have 9 numbers")]
        public int SSN { get; set; }
        public Gender Gender { get; set; }

        private List<Relative> relativeList { get; set; }
        public List<Relative> RelativeList
        {
            get { return relativeList; }
            set { relativeList = value; }
        }
        public PatientClient()
        {
            this.ID_Patient = -1;
            this.Lastname = string.Empty;
            this.Firstname = string.Empty;
            this.DOB = new DateTime();
            this.SSN = -1;
            Gender = new Gender();
            relativeList = new List<Relative>();
        }


        public IEnumerable<ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            List<ValidationResult> errors = new List<ValidationResult>();

            if (string.IsNullOrWhiteSpace(this.Lastname))
                errors.Add(new ValidationResult("Не указано фамилия"));

            return errors;
        }
    }
}
