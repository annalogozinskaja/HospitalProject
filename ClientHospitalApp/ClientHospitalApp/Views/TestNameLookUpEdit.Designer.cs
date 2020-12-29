namespace ClientHospitalApp.Views
{
    partial class TestNameLookUpEdit
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
            this.labelControlTestName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditTestName = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTestName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlTestName
            // 
            this.labelControlTestName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlTestName.Appearance.Options.UseFont = true;
            this.labelControlTestName.Location = new System.Drawing.Point(6, 12);
            this.labelControlTestName.Name = "labelControlTestName";
            this.labelControlTestName.Size = new System.Drawing.Size(72, 14);
            this.labelControlTestName.TabIndex = 0;
            this.labelControlTestName.Text = "Type of Test";
            // 
            // lookUpEditTestName
            // 
            this.lookUpEditTestName.Location = new System.Drawing.Point(100, 8);
            this.lookUpEditTestName.Name = "lookUpEditTestName";
            this.lookUpEditTestName.Properties.AutoHeight = false;
            this.lookUpEditTestName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditTestName.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditTestName.TabIndex = 1;
            // 
            // TestNameLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditTestName);
            this.Controls.Add(this.labelControlTestName);
            this.Name = "TestNameLookUpEdit";
            this.Size = new System.Drawing.Size(252, 38);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditTestName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlTestName;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditTestName;
    }
}