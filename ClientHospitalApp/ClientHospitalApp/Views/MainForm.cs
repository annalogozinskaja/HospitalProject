﻿using ClientHospitalApp.Models;
using ClientHospitalApp.Presenters;
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
    public partial class MainForm : Form, IMainForm
    {
        public event EventHandler SaveDataEvent;
        public MainForm()
        {
            InitializeComponent();
        }

        private void barButtonPatients_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PatientSearchForm patientSearchForm = new PatientSearchForm();
            patientSearchForm.MdiParent = this;
            PatientPresenter patientPresenter = new PatientPresenter(patientSearchForm, new PatientModel(),new GenderModel());
          
            patientSearchForm.Show();
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveDataEvent(this, EventArgs.Empty);
        }

        private void barButtonSpeciments_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SpecimentSearchForm specimentSearchForm = new SpecimentSearchForm();
            specimentSearchForm.MdiParent = this;
            SpecimentsInOrderPresenter specimentPresenter = new SpecimentsInOrderPresenter(specimentSearchForm, 
                new SpecimentsInOrderModel(), new SpecimentNameModel(), new SpecimentStatusModel(),new OrderOfPatientModel());

            specimentSearchForm.Show();
        }

        private void barButtonTests_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TestSearchForm testSearchForm = new TestSearchForm();
            testSearchForm.MdiParent = this;
            TestsInOrderPresenter testPresenter = new TestsInOrderPresenter(testSearchForm,
                new TestsInOrderModel(), new TestTypeModel(),new SpecimentsInOrderModel(), new TestStatusModel());

            testSearchForm.Show();
        }

        private void barButtonOrder_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OrderSearchForm orderSearchForm = new OrderSearchForm();
            orderSearchForm.MdiParent = this;
            OrderOfPatientPresenter orderPresenter = new OrderOfPatientPresenter(orderSearchForm,
                new OrderOfPatientModel(), new PatientModel(), new DoctorModel(), new OrderStatusModel());

            orderSearchForm.Show();
        }
    }
}
