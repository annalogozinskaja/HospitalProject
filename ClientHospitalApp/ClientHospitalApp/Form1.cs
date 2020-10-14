using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientHospitalApp.Views;
using ClientHospitalApp.Presenters;

namespace ClientHospitalApp
{
    public partial class Form1 : Form,IPatient
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int ID_PatientText { get { return Convert.ToInt32(labelID.Text); } set { labelID.Text = Convert.ToString(value); } }
        public string LastnameText { get { return labelLastname.Text; } set { labelLastname.Text = value; } }
        public string FirstnameText { get { return labelFirstname.Text; } set { labelFirstname.Text =value; } }
        public DateTime DOBText { get { return Convert.ToDateTime(labelDOB.Text); } set { labelDOB.Text = Convert.ToString(value); } }
        public int SSNText { get { return Convert.ToInt32(labelSSN.Text); } set { labelSSN.Text = Convert.ToString(value); } }
        public int ID_GenderText { get { return Convert.ToInt32(labelIDGender.Text); } set { labelIDGender.Text = Convert.ToString(value); } }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGetPatient_Click(object sender, EventArgs e)
        {
            PatientPresenter presenter = new PatientPresenter(this);
            presenter.GetPatient(Convert.ToInt32(textBoxID.Text));

        }
    }
}
