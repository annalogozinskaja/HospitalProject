namespace ClientHospitalApp.Views
{
    partial class SpecimentDetail
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
            this.labelControlID = new DevExpress.XtraEditors.LabelControl();
            this.textEditIdSpeciment = new DevExpress.XtraEditors.TextEdit();
            this.labelControlName = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdSpeciment.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlID
            // 
            this.labelControlID.Location = new System.Drawing.Point(13, 13);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(76, 13);
            this.labelControlID.TabIndex = 0;
            this.labelControlID.Text = "ID of Speciment";
            // 
            // textEditIdSpeciment
            // 
            this.textEditIdSpeciment.Location = new System.Drawing.Point(109, 12);
            this.textEditIdSpeciment.Name = "textEditIdSpeciment";
            this.textEditIdSpeciment.Size = new System.Drawing.Size(100, 20);
            this.textEditIdSpeciment.TabIndex = 1;
            // 
            // labelControlName
            // 
            this.labelControlName.Location = new System.Drawing.Point(13, 44);
            this.labelControlName.Name = "labelControlName";
            this.labelControlName.Size = new System.Drawing.Size(89, 13);
            this.labelControlName.TabIndex = 2;
            this.labelControlName.Text = "Type of Speciment";
            // 
            // SpecimentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 325);
            this.Controls.Add(this.labelControlName);
            this.Controls.Add(this.textEditIdSpeciment);
            this.Controls.Add(this.labelControlID);
            this.Name = "SpecimentDetail";
            this.Text = "SpecimentDetail";
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdSpeciment.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlID;
        private DevExpress.XtraEditors.TextEdit textEditIdSpeciment;
        private DevExpress.XtraEditors.LabelControl labelControlName;
    }
}