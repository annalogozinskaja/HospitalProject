using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp
{
    [PatientValidation]
    public partial class Form2 : Form, IPatient
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string ID_PatientText
        {
            get { return textEditIdPatient.Text; }
            set { textEditIdPatient.Text = value; }
        }
       
        public string LastnameText 
        {
            get { return textEditLnm.Text; }
            set { textEditLnm.Text = value; } 
        }
        
        public string FirstnameText
        {
            get { return textEditFnm.Text; }
            set { textEditFnm.Text = value; }
        }
        
        public string DOBText 
        {
            get { return dateEditDOB.Text; }
            set { dateEditDOB.Text = value; }
        }
       
        public string SSNText
        {
            get { return textEditSSN.Text; }
            set { textEditSSN.Text = value; }
        }
       
        public string ID_GenderText { get; set; }

        private void textEditLnm_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsLetter(number) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.OemMinus)
            {
                e.Handled = true;
            }
        }

        private void textEditSSN_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
