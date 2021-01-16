namespace ClientHospitalApp.Views
{
    partial class DoctorLookUpEdit
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
            this.labelDoctor = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditDoctor = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDoctor.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDoctor
            // 
            this.labelDoctor.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDoctor.Appearance.Options.UseFont = true;
            this.labelDoctor.Location = new System.Drawing.Point(7, 13);
            this.labelDoctor.Name = "labelDoctor";
            this.labelDoctor.Size = new System.Drawing.Size(37, 14);
            this.labelDoctor.TabIndex = 0;
            this.labelDoctor.Text = "Doctor";
            // 
            // lookUpEditDoctor
            // 
            this.lookUpEditDoctor.Location = new System.Drawing.Point(118, 9);
            this.lookUpEditDoctor.Name = "lookUpEditDoctor";
            this.lookUpEditDoctor.Properties.AutoHeight = false;
            this.lookUpEditDoctor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditDoctor.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditDoctor.TabIndex = 1;
            // 
            // DoctorLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditDoctor);
            this.Controls.Add(this.labelDoctor);
            this.Name = "DoctorLookUpEdit";
            this.Size = new System.Drawing.Size(269, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditDoctor.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelDoctor;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditDoctor;
    }
}