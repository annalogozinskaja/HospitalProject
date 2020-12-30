﻿using ClientHospitalApp.Models;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientHospitalApp.Presenters
{
    public class TestsInOrderPresenter
    {
        private ITestsInOrderModel testModel;
        private ITestNameModel testNameModel;
        private ITestStatusModel testStatusModel;
        ITestSearchForm testSearchView;
        bool EditClicked = false;

        public TestsInOrderPresenter(ITestSearchForm testSearchView, ITestsInOrderModel testModel,
            ITestNameModel testNameModel, ITestStatusModel testStatusModel)
        {
            this.testSearchView = testSearchView;
            this.testModel = testModel;
            this.testNameModel = testNameModel;
            this.testStatusModel = testStatusModel;

            this.testNameModel.GetTestNames();
            this.testStatusModel.GetTestStatuses();
            this.testSearchView.DataSourceTestName = this.testNameModel.ListTestNames;
            this.testSearchView.DataSourceTestStatus = this.testStatusModel.ListTestStatuses;

            this.testSearchView.LoadDataDataEvent += GetAllTestsFromModelEventHandler;
            this.testSearchView.TestDetailData.AddOrUpdateTestEvent += AddOrUpdateTestEventHandler;
            this.testSearchView.EditTestEvent += EditTestEventHandler;
            this.testSearchView.DeleteTestEvent += DeleteTestEventHandler;
            this.testSearchView.SaveDataToModelEvent += SaveDataToModelEventHandler;
        }


        private void GetAllTestsFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllTestsFromModel();
        }

        public void GetAllTestsFromModel()
        {
            this.testModel.GetAllTests();
            this.testSearchView.DataSourceTests = this.testModel.TestList;
        }

        private void AddOrUpdateTestEventHandler(object sender, EventArgs args)
        {
            TestsInOrder tempTest = this.testSearchView.TestDetailData.Test;

            if (!EditClicked)
            {
                this.testModel.TestList.Add(tempTest);
                this.testSearchView.TestDetailData.ClearAllData();
            }
            else
            {
                if (this.testSearchView.selectedTest.ID_TestOrder <= 0)
                {
                    this.testModel.Test = this.testSearchView.selectedTest;
                }
                for (int i = 0; i < this.testModel.TestList.Count; i++)
                {
                    if (this.testModel.TestList[i].Equals(this.testSearchView.selectedTest))
                    {
                        this.testModel.TestList[i] = tempTest;
                    }
                }

                this.testSearchView.TestDetailData.ClearAllData();
                EditClicked = false;
            }
        }

        private void EditTestEventHandler(object sender, EventArgs args)
        {
            EditClicked = true;

            foreach (TestsInOrder item in this.testModel.TestList)
            {
                if (item.ID_TestOrder == this.testSearchView.selectedTest.ID_TestOrder)
                {
                    this.testSearchView.TestDetailData.Test = item;
                }
            }
        }

        private void DeleteTestEventHandler(object sender, EventArgs args)
        {
            DialogResult res = MessageBox.Show("Delete " + this.testSearchView.selectedTest.Test.TestName + " with id " +
                                  this.testSearchView.selectedTest.ID_TestOrder + "?", "Deleting test", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.testModel.Test = this.testSearchView.selectedTest;
                this.testModel.TestList.Remove(this.testSearchView.selectedTest);
            }
        }

        private void SaveDataToModelEventHandler(object sender, EventArgs args)
        {
            testModel.SaveDataOfTest();
            MessageBox.Show("Data saved");
        }
    }
}
