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
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();           
        }

       

        //private void buttonGetPatient_Click(object sender, EventArgs e)
        //{
        //    dataGridView1.Rows.Clear();

        //    if (textBoxID.Text!="")
        //    {
        //        try 
        //        { 
        //            PatientPresenter presenter = new PatientPresenter(this);
        //            presenter.GetPatientFromModel(Int32.Parse(textBoxID.Text));                  
        //            dataGridView1.Rows.Add(ID_PatientText, LastnameText, FirstnameText, DOBText.ToString());
                 
        //            //ListViewItem LVI = new ListViewItem(ID_PatientText.ToString());
        //            //LVI.SubItems.Add(LastnameText);
        //            //LVI.SubItems.Add(FirstnameText);
        //            //LVI.SubItems.Add(DOBText.ToString());
        //            //LVI.SubItems.Add(SSNText.ToString());
        //            //LVI.SubItems.Add(ID_GenderText.ToString());
        //            //this.listView1.Items.Add(LVI);
        //        }
        //        catch (FormatException)
        //        {
        //            MessageBox.Show("Unable to convert "+ textBoxID.Text+" into index.");
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Enter the index");
        //    }

        //}



        private void Form1_Load(object sender, EventArgs e)
        {
            PatientPresenter presenter = new PatientPresenter();
            presenter.GetAllPatientsFromModel();

            foreach (IPatient item in presenter.patientViewList)
            {
                dataGridView1.Rows.Add(item.ID_PatientText, item.LastnameText, item.FirstnameText, item.DOBText);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Text = "Add patient";

            DialogResult res = F.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    

                }
                catch (Exception s)
                {
                    Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                }
            }
        }
    }
}
