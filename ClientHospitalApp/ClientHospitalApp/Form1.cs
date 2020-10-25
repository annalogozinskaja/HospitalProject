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
using DevExpress.XtraGrid.Views.BandedGrid;
using System.Windows.Controls.Ribbon;

namespace ClientHospitalApp
{
    public partial class Form1 : Form
    {
        public string strGender = "";
        public GridControl gridControl1;
        public GridView gridView1;
        public PatientPresenter presenter;

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
            presenter = new PatientPresenter();
            presenter.GetAllPatientsFromModel();

            gridControl1 = new GridControl();
            gridControl1.Parent = this;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.DataSource = presenter.patientViewList;

            gridView1 = gridControl1.MainView as GridView;
            GridColumn colID = gridView1.Columns["ID_PatientText"];
            GridColumn colLastname = gridView1.Columns["LastnameText"];
            GridColumn colFirstname = gridView1.Columns["FirstnameText"];
            GridColumn colDOB = gridView1.Columns["DOBText"];
            GridColumn colSSN = gridView1.Columns["SSNText"];
            GridColumn colGender = gridView1.Columns["ID_GenderText"];
            
            colFirstname.Caption = "";

            colLastname.FieldName = "Lastname";
            colFirstname.FieldName = "Firstname";
            colDOB.FieldName = "Data of birth";
            colSSN.FieldName = "SSN";

            colID.Visible = false;
            colGender.Visible = false;

            colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridView1.OptionsView.ShowGroupedColumns = true;
            gridView1.ExpandAllGroups();
            gridView1.OptionsBehavior.Editable = false;


            gridView1.FocusedRowHandle = 0;
            gridView1.FocusedColumn = colID;

            colLastname.BestFit();
            colGender.BestFit();
        }


        private void comboBoxEditGndr_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxEdit combo = sender as ComboBoxEdit;
            strGender = combo.SelectedItem.ToString();
        }

        public void RefreshData()
        {
            presenter.GetAllPatientsFromModel();
            gridControl1.RefreshDataSource();
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form2 F = new Form2();
            F.Text = "Add patient";

            GenderPresenter genderPresenter = new GenderPresenter(F);
            genderPresenter.GetListGenderFromModel();

            F.comboBoxEditGndr.EditValue = "--choose gender--";
            foreach (Gender item in genderPresenter.genderModel.list)
            {
                F.comboBoxEditGndr.Properties.Items.Add(item.GenderName);
            }

            F.comboBoxEditGndr.SelectedIndexChanged += new System.EventHandler(comboBoxEditGndr_SelectedIndexChanged);
            DialogResult res = F.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    foreach (Gender item in genderPresenter.genderModel.list)
                    {
                        if (strGender.CompareTo(item.GenderName) == 0)
                        {
                            F.ID_GenderText = Convert.ToString(item.ID_Gender);
                        }
                    }

                    PatientPresenter patientPresenter = new PatientPresenter(F);
                    patientPresenter.SavePatientInModel();
                }
                catch (Exception s)
                {
                    Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                }

                RefreshData();
            }
        }
    }
}
