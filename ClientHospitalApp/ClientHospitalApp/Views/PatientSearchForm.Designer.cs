namespace ClientHospitalApp
{
    partial class PatientSearchForm
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
            this.gridControlRelatives = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.patientDetail1 = new ClientHospitalApp.PatientDetail();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlRelatives
            // 
            this.gridControlRelatives.Location = new System.Drawing.Point(316, 18);
            this.gridControlRelatives.MainView = this.gridView1;
            this.gridControlRelatives.Name = "gridControlRelatives";
            this.gridControlRelatives.Size = new System.Drawing.Size(462, 225);
            this.gridControlRelatives.TabIndex = 52;
            this.gridControlRelatives.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlRelatives;
            this.gridView1.Name = "gridView1";
            // 
            // patientDetail1
            // 
            this.patientDetail1.Location = new System.Drawing.Point(12, 12);
            this.patientDetail1.Name = "patientDetail1";
            this.patientDetail1.Size = new System.Drawing.Size(274, 307);
            this.patientDetail1.TabIndex = 84;
            // 
            // PatientSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 327);
            this.Controls.Add(this.patientDetail1);
            this.Controls.Add(this.gridControlRelatives);
            this.Name = "PatientSearchForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControlRelatives;
        public PatientDetail patientDetail1;
    }
}