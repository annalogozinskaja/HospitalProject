namespace ClientHospitalApp.Views
{
    partial class SpecimentsCheckedComboBoxEdit
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
            this.checkedComboBoxEditSpeciment = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditSpeciment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedComboBoxEditSpeciment
            // 
            this.checkedComboBoxEditSpeciment.Location = new System.Drawing.Point(101, 7);
            this.checkedComboBoxEditSpeciment.Name = "checkedComboBoxEditSpeciment";
            this.checkedComboBoxEditSpeciment.Properties.AutoHeight = false;
            this.checkedComboBoxEditSpeciment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.checkedComboBoxEditSpeciment.Size = new System.Drawing.Size(145, 22);
            this.checkedComboBoxEditSpeciment.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(9, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Speciments";
            // 
            // SpecimentsCheckedComboBoxEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.checkedComboBoxEditSpeciment);
            this.Name = "SpecimentsCheckedComboBoxEdit";
            this.Size = new System.Drawing.Size(252, 35);
            ((System.ComponentModel.ISupportInitialize)(this.checkedComboBoxEditSpeciment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.CheckedComboBoxEdit checkedComboBoxEditSpeciment;
    }
}