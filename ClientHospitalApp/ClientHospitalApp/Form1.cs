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
using ClientHospitalApp.ServiceReferenceDAOLayer;

namespace ClientHospitalApp
{
    public partial class Form1 : Form,IPatient
    {      
        public Form1()
        {
            InitializeComponent();           
        }

        public int ID_PatientText { get; set; }
        public string LastnameText { get; set; }
        public string FirstnameText { get; set; }
        public DateTime DOBText { get; set; }
        public int SSNText { get; set; }
        public int ID_GenderText { get; set; }


        private void buttonGetPatient_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            if (textBoxID.Text!="")
            {
                try 
                { 
                    PatientPresenter presenter = new PatientPresenter(this);
                    presenter.GetPatient(Int32.Parse(textBoxID.Text));
                
                    ListViewItem LVI = new ListViewItem(ID_PatientText.ToString());
                    LVI.SubItems.Add(LastnameText);
                    LVI.SubItems.Add(FirstnameText);
                    LVI.SubItems.Add(DOBText.ToString());
                    LVI.SubItems.Add(SSNText.ToString());
                    LVI.SubItems.Add(ID_GenderText.ToString());
                    this.listView1.Items.Add(LVI);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Unable to convert "+ textBoxID.Text+" into index.");
                }
            }
            else
            {
                MessageBox.Show("Enter the index");
            }

        }

        private void buttonGetAllPatients_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
            PatientPresenter presenter = new PatientPresenter(this);
            List<Patient> list = new List<Patient>();
            list=presenter.GetAllPatients();

            for (int i = 0; i < list.Count; i++)
            {
                ListViewItem LVI = new ListViewItem(list[i].ID_Patient.ToString());
                LVI.SubItems.Add(list[i].Lastname);
                LVI.SubItems.Add(list[i].Firstname);
                LVI.SubItems.Add(list[i].DOB.ToString());
                LVI.SubItems.Add(list[i].SSN.ToString());
                LVI.SubItems.Add(list[i].ID_Gender.ToString());
                this.listView1.Items.Add(LVI);
            }

        }
    }
}
