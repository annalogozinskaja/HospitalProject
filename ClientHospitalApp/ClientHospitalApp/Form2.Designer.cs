namespace ClientHospitalApp
{
    partial class Form2
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
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelControlLnm = new DevExpress.XtraEditors.LabelControl();
            this.textEditLnm = new DevExpress.XtraEditors.TextEdit();
            this.labelControlFnm = new DevExpress.XtraEditors.LabelControl();
            this.textEditFnm = new DevExpress.XtraEditors.TextEdit();
            this.labelControlSSN = new DevExpress.XtraEditors.LabelControl();
            this.textEditSSN = new DevExpress.XtraEditors.TextEdit();
            this.labelControlDOB = new DevExpress.XtraEditors.LabelControl();
            this.labelControlGndr = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEditGndr = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dateEditDOB = new DevExpress.XtraEditors.DateEdit();
            this.textEditIdPatient = new DevExpress.XtraEditors.TextEdit();
            this.labelControlID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGndr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(109, 396);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(93, 31);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(296, 396);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(93, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelControlLnm
            // 
            this.labelControlLnm.Location = new System.Drawing.Point(34, 63);
            this.labelControlLnm.Name = "labelControlLnm";
            this.labelControlLnm.Size = new System.Drawing.Size(46, 13);
            this.labelControlLnm.TabIndex = 11;
            this.labelControlLnm.Text = "Lastname";
            // 
            // textEditLnm
            // 
            this.textEditLnm.Location = new System.Drawing.Point(125, 60);
            this.textEditLnm.Name = "textEditLnm";
            this.textEditLnm.Size = new System.Drawing.Size(123, 20);
            this.textEditLnm.TabIndex = 10;
            // 
            // labelControlFnm
            // 
            this.labelControlFnm.Location = new System.Drawing.Point(34, 99);
            this.labelControlFnm.Name = "labelControlFnm";
            this.labelControlFnm.Size = new System.Drawing.Size(47, 13);
            this.labelControlFnm.TabIndex = 13;
            this.labelControlFnm.Text = "Firstname";
            // 
            // textEditFnm
            // 
            this.textEditFnm.Location = new System.Drawing.Point(125, 96);
            this.textEditFnm.Name = "textEditFnm";
            this.textEditFnm.Size = new System.Drawing.Size(123, 20);
            this.textEditFnm.TabIndex = 12;
            // 
            // labelControlSSN
            // 
            this.labelControlSSN.Location = new System.Drawing.Point(289, 63);
            this.labelControlSSN.Name = "labelControlSSN";
            this.labelControlSSN.Size = new System.Drawing.Size(19, 13);
            this.labelControlSSN.TabIndex = 17;
            this.labelControlSSN.Text = "SSN";
            // 
            // textEditSSN
            // 
            this.textEditSSN.Location = new System.Drawing.Point(380, 60);
            this.textEditSSN.Name = "textEditSSN";
            this.textEditSSN.Size = new System.Drawing.Size(118, 20);
            this.textEditSSN.TabIndex = 16;
            // 
            // labelControlDOB
            // 
            this.labelControlDOB.Location = new System.Drawing.Point(289, 27);
            this.labelControlDOB.Name = "labelControlDOB";
            this.labelControlDOB.Size = new System.Drawing.Size(61, 13);
            this.labelControlDOB.TabIndex = 15;
            this.labelControlDOB.Text = "Data of birth";
            // 
            // labelControlGndr
            // 
            this.labelControlGndr.Location = new System.Drawing.Point(289, 99);
            this.labelControlGndr.Name = "labelControlGndr";
            this.labelControlGndr.Size = new System.Drawing.Size(35, 13);
            this.labelControlGndr.TabIndex = 19;
            this.labelControlGndr.Text = "Gender";
            // 
            // comboBoxEditGndr
            // 
            this.comboBoxEditGndr.Location = new System.Drawing.Point(380, 96);
            this.comboBoxEditGndr.Name = "comboBoxEditGndr";
            this.comboBoxEditGndr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGndr.Size = new System.Drawing.Size(118, 20);
            this.comboBoxEditGndr.TabIndex = 20;
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Location = new System.Drawing.Point(380, 24);
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Size = new System.Drawing.Size(118, 20);
            this.dateEditDOB.TabIndex = 21;
            // 
            // textEditIdPatient
            // 
            this.textEditIdPatient.Enabled = false;
            this.textEditIdPatient.Location = new System.Drawing.Point(125, 24);
            this.textEditIdPatient.Name = "textEditIdPatient";
            this.textEditIdPatient.Size = new System.Drawing.Size(123, 20);
            this.textEditIdPatient.TabIndex = 8;
            // 
            // labelControlID
            // 
            this.labelControlID.Location = new System.Drawing.Point(34, 27);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(61, 13);
            this.labelControlID.TabIndex = 9;
            this.labelControlID.Text = "ID of Patient";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.dateEditDOB);
            this.Controls.Add(this.comboBoxEditGndr);
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
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGndr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private DevExpress.XtraEditors.LabelControl labelControlLnm;
        private DevExpress.XtraEditors.TextEdit textEditLnm;
        private DevExpress.XtraEditors.LabelControl labelControlFnm;
        private DevExpress.XtraEditors.TextEdit textEditFnm;
        private DevExpress.XtraEditors.LabelControl labelControlSSN;
        private DevExpress.XtraEditors.TextEdit textEditSSN;
        private DevExpress.XtraEditors.LabelControl labelControlDOB;
        private DevExpress.XtraEditors.LabelControl labelControlGndr;
        private DevExpress.XtraEditors.DateEdit dateEditDOB;
        public DevExpress.XtraEditors.TextEdit textEditIdPatient;
        private DevExpress.XtraEditors.LabelControl labelControlID;
        public DevExpress.XtraEditors.ComboBoxEdit comboBoxEditGndr;
    }
}