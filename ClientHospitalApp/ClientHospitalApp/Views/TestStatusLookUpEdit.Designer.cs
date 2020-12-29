namespace ClientHospitalApp.Views
{
    partial class TestStatusLookUpEdit
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
            this.labelControlTestStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditTestStatus = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTestStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlTestStatus
            // 
            this.labelControlTestStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlTestStatus.Appearance.Options.UseFont = true;
            this.labelControlTestStatus.Location = new System.Drawing.Point(10, 11);
            this.labelControlTestStatus.Name = "labelControlTestStatus";
            this.labelControlTestStatus.Size = new System.Drawing.Size(35, 14);
            this.labelControlTestStatus.TabIndex = 0;
            this.labelControlTestStatus.Text = "Status";
            // 
            // lookUpEditTestStatus
            // 
            this.lookUpEditTestStatus.Location = new System.Drawing.Point(102, 7);
            this.lookUpEditTestStatus.Name = "lookUpEditTestStatus";
            this.lookUpEditTestStatus.Properties.AutoHeight = false;
            this.lookUpEditTestStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTestStatus.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditTestStatus.TabIndex = 1;
            // 
            // TestStatusLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditTestStatus);
            this.Controls.Add(this.labelControlTestStatus);
            this.Name = "TestStatusLookUpEdit";
            this.Size = new System.Drawing.Size(252, 35);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTestStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlTestStatus;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditTestStatus;
    }
}