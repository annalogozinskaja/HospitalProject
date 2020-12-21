namespace ClientHospitalApp.Views
{
    partial class SpecimentStatusLookUpEdit
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
            this.lookUpEditSpecimentStatus = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControlSpecimentStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSpecimentStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditSpecimentStatus
            // 
            this.lookUpEditSpecimentStatus.Location = new System.Drawing.Point(119, 8);
            this.lookUpEditSpecimentStatus.Name = "lookUpEditSpecimentStatus";
            this.lookUpEditSpecimentStatus.Properties.AutoHeight = false;
            this.lookUpEditSpecimentStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSpecimentStatus.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditSpecimentStatus.TabIndex = 0;
            // 
            // labelControlSpecimentStatus
            // 
            this.labelControlSpecimentStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlSpecimentStatus.Appearance.Options.UseFont = true;
            this.labelControlSpecimentStatus.Location = new System.Drawing.Point(7, 12);
            this.labelControlSpecimentStatus.Name = "labelControlSpecimentStatus";
            this.labelControlSpecimentStatus.Size = new System.Drawing.Size(35, 14);
            this.labelControlSpecimentStatus.TabIndex = 1;
            this.labelControlSpecimentStatus.Text = "Status";
            // 
            // SpecimentStatusLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControlSpecimentStatus);
            this.Controls.Add(this.lookUpEditSpecimentStatus);
            this.Name = "SpecimentStatusLookUpEdit";
            this.Size = new System.Drawing.Size(269, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSpecimentStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEditSpecimentStatus;
        private DevExpress.XtraEditors.LabelControl labelControlSpecimentStatus;
    }
}