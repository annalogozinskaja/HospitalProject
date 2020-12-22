namespace ClientHospitalApp
{
    partial class GenderLookUpEdit
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
            this.lookUpEditGender = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControlGndr = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditGender
            // 
            this.lookUpEditGender.Location = new System.Drawing.Point(92, 8);
            this.lookUpEditGender.Name = "lookUpEditGender";
            this.lookUpEditGender.Properties.AutoHeight = false;
            this.lookUpEditGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGender.Properties.NullText = "";
            this.lookUpEditGender.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditGender.TabIndex = 71;
            this.lookUpEditGender.EditValueChanged += new System.EventHandler(this.lookUpEditGender_EditValueChanged);
            // 
            // labelControlGndr
            // 
            this.labelControlGndr.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlGndr.Appearance.Options.UseFont = true;
            this.labelControlGndr.Location = new System.Drawing.Point(12, 12);
            this.labelControlGndr.Name = "labelControlGndr";
            this.labelControlGndr.Size = new System.Drawing.Size(40, 14);
            this.labelControlGndr.TabIndex = 70;
            this.labelControlGndr.Text = "Gender";
            // 
            // GenderLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditGender);
            this.Controls.Add(this.labelControlGndr);
            this.Name = "GenderLookUpEdit";
            this.Size = new System.Drawing.Size(251, 39);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit lookUpEditGender;
        private DevExpress.XtraEditors.LabelControl labelControlGndr;
    }
}