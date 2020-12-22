using ClientHospitalApp.Models;
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
    public class SpecimentsInOrderPresenter
    {
        private ISpecimentsInOrderModel specimentModel;
        private ISpecimentNameModel specimentNameModel;
        private ISpecimentStatusModel specimentStatusModel;
        private IOrderOfPatientModel orderModel;
        ISpecimentSearchForm specimentSearchView;
        bool EditClicked = false;

        public SpecimentsInOrderPresenter(ISpecimentSearchForm specimentSearchView, ISpecimentsInOrderModel specimentModel, 
            ISpecimentNameModel specimentNameModel, ISpecimentStatusModel specimentStatusModel, IOrderOfPatientModel orderModel)
        {
            this.specimentSearchView = specimentSearchView;
            this.specimentModel = specimentModel;
            this.specimentNameModel= specimentNameModel;
            this.specimentStatusModel = specimentStatusModel;
            this.orderModel = orderModel;

            this.specimentNameModel.GetSpecimentNames();
            this.specimentStatusModel.GetSpecimentStatuses();
            this.orderModel.GetOrders();
            this.specimentSearchView.DataSourceSpecimentName = this.specimentNameModel.ListSpecimentNames;
            this.specimentSearchView.DataSourceSpecimentStatus = this.specimentStatusModel.ListSpecimentStatuses;
            this.specimentSearchView.DataSourceOrder = this.orderModel.ListOrders;

            this.specimentSearchView.LoadDataDataEvent += GetAllSpecimentsFromModelEventHandler;
            this.specimentSearchView.SpecimentDetailData.AddOrUpdateSpecimentEvent += AddOrUpdateSpecimentEventHandler;
            this.specimentSearchView.EditSpecimentEvent += EditSpecimentEventHandler;
            this.specimentSearchView.DeleteSpecimentEvent += DeleteSpecimentEventHandler;
            this.specimentSearchView.SaveDataToModelEvent += SaveDataToModelEventHandler;
        }


        private void GetAllSpecimentsFromModelEventHandler(object sender, EventArgs args)
        {
            GetAllSpecimentsFromModel();
        }

        public void GetAllSpecimentsFromModel()
        {
            this.specimentModel.GetAllSpeciments();
            this.specimentSearchView.DataSourceSpeciments = this.specimentModel.SpecimentList;
        }

        private void AddOrUpdateSpecimentEventHandler(object sender, EventArgs args)
        {
            SpecimentsInOrder tempSpeciment = this.specimentSearchView.SpecimentDetailData.Speciment;

            if (!EditClicked)
            {
                this.specimentModel.SpecimentList.Add(tempSpeciment);
                this.specimentSearchView.SpecimentDetailData.ClearAllData();
            }
            else
            {
                if (this.specimentSearchView.selectedSpeciment.ID_SpecimentOrder <= 0)
                {
                    this.specimentModel.Speciment = this.specimentSearchView.selectedSpeciment;
                }
                for (int i = 0; i < this.specimentModel.SpecimentList.Count; i++)
                {
                    if (this.specimentModel.SpecimentList[i].Equals(this.specimentSearchView.selectedSpeciment))
                    {
                        this.specimentModel.SpecimentList[i] = tempSpeciment;
                    }
                }

                this.specimentSearchView.SpecimentDetailData.ClearAllData();
                EditClicked = false;
            }
        }

        private void EditSpecimentEventHandler(object sender, EventArgs args)
        {
            EditClicked = true;

            foreach (SpecimentsInOrder item in this.specimentModel.SpecimentList)
            {
                if (item.ID_SpecimentOrder == this.specimentSearchView.selectedSpeciment.ID_SpecimentOrder)
                {
                    this.specimentSearchView.SpecimentDetailData.Speciment = item;
                }
            }
        }

        private void DeleteSpecimentEventHandler(object sender, EventArgs args)
        {
            DialogResult res = MessageBox.Show("Delete " + this.specimentSearchView.selectedSpeciment.Speciment.SpecimentName + " with id " +
                                  this.specimentSearchView.selectedSpeciment.ID_SpecimentOrder + "?", "Deleting speciment", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.specimentModel.Speciment = this.specimentSearchView.selectedSpeciment;
                this.specimentModel.SpecimentList.Remove(this.specimentSearchView.selectedSpeciment);
            }
        }

        private void SaveDataToModelEventHandler(object sender, EventArgs args)
        {
            specimentModel.SaveDataOfSpeciment();
            MessageBox.Show("Data saved");
        }

    }
}
