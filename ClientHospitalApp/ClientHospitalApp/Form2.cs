using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp
{
    public partial class Form2 : Form, IPatient
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int ID_PatientText { get; set; }
        public string LastnameText { get; set; }
        public string FirstnameText { get; set; }
        public DateTime DOBText { get; set; }
        public int SSNText { get; set; }
        public int ID_GenderText { get; set; }

       
    }
}
