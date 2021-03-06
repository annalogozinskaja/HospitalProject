﻿namespace ClientHospitalApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonPatients = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrders = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSpeciments = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTests = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOrderReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSpecimentReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTestReport = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageData = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageReports = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonOrder = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barButtonPatients,
            this.barButtonOrders,
            this.barButtonSpeciments,
            this.barButtonTests,
            this.barButtonOrderReport,
            this.barButtonSpecimentReport,
            this.barButtonTestReport,
            this.barButtonSave,
            this.barButtonOrder});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 25;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageData,
            this.ribbonPageReports});
            this.ribbonControl1.Size = new System.Drawing.Size(954, 150);
            // 
            // barButtonPatients
            // 
            this.barButtonPatients.Caption = "Patients";
            this.barButtonPatients.Id = 1;
            this.barButtonPatients.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPatients.ImageOptions.Image")));
            this.barButtonPatients.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonPatients.ImageOptions.LargeImage")));
            this.barButtonPatients.Name = "barButtonPatients";
            this.barButtonPatients.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonPatients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonPatients_ItemClick);
            // 
            // barButtonOrders
            // 
            this.barButtonOrders.Caption = "Orders";
            this.barButtonOrders.Id = 2;
            this.barButtonOrders.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrders.ImageOptions.Image")));
            this.barButtonOrders.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrders.ImageOptions.LargeImage")));
            this.barButtonOrders.Name = "barButtonOrders";
            this.barButtonOrders.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonSpeciments
            // 
            this.barButtonSpeciments.Caption = "Speciments";
            this.barButtonSpeciments.Id = 3;
            this.barButtonSpeciments.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSpeciments.ImageOptions.Image")));
            this.barButtonSpeciments.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSpeciments.ImageOptions.LargeImage")));
            this.barButtonSpeciments.Name = "barButtonSpeciments";
            this.barButtonSpeciments.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSpeciments_ItemClick);
            // 
            // barButtonTests
            // 
            this.barButtonTests.Caption = "Tests";
            this.barButtonTests.Id = 4;
            this.barButtonTests.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonTests.ImageOptions.Image")));
            this.barButtonTests.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonTests.ImageOptions.LargeImage")));
            this.barButtonTests.Name = "barButtonTests";
            this.barButtonTests.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonTests_ItemClick);
            // 
            // barButtonOrderReport
            // 
            this.barButtonOrderReport.Caption = "Orders\' Report";
            this.barButtonOrderReport.Id = 13;
            this.barButtonOrderReport.Name = "barButtonOrderReport";
            // 
            // barButtonSpecimentReport
            // 
            this.barButtonSpecimentReport.Caption = "Speciments\' Report";
            this.barButtonSpecimentReport.Id = 14;
            this.barButtonSpecimentReport.Name = "barButtonSpecimentReport";
            // 
            // barButtonTestReport
            // 
            this.barButtonTestReport.Caption = "Tests\' Report";
            this.barButtonTestReport.Id = 15;
            this.barButtonTestReport.Name = "barButtonTestReport";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Caption = "Save";
            this.barButtonSave.Id = 23;
            this.barButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.Image")));
            this.barButtonSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonSave.ImageOptions.LargeImage")));
            this.barButtonSave.Name = "barButtonSave";
            this.barButtonSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonSave_ItemClick);
            // 
            // ribbonPageData
            // 
            this.ribbonPageData.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup8,
            this.ribbonPageGroup2});
            this.ribbonPageData.Name = "ribbonPageData";
            this.ribbonPageData.Text = "Laboratory\'s Data";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonPatients);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonSpeciments);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonTests);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup8.ItemLinks.Add(this.barButtonSave);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageReports
            // 
            this.ribbonPageReports.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPageReports.Name = "ribbonPageReports";
            this.ribbonPageReports.Text = "Reports";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonOrderReport);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonSpecimentReport);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonTestReport);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonOrder);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // barButtonOrder
            // 
            this.barButtonOrder.Caption = "Orders";
            this.barButtonOrder.Id = 24;
            this.barButtonOrder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonOrder.ImageOptions.Image")));
            this.barButtonOrder.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonOrder.ImageOptions.LargeImage")));
            this.barButtonOrder.Name = "barButtonOrder";
            this.barButtonOrder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonOrder_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 611);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageData;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonPatients;
        private DevExpress.XtraBars.BarButtonItem barButtonOrders;
        private DevExpress.XtraBars.BarButtonItem barButtonSpeciments;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonTests;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonOrderReport;
        private DevExpress.XtraBars.BarButtonItem barButtonSpecimentReport;
        private DevExpress.XtraBars.BarButtonItem barButtonTestReport;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageReports;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem barButtonOrder;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}