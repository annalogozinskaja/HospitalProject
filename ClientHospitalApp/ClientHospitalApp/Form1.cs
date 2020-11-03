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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing.Printing;

namespace ClientHospitalApp
{
    public partial class Form1 : Form
    {
        public string strGender = "";
        public GridControl gridControl1;
        public GridView gridView1;
        public PatientPresenter presenter;
        public GridColumn colID;
        public GridColumn colLastname;
        public GridColumn colFirstname;
        public GridColumn colDOB;
        public GridColumn colSSN;
        public GridColumn colGender;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            presenter = new PatientPresenter();
            presenter.GetAllPatientsFromModel();

            gridControl1 = new GridControl();
            gridControl1.Parent = this;
            gridControl1.Location = new Point(0, 170);
            gridControl1.Size = new Size(785, 485);
            //gridControl1.Dock = DockStyle.Fill;
            gridControl1.DataSource = presenter.patientViewList;

            gridView1 = gridControl1.MainView as GridView;
            colID = gridView1.Columns["ID_PatientText"];
            colLastname = gridView1.Columns["LastnameText"];
            colFirstname = gridView1.Columns["FirstnameText"];
            colDOB = gridView1.Columns["DOBText"];
            colSSN = gridView1.Columns["SSNText"];
            colGender = gridView1.Columns["ID_GenderText"];

            gridView1.Columns[1].Caption = "Lastname";
            gridView1.Columns[2].Caption = "Firstname";
            gridView1.Columns[3].Caption = "Data of birth";
            gridView1.Columns[4].Caption = "SSN";

            colID.Visible = false;
            colGender.Visible = false;

            colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gridView1.OptionsView.ShowGroupedColumns = true;
            gridView1.ExpandAllGroups();
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsSelection.MultiSelect = false;
            gridView1.DoubleClick += new System.EventHandler(gridView1_DoubleClick);

            //gridView1.FocusedRowHandle = 0;
            //gridView1.FocusedColumn = colID;

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
            colLastname.SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
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
            F.gridControlRelatives.Hide();
            F.Size = new Size(350, 355);

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

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                Form2 F = new Form2();
                F.Text = "Update patient";

                GenderPresenter genderPresenter = new GenderPresenter(F);
                genderPresenter.GetListGenderFromModel();

                F.comboBoxEditGndr.EditValue = "--choose gender--";
                foreach (Gender item in genderPresenter.genderModel.list)
                {
                    F.comboBoxEditGndr.Properties.Items.Add(item.GenderName);
                }

                F.comboBoxEditGndr.SelectedIndexChanged += new System.EventHandler(comboBoxEditGndr_SelectedIndexChanged);

                F.textEditIdPatient.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colID);
                F.textEditLnm.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colLastname);
                F.textEditFnm.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colFirstname);
                F.dateEditDOB.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colDOB);
                F.textEditSSN.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colSSN);

                foreach (Gender item in genderPresenter.genderModel.list)
                {
                    if (gridView1.GetRowCellDisplayText(selectedRowHandles[0], colGender).CompareTo(Convert.ToString(item.ID_Gender)) == 0)
                    {
                        F.comboBoxEditGndr.EditValue = item.GenderName;
                    }
                }

                F.gridControlRelatives.Hide();
                F.Size = new Size(350, 355);

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
                        patientPresenter.UpdatePatientInModel();
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                    }

                    RefreshData();
                }

            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose the patient");
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                GridColumn col = gridView1.Columns[2];
                object val = view.GetRowCellValue(info.RowHandle, col);
                // MessageBox.Show(val.ToString());
                // MessageBox.Show(string.Format("DoubleClick on row: {0}, column: {1}.", info.InRow, colCaption));

                Form2 F = new Form2();
                F.Text = "Detailed data of patient";

                GenderPresenter genderPresenter = new GenderPresenter(F);
                genderPresenter.GetListGenderFromModel();

                F.textEditIdPatient.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[0])).ToString();
                F.textEditLnm.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[1])).ToString();
                F.textEditFnm.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[2])).ToString();
                F.dateEditDOB.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[3])).ToString();
                F.textEditSSN.Text = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[4])).ToString();
                string tempGender = (view.GetRowCellValue(info.RowHandle, gridView1.Columns[5])).ToString();

                foreach (Gender item in genderPresenter.genderModel.list)
                {
                    if (tempGender.CompareTo(Convert.ToString(item.ID_Gender)) == 0)
                    {
                        F.comboBoxEditGndr.EditValue = item.GenderName;
                    }
                }

                RelativePresenter relativePresenter = new RelativePresenter(F);
                relativePresenter.GetRelativesOfPatientInModel(Convert.ToInt32(F.textEditIdPatient.Text));
                F.gridControlRelatives.DataSource = relativePresenter.relativeModel.list;

                GridView gridViewRelatives = F.gridControlRelatives.MainView as GridView;
                gridViewRelatives.OptionsView.ShowViewCaption = true;
                gridViewRelatives.ViewCaption = "Relatives";
                gridViewRelatives.Columns["ID_Relative"].Visible = false;
                gridViewRelatives.Columns["ID_Patient"].Visible = false;
                gridViewRelatives.Columns["ID_Gender"].Visible = false;

                F.buttonCancel.Hide();
                F.buttonOK.Hide();
                F.Size = new Size(822, 305);
                F.textEditIdPatient.Enabled = true;
                DialogResult res = F.ShowDialog();

            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int[] selectedRowHandles = gridView1.GetSelectedRows();
            if (selectedRowHandles.Length == 1)
            {
                DialogResult res = MessageBox.Show("Delete " + gridView1.GetRowCellDisplayText(selectedRowHandles[0], colLastname) +
                                    " "+ gridView1.GetRowCellDisplayText(selectedRowHandles[0], colFirstname)+"?", "Deleting patient", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)

                {
                    try
                    {
                        int idPatient = Convert.ToInt32(gridView1.GetRowCellDisplayText(selectedRowHandles[0], colID));
                        
                        Form2 F = new Form2();

                        F.textEditIdPatient.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colID);
                        F.textEditLnm.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colLastname);
                        F.textEditFnm.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colFirstname);
                        F.dateEditDOB.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colDOB);
                        F.textEditSSN.Text = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colSSN);
                        F.ID_GenderText = gridView1.GetRowCellDisplayText(selectedRowHandles[0], colGender);

                        PatientPresenter patientPresenter = new PatientPresenter(F);
                        patientPresenter.DeletePatientInModel();
                        RefreshData();
                    }
                    catch (Exception s)
                    {
                        Console.WriteLine("Error ({0} : {1}", s.GetType().Name, s.Message);
                    }
                }
            }
            else if (selectedRowHandles.Length == 0)
            {
                MessageBox.Show("Choose the patient");
            }
        }
    }
}
