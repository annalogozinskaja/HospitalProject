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
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;

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

            GridControl gridControl1 = new GridControl();
            gridControl1.Parent = this;
            //gridControl1.Dock = DockStyle.Fill;
            gridControl1.DataSource = presenter.patientViewList;

            GridView gridView1 = gridControl1.MainView as GridView;
            GridColumn colID = gridView1.Columns["ID_PatientText"];
            GridColumn colLastname = gridView1.Columns["LastnameText"];
            GridColumn colFirstname = gridView1.Columns["FirstnameText"];
            GridColumn colDOB = gridView1.Columns["DOBText"];
            GridColumn colSSN = gridView1.Columns["SSNText"];
            GridColumn colGender = gridView1.Columns["ID_GenderText"];

            colLastname.Name = "Lastname";
            colFirstname.Name = "Firstname";
            colDOB.Name = "Data of birth";
            colSSN.Name = "SSN";

            colID.Visible = false;
            colGender.Visible = false;

            colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridView1.OptionsView.ShowGroupedColumns = true;
            gridView1.ExpandAllGroups();
            gridView1.ActiveFilterString = "[RequiredDate]>= #" + DateTime.Today.ToString() + "#";
            gridView1.OptionsBehavior.Editable = false;

            gridView1.FocusedRowHandle = 0;
            gridView1.FocusedColumn = colID;

            colLastname.BestFit();
            colGender.BestFit();


            SimpleButton buttonOK = new SimpleButton();
            buttonOK.Parent = this;
            buttonOK.Text = "OK";
            buttonOK.Width = 100;
            buttonOK.Height = 50;
            buttonOK.Location= new Point(250,250);
            buttonOK.Visible = true;
            buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;



        }

        //private void buttonAdd_Click(object sender, EventArgs e)
        //{
        //    Form2 F = new Form2();
        //    F.Text = "Add patient";

        //    DialogResult res = F.ShowDialog();

        //    if (res == DialogResult.OK)
        //    {
        //        try
        //        {
                    

        //        }
        //        catch (Exception s)
        //        {
        //            Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
        //        }
        //    }
        //}
    }
}
