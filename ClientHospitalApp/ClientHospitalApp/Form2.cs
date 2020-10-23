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

        public string ID_PatientText
        {
            get { return textEditIdPatient.Text; }
            set { }
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
        public string DOBText { get; set; }
        public string SSNText
        {
            get { return textEditSSN.Text; }
            set { textEditSSN.Text = value; }
        }
        public string ID_GenderText
        {
            get { return "1"; }
            set { }
        }


    }
}
