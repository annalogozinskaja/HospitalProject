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
            this.gridControlRelatives = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateEditDOB = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxEditGndr = new DevExpress.XtraEditors.ComboBoxEdit();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelatives)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGndr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(54, 265);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(76, 31);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(189, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // gridControlRelatives
            // 
            this.gridControlRelatives.Location = new System.Drawing.Point(316, 18);
            this.gridControlRelatives.MainView = this.gridView1;
            this.gridControlRelatives.Name = "gridControlRelatives";
            this.gridControlRelatives.Size = new System.Drawing.Size(462, 225);
            this.gridControlRelatives.TabIndex = 52;
            this.gridControlRelatives.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControlRelatives;
            this.gridView1.Name = "gridView1";
            // 
            // dateEditDOB
            // 
            this.dateEditDOB.EditValue = null;
            this.dateEditDOB.Location = new System.Drawing.Point(121, 138);
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.dateEditDOB.Size = new System.Drawing.Size(155, 25);
            this.dateEditDOB.TabIndex = 51;
            // 
            // comboBoxEditGndr
            // 
            this.comboBoxEditGndr.Location = new System.Drawing.Point(121, 218);
            this.comboBoxEditGndr.Name = "comboBoxEditGndr";
            this.comboBoxEditGndr.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEditGndr.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEditGndr.Properties.AutoHeight = false;
            this.comboBoxEditGndr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGndr.Size = new System.Drawing.Size(155, 25);
            this.comboBoxEditGndr.TabIndex = 50;
            // 
            // labelControlGndr
            // 
            this.labelControlGndr.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlGndr.Appearance.Options.UseFont = true;
            this.labelControlGndr.Location = new System.Drawing.Point(32, 222);
            this.labelControlGndr.Name = "labelControlGndr";
            this.labelControlGndr.Size = new System.Drawing.Size(41, 16);
            this.labelControlGndr.TabIndex = 49;
            this.labelControlGndr.Text = "Gender";
            // 
            // labelControlSSN
            // 
            this.labelControlSSN.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlSSN.Appearance.Options.UseFont = true;
            this.labelControlSSN.Location = new System.Drawing.Point(32, 182);
            this.labelControlSSN.Name = "labelControlSSN";
            this.labelControlSSN.Size = new System.Drawing.Size(24, 16);
            this.labelControlSSN.TabIndex = 48;
            this.labelControlSSN.Text = "SSN";
            // 
            // textEditSSN
            // 
            this.textEditSSN.Location = new System.Drawing.Point(121, 178);
            this.textEditSSN.Name = "textEditSSN";
            this.textEditSSN.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditSSN.Properties.Appearance.Options.UseFont = true;
            this.textEditSSN.Properties.AutoHeight = false;
            this.textEditSSN.Size = new System.Drawing.Size(155, 25);
            this.textEditSSN.TabIndex = 47;
            this.textEditSSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditSSN_KeyPress);
            // 
            // labelControlDOB
            // 
            this.labelControlDOB.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlDOB.Appearance.Options.UseFont = true;
            this.labelControlDOB.Location = new System.Drawing.Point(32, 142);
            this.labelControlDOB.Name = "labelControlDOB";
            this.labelControlDOB.Size = new System.Drawing.Size(71, 16);
            this.labelControlDOB.TabIndex = 46;
            this.labelControlDOB.Text = "Data of birth";
            // 
            // labelControlFnm
            // 
            this.labelControlFnm.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlFnm.Appearance.Options.UseFont = true;
            this.labelControlFnm.Location = new System.Drawing.Point(32, 102);
            this.labelControlFnm.Name = "labelControlFnm";
            this.labelControlFnm.Size = new System.Drawing.Size(57, 16);
            this.labelControlFnm.TabIndex = 45;
            this.labelControlFnm.Text = "Firstname";
            // 
            // textEditFnm
            // 
            this.textEditFnm.Location = new System.Drawing.Point(121, 98);
            this.textEditFnm.Name = "textEditFnm";
            this.textEditFnm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditFnm.Properties.Appearance.Options.UseFont = true;
            this.textEditFnm.Properties.AutoHeight = false;
            this.textEditFnm.Size = new System.Drawing.Size(155, 25);
            this.textEditFnm.TabIndex = 44;
            this.textEditFnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditLnm_KeyPress);
            // 
            // labelControlLnm
            // 
            this.labelControlLnm.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlLnm.Appearance.Options.UseFont = true;
            this.labelControlLnm.Location = new System.Drawing.Point(32, 62);
            this.labelControlLnm.Name = "labelControlLnm";
            this.labelControlLnm.Size = new System.Drawing.Size(55, 16);
            this.labelControlLnm.TabIndex = 43;
            this.labelControlLnm.Text = "Lastname";
            // 
            // textEditLnm
            // 
            this.textEditLnm.Location = new System.Drawing.Point(121, 58);
            this.textEditLnm.Name = "textEditLnm";
            this.textEditLnm.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditLnm.Properties.Appearance.Options.UseFont = true;
            this.textEditLnm.Properties.AutoHeight = false;
            this.textEditLnm.Size = new System.Drawing.Size(155, 25);
            this.textEditLnm.TabIndex = 42;
            this.textEditLnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditLnm_KeyPress);
            // 
            // labelControlID
            // 
            this.labelControlID.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlID.Appearance.Options.UseFont = true;
            this.labelControlID.Location = new System.Drawing.Point(32, 22);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(70, 16);
            this.labelControlID.TabIndex = 41;
            this.labelControlID.Text = "ID of Patient";
            // 
            // textEditIdPatient
            // 
            this.textEditIdPatient.Enabled = false;
            this.textEditIdPatient.Location = new System.Drawing.Point(121, 18);
            this.textEditIdPatient.Name = "textEditIdPatient";
            this.textEditIdPatient.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textEditIdPatient.Properties.Appearance.Options.UseFont = true;
            this.textEditIdPatient.Properties.AutoHeight = false;
            this.textEditIdPatient.Size = new System.Drawing.Size(155, 25);
            this.textEditIdPatient.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 316);
            this.Controls.Add(this.gridControlRelatives);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRelatives)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditGndr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSSN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLnm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdPatient.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.DateEdit dateEditDOB;
        public DevExpress.XtraEditors.ComboBoxEdit comboBoxEditGndr;
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
        public DevExpress.XtraGrid.GridControl gridControlRelatives;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Button buttonCancel;
    }
}