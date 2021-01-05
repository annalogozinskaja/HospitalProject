using AutoMapper;
using ClientHospitalApp.ClientEntities;
using ClientHospitalApp.ServiceReferenceDAOLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClientHospitalApp.Models
{
    public class  TestsInOrderModel: ITestsInOrderModel
    {
        private  TestsInOrderClient test;
        private List< TestsInOrderClient> listTests;
        private WebServiceHospitalSoapClient service;
        BindingList< TestsInOrderClient> testList;
        private List< TestsInOrderClient> listToAdd;
        private List< TestsInOrderClient> listToUpdate;
        private List< TestsInOrderClient> listToDelete;
        ITestsInOrderModel testModel;

        public  TestsInOrderClient Test
        {
            get => test;
            set => test = value;
        }
        public List< TestsInOrderClient> ListTests
        {
            get => listTests;
            set => listTests = value;
        }
        public BindingList< TestsInOrderClient> TestList
        {
            get => testList;
            set => testList = value;
        }
        public List< TestsInOrderClient> ListToAdd
        {
            get => listToAdd;
            set => listToAdd = value;
        }
        public List< TestsInOrderClient> ListToUpdate
        {
            get => listToUpdate;
            set => listToUpdate = value;
        }
        public List< TestsInOrderClient> ListToDelete
        {
            get => listToDelete;
            set => listToDelete = value;
        }

        public  TestsInOrderModel()
        {
            Test = new  TestsInOrderClient();
            ListTests = new List< TestsInOrderClient>();
            service = new WebServiceHospitalSoapClient();
            ListToAdd = new List< TestsInOrderClient>();
            ListToUpdate = new List< TestsInOrderClient>();
            ListToDelete = new List< TestsInOrderClient>();
            testModel = this;
        }

        private List<TestsInOrderClient> ConvertTestsInOrderToTestsInOrderClient(List<TestsInOrder> testList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TestsInOrder, TestsInOrderClient>();
            });

            IMapper iMapper = config.CreateMapper();
            foreach (TestsInOrder item in testList)
            {
                TestsInOrderClient newTest = iMapper.Map<TestsInOrder, TestsInOrderClient>(item);
                ListTests.Add(newTest);
            }
            return ListTests;
        }

        private List<TestsInOrder> ConvertTestsInOrderClientToTestsInOrder(List<TestsInOrderClient> testList)
        {
            MapperConfiguration config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TestsInOrderClient, TestsInOrder>();
            });

            IMapper iMapper = config.CreateMapper();

            List<TestsInOrder> lstTsts = new List<TestsInOrder>();
            foreach (TestsInOrderClient item in testList)
            {
                TestsInOrder newTest = iMapper.Map<TestsInOrderClient, TestsInOrder>(item);
                lstTsts.Add(newTest);
            }

            return lstTsts;
        }

        void ITestsInOrderModel.AddTest()
        {
            service.AddTest(ConvertTestsInOrderClientToTestsInOrder(ListToAdd).ToArray());
        }

        void ITestsInOrderModel.UpdateTest()
        {
            service.UpdateTest(ConvertTestsInOrderClientToTestsInOrder(ListToUpdate).ToArray());
        }

        void ITestsInOrderModel.DeleteTest()
        {
            service.DeleteTest(ConvertTestsInOrderClientToTestsInOrder(ListToDelete).ToArray());
        }

        public void GetAllTests()
        {
            List<TestsInOrder> lt = new List<TestsInOrder>();
            lt = service.GetDataAllTests().ToList();

            ListTests = ConvertTestsInOrderToTestsInOrderClient(lt);
            FillTestList();
        }

        public void FillTestList()
        {
            TestList = new BindingList<TestsInOrderClient>(ListTests);
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
