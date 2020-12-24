using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientHospitalApp.Models
{
    public class TestsInOrderModel: ITestsInOrderModel
    {
        private TestsInOrder test;
        private List<TestsInOrder> listTests;
        private WebServiceHospitalSoapClient obj;
        BindingList<TestsInOrder> testList;
        private List<TestsInOrder> listToAdd;
        private List<TestsInOrder> listToUpdate;
        private List<TestsInOrder> listToDelete;
        ITestsInOrderModel testModel;

        public TestsInOrder Test
        {
            get => test;
            set => test = value;
        }
        public List<TestsInOrder> ListTests
        {
            get => listTests;
            set => listTests = value;
        }
        public BindingList<TestsInOrder> TestList
        {
            get => testList;
            set => testList = value;
        }
        public List<TestsInOrder> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List<TestsInOrder> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List<TestsInOrder> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }

        public TestsInOrderModel()
        {
            Test = new TestsInOrder();
            ListTests = new List<TestsInOrder>();
            obj = new WebServiceHospitalSoapClient();
            ListToAdd = new List<TestsInOrder>();
            ListToUpdate = new List<TestsInOrder>();
            ListToDelete = new List<TestsInOrder>();
            testModel = this;
        }

        void ITestsInOrderModel.AddTest()
        {
            obj.AddTest(ListToAdd.ToArray());
        }

        void ITestsInOrderModel.UpdateTest()
        {
            obj.UpdateTest(ListToUpdate.ToArray());
        }

        void ITestsInOrderModel.DeleteTest()
        {
            obj.DeleteTest(ListToDelete.ToArray());
        }

        public void GetAllTests()
        {
            ListTests = obj.GetDataAllTests().ToList();
            FillTestList();
        }

        public void FillTestList()
        {
            TestList = new BindingList<TestsInOrder>(ListTests);
            TestList.AllowNew = true;
            TestList.AllowEdit = true;
            TestList.AllowRemove = true;
            TestList.RaiseListChangedEvents = true;
            TestList.ListChanged += new ListChangedEventHandler(TestList_ListChanged);
        }

        public void SaveDataOfTest()
        {
            if (ListToAdd.Count > 0)
            {
                testModel.AddTest();
                ListToAdd.Clear();
            }

            if (ListToUpdate.Count > 0)
            {
                testModel.UpdateTest();
                ListToUpdate.Clear();
            }

            if (ListToDelete.Count > 0)
            {
                testModel.DeleteTest();
                ListToDelete.Clear();
            }
        }

        void TestList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (ListChangedType.ItemAdded == e.ListChangedType)
            {
                ListToAdd.Add(TestList[e.NewIndex]);
            }
            else if (ListChangedType.ItemChanged == e.ListChangedType)
            {
                if (TestList[e.NewIndex].ID_TestOrder > 0)  //это test из базы
                {
                    ListToUpdate.Add(TestList[e.NewIndex]);
                }
                else //это test из грида,он еще не сохранен в базе
                {
                    for (int i = 0; i < ListToAdd.Count; i++)
                    {
                        if (ListToAdd[i].Equals(Test))
                        {
                            ListToAdd[i] = TestList[e.NewIndex];
                        }
                    }
                    Test = null;
                }
            }
            else if (ListChangedType.ItemDeleted == e.ListChangedType)
            {
                if (Test.ID_TestOrder > 0)
                {
                    ListToDelete.Add(Test);
                }
                else
                {
                    ListToAdd.Remove(Test);
                }
                Test = null;
            }
        }
    }
}
