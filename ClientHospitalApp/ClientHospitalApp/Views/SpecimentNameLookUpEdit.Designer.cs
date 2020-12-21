namespace ClientHospitalApp.Views
{
    partial class SpecimentNameLookUpEdit
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
            this.labelControlSpecimentName = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditSpecimentName = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSpecimentName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlSpecimentName
            // 
            this.labelControlSpecimentName.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlSpecimentName.Appearance.Options.UseFont = true;
            this.labelControlSpecimentName.Location = new System.Drawing.Point(5, 13);
            this.labelControlSpecimentName.Name = "labelControlSpecimentName";
            this.labelControlSpecimentName.Size = new System.Drawing.Size(105, 14);
            this.labelControlSpecimentName.TabIndex = 0;
            this.labelControlSpecimentName.Text = "Type of Speciment";
            // 
            // lookUpEditSpecimentName
            // 
            this.lookUpEditSpecimentName.Location = new System.Drawing.Point(118, 9);
            this.lookUpEditSpecimentName.Name = "lookUpEditSpecimentName";
            this.lookUpEditSpecimentName.Properties.AutoHeight = false;
            this.lookUpEditSpecimentName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditSpecimentName.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditSpecimentName.TabIndex = 1;
            // 
            // SpecimentNameLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditSpecimentName);
            this.Controls.Add(this.labelControlSpecimentName);
            this.Name = "SpecimentNameLookUpEdit";
            this.Size = new System.Drawing.Size(269, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditSpecimentName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlSpecimentName;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditSpecimentName;
    }
}