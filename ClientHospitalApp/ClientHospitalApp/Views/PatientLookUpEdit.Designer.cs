namespace ClientHospitalApp.Views
{
    partial class PatientLookUpEdit
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
            this.labelPatient = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditPatient = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPatient.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPatient
            // 
            this.labelPatient.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPatient.Appearance.Options.UseFont = true;
            this.labelPatient.Location = new System.Drawing.Point(6, 13);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(39, 14);
            this.labelPatient.TabIndex = 0;
            this.labelPatient.Text = "Patient";
            // 
            // lookUpEditPatient
            // 
            this.lookUpEditPatient.Location = new System.Drawing.Point(119, 9);
            this.lookUpEditPatient.Name = "lookUpEditPatient";
            this.lookUpEditPatient.Properties.AutoHeight = false;
            this.lookUpEditPatient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPatient.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditPatient.TabIndex = 1;
            // 
            // PatientLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditPatient);
            this.Controls.Add(this.labelPatient);
            this.Name = "PatientLookUpEdit";
            this.Size = new System.Drawing.Size(269, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPatient.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelPatient;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditPatient;
    }
}