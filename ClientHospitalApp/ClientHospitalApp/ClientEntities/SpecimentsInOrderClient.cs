using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class SpecimentsInOrderClient : ISpecimentsInOrderClient, IValidatableObject
    {
        public int ID_SpecimentOrder { get; set; }
        public Speciment Speciment { get; set; }
        public SpecimentStatus SpecimentStatus { get; set; }
        [Required(ErrorMessage = "Enter Date of Speciment taking")]
        public DateTime DateOfTaking { get; set; }
        public OrderOfPatient Order { get; set; }

        [Required(ErrorMessage = "Enter Lastname of the Nurse")]
        [RegularExpression(@"^[А-ЯA-Z]{1}[а-яa-z]+", ErrorMessage = "Lastname of the Nurse must be entered correctly")]
        public string Nurse { get; set; }
        public List<int> testsInOrderList { get; set; }
        private const int _year = 2000;

        public SpecimentsInOrderClient()
        {
            this.ID_SpecimentOrder = -1;
            this.Speciment = new Speciment();
            this.SpecimentStatus = new SpecimentStatus();
            this.DateOfTaking = new DateTime();
            this.Order = new OrderOfPatient();
            this.Nurse = string.Empty;
            this.testsInOrderList = new List<int>();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateOfTaking.Year < _year)
            {
                yield return new ValidationResult(
                    $"Data of Speciment taking must be no earlier than {_year}",
                    new[] { nameof(DateOfTaking) });
            }
            if (Speciment == null)
            {
                yield return new ValidationResult(
                    $"Type of Speciment must be selected",
                    new[] { nameof(Speciment) });
            }
            if (SpecimentStatus == null)
            {
                yield return new ValidationResult(
                    $"Status of Speciment must be selected",
                    new[] { nameof(SpecimentStatus) });
            }
            if (Order == null)
            {
                yield return new ValidationResult(
                    $"Order must be selected",
                    new[] { nameof(Order) });
            }
        }

        public override string ToString()
        {
            return "Speciments";
        }
    }
}
