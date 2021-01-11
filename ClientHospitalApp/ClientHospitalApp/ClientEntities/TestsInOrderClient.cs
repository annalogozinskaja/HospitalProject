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
        public int ID_TestOrder { get; set; }
        public Test Test { get; set; }
        public DateTime DateStart { get; set; }
        public TestStatus TestStatus { get; set; }
        public string Result { get; set; }
        public List<int> specimentsInOrderList { get; set; }
        private const int _year = 2000;
        private DateTime dateCompare = DateTime.Parse("01.01.0001");

        public TestsInOrderClient()
        {
            this.ID_TestOrder = -1;
            this.Test = new Test();
            this.DateStart = new DateTime();
            this.TestStatus = new TestStatus();
            this.Result = string.Empty;
            this.specimentsInOrderList = new List<int>();
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (DateStart.Year<_year)
            {
                if (DateStart == dateCompare)
                {
                    yield return new ValidationResult(
                    $"Data of Test Start must be filled",
                    new[] { nameof(DateStart) });
                }
                else
                {
                    yield return new ValidationResult(
                    $"Data of Test Start must be no earlier than {_year}",
                    new[] { nameof(DateStart) });
                }                 
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
            if (TestStatus != null && TestStatus.TestStatusName.CompareTo("ready")==0)
            {
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
