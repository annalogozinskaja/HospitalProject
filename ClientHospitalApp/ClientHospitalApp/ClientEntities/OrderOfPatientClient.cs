using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class OrderOfPatientClient : IOrderOfPatientClient
    {
        public int ID_Order { get; set; }
        public PatientClient Patient { get; set; }
        [Required(ErrorMessage = "Enter Date of Order")]
        public DateTime DateOrder { get; set; }
        [Required(ErrorMessage = "Enter Symptoms")]
        public string Symptoms { get; set; }       
        public Doctor Doctor { get; set; }
        public OrderStatus OrderStatus { get; set; }

        private const int _year = 2000;

        public OrderOfPatientClient()
        {
            this.ID_Order = -1;
            this.Patient = new PatientClient();          
            this.DateOrder = new DateTime();
            this.Symptoms = string.Empty;
            this.Doctor = new Doctor();
            this.OrderStatus = new OrderStatus();
        }

        public IEnumerable<ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext)
        {
            if (DateOrder.Year < _year)
            {
                yield return new ValidationResult(
                    $"Data of order must be no earlier than {_year}",
                    new[] { nameof(DateOrder) });
            }
            if (Patient == null)
            {
                yield return new ValidationResult(
                    $"Patient must be selected",
                    new[] { nameof(Patient) });
            }
            if (Doctor == null)
            {
                yield return new ValidationResult(
                    $"Doctor must be selected",
                    new[] { nameof(Doctor) });
            }
            if (OrderStatus == null)
            {
                yield return new ValidationResult(
                    $"OrderStatus must be selected",
                    new[] { nameof(OrderStatus) });
            }
        }

    }
}
