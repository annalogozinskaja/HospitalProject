using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.Models;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using ClientHospitalApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        private ISpecimentsInOrderModel specimentModel;
        private ITestStatusModel testStatusModel;
        ITestSearchForm testSearchView;
        bool EditClicked = false;

        public TestsInOrderPresenter(ITestSearchForm testSearchView, ITestsInOrderModel testModel,
            ITestNameModel testNameModel,ISpecimentsInOrderModel specimentModel, ITestStatusModel testStatusModel)
        {
            this.testSearchView = testSearchView;
            this.testModel = testModel;
            this.testNameModel = testNameModel;
            this.specimentModel = specimentModel;
            this.testStatusModel = testStatusModel;

            this.testNameModel.GetTestNames();
            this.specimentModel.GetAllSpeciments();
            this.testStatusModel.GetTestStatuses();
            this.testSearchView.DataSourceTestName = this.testNameModel.ListTestNames;
            this.testSearchView.DataSourceSpeciment = this.specimentModel.ListSpeciments;
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
            TestsInOrderClient tempTest = this.testSearchView.TestDetailData.Test;

            bool flag = ValidateTest(tempTest);

            if (flag)
            {
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
        }

        private void EditTestEventHandler(object sender, EventArgs args)
        {
            EditClicked = true;

            foreach (TestsInOrderClient item in this.testModel.TestList)
            {
                if (item.Equals(this.testSearchView.selectedTest))
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

        public bool ValidateTest(TestsInOrderClient testForCheck)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            ValidationContext context = new ValidationContext(testForCheck);
            bool flag = Validator.TryValidateObject(testForCheck, context, results, true);
            if (!flag)
            {
                foreach (ValidationResult error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
            }
            else
            {
                MessageBox.Show("All data test is OK");
            }

            return flag;
        }
    }
}
