using ClientHospitalApp.Reports;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static bool Validate(IPatient patientView)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(patientView);
            bool flag = Validator.TryValidateObject(patientView, context, results, true);
            if (!flag)
            {
                foreach (ValidationResult error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("All data patient is OK");
            }
            
            return flag;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ListOfPatientsForm());
            //Application.Run(new OrdersReport());
        }
    }
}
