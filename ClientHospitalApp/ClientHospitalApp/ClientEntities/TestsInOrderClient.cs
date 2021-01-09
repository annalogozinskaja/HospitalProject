using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHospitalApp.ClientEntities
{
    public class TestsInOrderClient : ITestsInOrderClient, IValidatableObject
    {
        public virtual int ID_TestOrder { get; set; }
        public virtual Test Test { get; set; }
        public virtual DateTime DateStart { get; set; }
        public virtual DateTime DateEnd { get; set; }
        public virtual TestStatus TestStatus { get; set; }
        public virtual string Result { get; set; }
        public virtual List<int> specimentsInOrderList { get; set; }
        private const int _year = 2000;
        DateTime dateCompare = DateTime.Parse("01.01.0001");

        public TestsInOrderClient()
        {
            this.ID_TestOrder = -1;
            this.Test = new Test();
            this.DateStart = new DateTime();
            this.DateEnd = new DateTime();
            this.TestStatus = new TestStatus();
            this.Result = string.Empty;
            this.specimentsInOrderList = new List<int>();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateStart != dateCompare && DateStart.Year < _year)
            {
                yield return new ValidationResult(
                    $"Data of Test Start must be no earlier than {_year}",
                    new[] { nameof(DateStart) });
            }
            if (DateEnd != dateCompare && DateEnd.Year < _year)
            {
                yield return new ValidationResult(
                    $"Data of Test End must be no earlier than {_year}",
                    new[] { nameof(DateEnd) });
            }

            if (DateStart.Date >DateEnd.Date)
            {
                yield return new ValidationResult(
                    $"Data of Test Start must be no earlier than Data of Test End",
                    new[] { nameof(DateStart) });
            }
            if (Test == null)
            {
                yield return new ValidationResult(
                    $"Type of Test must be selected",
                    new[] { nameof(Test) });
            }
            if (TestStatus == null)
            {
                yield return new ValidationResult(
                    $"Status of Test must be selected",
                    new[] { nameof(TestStatus) });
            }
            if (DateEnd != dateCompare)
            {
                if (DateStart == dateCompare)
                {
                    yield return new ValidationResult(
                        $"Date of Start testing must be filled",
                        new[] { nameof(DateStart) });
                }
                if (String.IsNullOrEmpty(Result))
                {
                    yield return new ValidationResult(
                        $"If the Test finished,the Result must be filled",
                        new[] { nameof(Result) });
                }
            }
        }
    }
}
