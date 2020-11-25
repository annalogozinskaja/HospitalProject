namespace ClientHospitalApp
{
    partial class PatientDetail
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lookUpEditGender = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEditDOB = new DevExpress.XtraEditors.DateEdit();
            this.labelControlGndr = new DevExpress.XtraEditors.LabelControl();
            this.labelControlSSN = new DevExpress.XtraEditors.LabelControl();
            this.textEditSSN = new DevExpress.XtraEditors.TextEdit();
            this.labelControlDOB = new DevExpress.XtraEditors.LabelControl();
            this.labelControlFnm = new DevExpress.XtraEditors.LabelControl();
            this.textEditFnm = new DevExpress.XtraEditors.TextEdit();
            this.labelControlLnm = new DevExpress.XtraEditors.LabelControl();
            this.textEditLnm = new DevExpress.XtraEditors.TextEdit();
            this.labelControlID = new DevExpress.XtraEditors.LabelControl();
            this.textEditIdPatient = new DevExpress.XtraEditors.TextEdit();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEditGender
            // 
            this.lookUpEditGender.Location = new System.Drawing.Point(94, 215);
            this.lookUpEditGender.Name = "lookUpEditGender";
            this.lookUpEditGender.Properties.AutoHeight = false;
            this.lookUpEditGender.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditGender.Properties.NullText = "";
            this.lookUpEditGender.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditGender.TabIndex = 69;
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Location = new System.Drawing.Point(94, 135);
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateEditDOB.Properties.Appearance.Options.UseFont = true;
            this.dateEditDOB.Properties.AutoHeight = false;
            this.dateEditDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEditDOB.Properties.DisplayFormat.FormatString = "dd/MM/yy";
            this.dateEditDOB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditDOB.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEditDOB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditDOB.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEditDOB.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditDOB.Size = new System.Drawing.Size(145, 22);
            this.dateEditDOB.TabIndex = 67;
            // 
            // labelControlGndr
            // 
            this.labelControlGndr.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlGndr.Appearance.Options.UseFont = true;
            this.labelControlGndr.Location = new System.Drawing.Point(14, 219);
            this.labelControlGndr.Name = "labelControlGndr";
            this.labelControlGndr.Size = new System.Drawing.Size(40, 14);
            this.labelControlGndr.TabIndex = 65;
            this.labelControlGndr.Text = "Gender";
            // 
            // labelControlSSN
            // 
            this.labelControlSSN.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlSSN.Appearance.Options.UseFont = true;
            this.labelControlSSN.Location = new System.Drawing.Point(14, 179);
            this.labelControlSSN.Name = "labelControlSSN";
            this.labelControlSSN.Size = new System.Drawing.Size(22, 14);
            this.labelControlSSN.TabIndex = 64;
            this.labelControlSSN.Text = "SSN";
            // 
            // textEditSSN
            // 
            this.textEditSSN.Location = new System.Drawing.Point(94, 175);
            this.textEditSSN.Name = "textEditSSN";
            this.textEditSSN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditSSN.Properties.Appearance.Options.UseFont = true;
            this.textEditSSN.Properties.AutoHeight = false;
            this.textEditSSN.Size = new System.Drawing.Size(145, 22);
            this.textEditSSN.TabIndex = 63;
            this.textEditSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditSSN_KeyPress);
            // 
            // labelControlDOB
            // 
            this.labelControlDOB.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlDOB.Appearance.Options.UseFont = true;
            this.labelControlDOB.Location = new System.Drawing.Point(14, 139);
            this.labelControlDOB.Name = "labelControlDOB";
            this.labelControlDOB.Size = new System.Drawing.Size(69, 14);
            this.labelControlDOB.TabIndex = 62;
            this.labelControlDOB.Text = "Data of birth";
            // 
            // labelControlFnm
            // 
            this.labelControlFnm.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlFnm.Appearance.Options.UseFont = true;
            this.labelControlFnm.Location = new System.Drawing.Point(14, 99);
            this.labelControlFnm.Name = "labelControlFnm";
            this.labelControlFnm.Size = new System.Drawing.Size(52, 14);
            this.labelControlFnm.TabIndex = 61;
            this.labelControlFnm.Text = "Firstname";
            // 
            // textEditFnm
            // 
            this.textEditFnm.Location = new System.Drawing.Point(94, 95);
            this.textEditFnm.Name = "textEditFnm";
            this.textEditFnm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditFnm.Properties.Appearance.Options.UseFont = true;
            this.textEditFnm.Properties.AutoHeight = false;
            this.textEditFnm.Size = new System.Drawing.Size(145, 22);
            this.textEditFnm.TabIndex = 60;
            this.textEditFnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditLnm_KeyPress);
            // 
            // labelControlLnm
            // 
            this.labelControlLnm.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlLnm.Appearance.Options.UseFont = true;
            this.labelControlLnm.Location = new System.Drawing.Point(14, 59);
            this.labelControlLnm.Name = "labelControlLnm";
            this.labelControlLnm.Size = new System.Drawing.Size(52, 14);
            this.labelControlLnm.TabIndex = 59;
            this.labelControlLnm.Text = "Lastname";
            // 
            // textEditLnm
            // 
            this.textEditLnm.Location = new System.Drawing.Point(94, 55);
            this.textEditLnm.Name = "textEditLnm";
            this.textEditLnm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditLnm.Properties.Appearance.Options.UseFont = true;
            this.textEditLnm.Properties.AutoHeight = false;
            this.textEditLnm.Size = new System.Drawing.Size(145, 22);
            this.textEditLnm.TabIndex = 58;
            this.textEditLnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditLnm_KeyPress);
            // 
            // labelControlID
            // 
            this.labelControlID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlID.Appearance.Options.UseFont = true;
            this.labelControlID.Location = new System.Drawing.Point(14, 19);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(70, 14);
            this.labelControlID.TabIndex = 57;
            this.labelControlID.Text = "ID of Patient";
            // 
            // textEditIdPatient
            // 
            this.textEditIdPatient.Enabled = false;
            this.textEditIdPatient.Location = new System.Drawing.Point(94, 15);
            this.textEditIdPatient.Name = "textEditIdPatient";
            this.textEditIdPatient.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditIdPatient.Properties.Appearance.Options.UseFont = true;
            this.textEditIdPatient.Properties.AutoHeight = false;
            this.textEditIdPatient.Size = new System.Drawing.Size(145, 22);
            this.textEditIdPatient.TabIndex = 56;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(167, 262);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 28);
            this.buttonCancel.TabIndex = 55;
            this.buttonCancel.Text = "Clear";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(45, 262);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 28);
            this.buttonOK.TabIndex = 54;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // PatientDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditGender);
            this.Controls.Add(this.dateEditDOB);
            this.Controls.Add(this.labelControlGndr);
            this.Controls.Add(this.labelControlSSN);
            this.Controls.Add(this.textEditSSN);
            this.Controls.Add(this.labelControlDOB);
            this.Controls.Add(this.labelControlFnm);
            this.Controls.Add(this.textEditFnm);
            this.Controls.Add(this.labelControlLnm);
            this.Controls.Add(this.textEditLnm);
            this.Controls.Add(this.labelControlID);
            this.Controls.Add(this.textEditIdPatient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "PatientDetail";
            this.Size = new System.Drawing.Size(267, 304);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditGender.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.LookUpEdit lookUpEditGender;
        public DevExpress.XtraEditors.DateEdit dateEditDOB;
        private DevExpress.XtraEditors.LabelControl labelControlGndr;
        private DevExpress.XtraEditors.LabelControl labelControlSSN;
        public DevExpress.XtraEditors.TextEdit textEditSSN;
        private DevExpress.XtraEditors.LabelControl labelControlDOB;
        private DevExpress.XtraEditors.LabelControl labelControlFnm;
        public DevExpress.XtraEditors.TextEdit textEditFnm;
        private DevExpress.XtraEditors.LabelControl labelControlLnm;
        public DevExpress.XtraEditors.TextEdit textEditLnm;
        private DevExpress.XtraEditors.LabelControl labelControlID;
        public DevExpress.XtraEditors.TextEdit textEditIdPatient;
        public System.Windows.Forms.Button buttonCancel;
        public System.Windows.Forms.Button buttonOK;
    }
}
