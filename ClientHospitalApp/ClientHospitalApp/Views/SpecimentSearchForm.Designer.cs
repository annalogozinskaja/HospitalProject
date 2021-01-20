namespace ClientHospitalApp.Views
{
    partial class SpecimentSearchForm
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
            ClientHospitalApp.ClientEntities.SpecimentsInOrderClient specimentsInOrderClient1 = new ClientHospitalApp.ClientEntities.SpecimentsInOrderClient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecimentSearchForm));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.layoutConverter1 = new DevExpress.XtraLayout.Converter.LayoutConverter(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControlSpeciments = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.specimentDetail = new ClientHospitalApp.Views.SpecimentDetail();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSpeciments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControlSpeciments);
            this.layoutControl1.Controls.Add(this.specimentDetail);
            this.layoutControl1.Location = new System.Drawing.Point(6, 4);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(941, 434);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControlSpeciments
            // 
            this.gridControlSpeciments.Location = new System.Drawing.Point(323, 12);
            this.gridControlSpeciments.MainView = this.gridView1;
            this.gridControlSpeciments.Name = "gridControlSpeciments";
            this.gridControlSpeciments.Size = new System.Drawing.Size(606, 410);
            this.gridControlSpeciments.TabIndex = 5;
            this.gridControlSpeciments.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlSpeciments;
            this.gridView1.Name = "gridView1";
            // 
            // specimentDetail
            // 
            this.specimentDetail.DataOrder = null;
            this.specimentDetail.DataSourceOrder = null;
            this.specimentDetail.DataSourceSpecimentName = null;
            this.specimentDetail.DataSourceSpecimentStatus = null;
            this.specimentDetail.DataSpecimentName = null;
            this.specimentDetail.DataSpecimentStatus = null;
            this.specimentDetail.Location = new System.Drawing.Point(12, 12);
            this.specimentDetail.Name = "specimentDetail";
            this.specimentDetail.Size = new System.Drawing.Size(295, 410);
            specimentsInOrderClient1.DateOfTaking = new System.DateTime(((long)(0)));
            specimentsInOrderClient1.ID_SpecimentOrder = -1;
            specimentsInOrderClient1.Nurse = "";
            specimentsInOrderClient1.Order = null;
            specimentsInOrderClient1.Speciment = null;
            specimentsInOrderClient1.SpecimentStatus = null;
            specimentsInOrderClient1.testsInOrderList = ((System.Collections.Generic.List<int>)(resources.GetObject("specimentsInOrderClient1.testsInOrderList")));
            this.specimentDetail.Speciment = specimentsInOrderClient1;
            this.specimentDetail.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(941, 434);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.specimentDetail;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(311, 414);
            this.layoutControlItem1.Text = "   ";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Right;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(9, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlSpeciments;
            this.layoutControlItem2.Location = new System.Drawing.Point(311, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(610, 414);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // SpecimentSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 438);
            this.Controls.Add(this.layoutControl1);
            this.Name = "SpecimentSearchForm";
            this.Text = "SpecimentSearchForm";
            this.Load += new System.EventHandler(this.SpecimentSearchForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSpeciments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraLayout.Converter.LayoutConverter layoutConverter1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlSpeciments;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private SpecimentDetail specimentDetail;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}