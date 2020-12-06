namespace ClientHospitalApp.Views
{
    partial class PatientSearchExtendForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditGender
            // 
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditDOB.Properties.Appearance.Options.UseFont = true;
            this.dateEditDOB.Properties.DisplayFormat.FormatString = "dd/MM/yy";
            this.dateEditDOB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditDOB.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditDOB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditDOB.Properties.Mask.EditMask = "dd/MM/yyyy";
            // 
            // textEditSSN
            // 
            this.textEditSSN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditSSN.Properties.Appearance.Options.UseFont = true;
            // 
            // textEditFnm
            // 
            this.textEditFnm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditFnm.Properties.Appearance.Options.UseFont = true;
            // 
            // textEditLnm
            // 
            this.textEditLnm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditLnm.Properties.Appearance.Options.UseFont = true;
            // 
            // textEditIdPatient
            // 
            this.textEditIdPatient.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditIdPatient.Properties.Appearance.Options.UseFont = true;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(298, 22);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(455, 223);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // PatientSearchExtendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "PatientSearchExtendForm";
            this.Size = new System.Drawing.Size(779, 306);
            this.Controls.SetChildIndex(this.gridControl1, 0);
            this.Controls.SetChildIndex(this.buttonOK, 0);
            this.Controls.SetChildIndex(this.buttonCancel, 0);
            this.Controls.SetChildIndex(this.textEditIdPatient, 0);
            this.Controls.SetChildIndex(this.textEditLnm, 0);
            this.Controls.SetChildIndex(this.textEditFnm, 0);
            this.Controls.SetChildIndex(this.textEditSSN, 0);
            this.Controls.SetChildIndex(this.dateEditDOB, 0);
            this.Controls.SetChildIndex(this.lookUpEditGender, 0);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraGrid.GridControl gridControl1;
    }
}