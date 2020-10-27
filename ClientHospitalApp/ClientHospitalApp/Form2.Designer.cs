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
            this.gridControlOrders = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
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
            this.buttonOK.Location = new System.Drawing.Point(336, 395);
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
            this.buttonCancel.Location = new System.Drawing.Point(471, 395);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 31);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // gridControlOrders
            // 
            this.gridControlOrders.Location = new System.Drawing.Point(461, 139);
            this.gridControlOrders.MainView = this.gridView2;
            this.gridControlOrders.Name = "gridControlOrders";
            this.gridControlOrders.Size = new System.Drawing.Size(400, 200);
            this.gridControlOrders.TabIndex = 53;
            this.gridControlOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControlOrders;
            this.gridView2.Name = "gridView2";
            // 
            // gridControlRelatives
            // 
            this.gridControlRelatives.Location = new System.Drawing.Point(25, 139);
            this.gridControlRelatives.MainView = this.gridView1;
            this.gridControlRelatives.Name = "gridControlRelatives";
            this.gridControlRelatives.Size = new System.Drawing.Size(399, 200);
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
            this.dateEditDOB.Location = new System.Drawing.Point(552, 22);
            this.dateEditDOB.Name = "dateEditDOB";
            this.dateEditDOB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDOB.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Vista;
            this.dateEditDOB.Properties.DisplayFormat.FormatString = "dd/MM/yy";
            this.dateEditDOB.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditDOB.Properties.EditFormat.FormatString = "dd/MM/yy";
            this.dateEditDOB.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditDOB.Properties.Mask.EditMask = "dd/MM/yy";
            this.dateEditDOB.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.True;
            this.dateEditDOB.Size = new System.Drawing.Size(165, 20);
            this.dateEditDOB.TabIndex = 51;
            // 
            // comboBoxEditGndr
            // 
            this.comboBoxEditGndr.Location = new System.Drawing.Point(552, 94);
            this.comboBoxEditGndr.Name = "comboBoxEditGndr";
            this.comboBoxEditGndr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditGndr.Size = new System.Drawing.Size(165, 20);
            this.comboBoxEditGndr.TabIndex = 50;
            // 
            // labelControlGndr
            // 
            this.labelControlGndr.Location = new System.Drawing.Point(461, 97);
            this.labelControlGndr.Name = "labelControlGndr";
            this.labelControlGndr.Size = new System.Drawing.Size(35, 13);
            this.labelControlGndr.TabIndex = 49;
            this.labelControlGndr.Text = "Gender";
            // 
            // labelControlSSN
            // 
            this.labelControlSSN.Location = new System.Drawing.Point(461, 61);
            this.labelControlSSN.Name = "labelControlSSN";
            this.labelControlSSN.Size = new System.Drawing.Size(19, 13);
            this.labelControlSSN.TabIndex = 48;
            this.labelControlSSN.Text = "SSN";
            // 
            // textEditSSN
            // 
            this.textEditSSN.Location = new System.Drawing.Point(552, 58);
            this.textEditSSN.Name = "textEditSSN";
            this.textEditSSN.Size = new System.Drawing.Size(165, 20);
            this.textEditSSN.TabIndex = 47;
            // 
            // labelControlDOB
            // 
            this.labelControlDOB.Location = new System.Drawing.Point(461, 25);
            this.labelControlDOB.Name = "labelControlDOB";
            this.labelControlDOB.Size = new System.Drawing.Size(61, 13);
            this.labelControlDOB.TabIndex = 46;
            this.labelControlDOB.Text = "Data of birth";
            // 
            // labelControlFnm
            // 
            this.labelControlFnm.Location = new System.Drawing.Point(30, 93);
            this.labelControlFnm.Name = "labelControlFnm";
            this.labelControlFnm.Size = new System.Drawing.Size(47, 13);
            this.labelControlFnm.TabIndex = 45;
            this.labelControlFnm.Text = "Firstname";
            // 
            // textEditFnm
            // 
            this.textEditFnm.Location = new System.Drawing.Point(121, 90);
            this.textEditFnm.Name = "textEditFnm";
            this.textEditFnm.Size = new System.Drawing.Size(155, 20);
            this.textEditFnm.TabIndex = 44;
            // 
            // labelControlLnm
            // 
            this.labelControlLnm.Location = new System.Drawing.Point(30, 57);
            this.labelControlLnm.Name = "labelControlLnm";
            this.labelControlLnm.Size = new System.Drawing.Size(46, 13);
            this.labelControlLnm.TabIndex = 43;
            this.labelControlLnm.Text = "Lastname";
            // 
            // textEditLnm
            // 
            this.textEditLnm.Location = new System.Drawing.Point(121, 54);
            this.textEditLnm.Name = "textEditLnm";
            this.textEditLnm.Size = new System.Drawing.Size(155, 20);
            this.textEditLnm.TabIndex = 42;
            // 
            // labelControlID
            // 
            this.labelControlID.Location = new System.Drawing.Point(30, 21);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(61, 13);
            this.labelControlID.TabIndex = 41;
            this.labelControlID.Text = "ID of Patient";
            // 
            // textEditIdPatient
            // 
            this.textEditIdPatient.Enabled = false;
            this.textEditIdPatient.Location = new System.Drawing.Point(121, 18);
            this.textEditIdPatient.Name = "textEditIdPatient";
            this.textEditIdPatient.Size = new System.Drawing.Size(155, 20);
            this.textEditIdPatient.TabIndex = 40;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 448);
            this.Controls.Add(this.gridControlOrders);
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
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
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
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
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
        public DevExpress.XtraGrid.GridControl gridControlOrders;
        public DevExpress.XtraGrid.GridControl gridControlRelatives;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Button buttonCancel;
    }
}