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
            this.labelControlDate = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControlNurse = new DevExpress.XtraEditors.LabelControl();
            this.textEditNurse = new DevExpress.XtraEditors.TextEdit();
            this.orderLookUpEdit = new ClientHospitalApp.Views.OrderLookUpEdit();
            this.specimentNameLookUpEdit = new ClientHospitalApp.Views.SpecimentNameLookUpEdit();
            this.specimentStatusLookUpEdit = new ClientHospitalApp.Views.SpecimentStatusLookUpEdit();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdSpeciment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNurse.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlID
            // 
            this.labelControlID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlID.Appearance.Options.UseFont = true;
            this.labelControlID.Location = new System.Drawing.Point(8, 15);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(89, 14);
            this.labelControlID.TabIndex = 0;
            this.labelControlID.Text = "ID of Speciment";
            // 
            // textEditIdSpeciment
            // 
            this.textEditIdSpeciment.Location = new System.Drawing.Point(119, 12);
            this.textEditIdSpeciment.Name = "textEditIdSpeciment";
            this.textEditIdSpeciment.Properties.AutoHeight = false;
            this.textEditIdSpeciment.Size = new System.Drawing.Size(145, 22);
            this.textEditIdSpeciment.TabIndex = 1;
            // 
            // labelControlDate
            // 
            this.labelControlDate.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlDate.Appearance.Options.UseFont = true;
            this.labelControlDate.Location = new System.Drawing.Point(8, 88);
            this.labelControlDate.Name = "labelControlDate";
            this.labelControlDate.Size = new System.Drawing.Size(81, 14);
            this.labelControlDate.TabIndex = 3;
            this.labelControlDate.Text = "Date of Taking";
            // 
            // dateEditDate
            // 
            this.dateEditDate.EditValue = null;
            this.dateEditDate.Location = new System.Drawing.Point(119, 84);
            this.dateEditDate.Name = "dateEditDate";
            this.dateEditDate.Properties.AutoHeight = false;
            this.dateEditDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDate.Size = new System.Drawing.Size(145, 22);
            this.dateEditDate.TabIndex = 5;
            // 
            // labelControlNurse
            // 
            this.labelControlNurse.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlNurse.Appearance.Options.UseFont = true;
            this.labelControlNurse.Location = new System.Drawing.Point(8, 125);
            this.labelControlNurse.Name = "labelControlNurse";
            this.labelControlNurse.Size = new System.Drawing.Size(31, 14);
            this.labelControlNurse.TabIndex = 6;
            this.labelControlNurse.Text = "Nurse";
            // 
            // textEditNurse
            // 
            this.textEditNurse.Location = new System.Drawing.Point(119, 121);
            this.textEditNurse.Name = "textEditNurse";
            this.textEditNurse.Properties.AutoHeight = false;
            this.textEditNurse.Size = new System.Drawing.Size(145, 22);
            this.textEditNurse.TabIndex = 7;
            this.textEditNurse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEditNurse_KeyPress);
            // 
            // orderLookUpEdit
            // 
            this.orderLookUpEdit.Location = new System.Drawing.Point(0, 148);
            this.orderLookUpEdit.Name = "orderLookUpEdit";
            this.orderLookUpEdit.Order = null;
            this.orderLookUpEdit.OrderDataSource = null;
            this.orderLookUpEdit.Size = new System.Drawing.Size(269, 40);
            this.orderLookUpEdit.TabIndex = 8;
            // 
            // specimentNameLookUpEdit
            // 
            this.specimentNameLookUpEdit.Location = new System.Drawing.Point(1, 38);
            this.specimentNameLookUpEdit.Name = "specimentNameLookUpEdit";
            this.specimentNameLookUpEdit.Size = new System.Drawing.Size(269, 40);
            this.specimentNameLookUpEdit.SpecimentName = null;
            this.specimentNameLookUpEdit.SpecimentNameDataSource = null;
            this.specimentNameLookUpEdit.TabIndex = 2;
            // 
            // specimentStatusLookUpEdit
            // 
            this.specimentStatusLookUpEdit.Location = new System.Drawing.Point(1, 186);
            this.specimentStatusLookUpEdit.Name = "specimentStatusLookUpEdit";
            this.specimentStatusLookUpEdit.Size = new System.Drawing.Size(269, 40);
            this.specimentStatusLookUpEdit.SpecimentNameDataSource = null;
            this.specimentStatusLookUpEdit.SpecimentStatus = null;
            this.specimentStatusLookUpEdit.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(41, 241);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 28);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(168, 241);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 28);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // SpecimentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.specimentStatusLookUpEdit);
            this.Controls.Add(this.orderLookUpEdit);
            this.Controls.Add(this.textEditNurse);
            this.Controls.Add(this.labelControlNurse);
            this.Controls.Add(this.dateEditDate);
            this.Controls.Add(this.labelControlDate);
            this.Controls.Add(this.specimentNameLookUpEdit);
            this.Controls.Add(this.textEditIdSpeciment);
            this.Controls.Add(this.labelControlID);
            this.Name = "SpecimentDetail";
            this.Size = new System.Drawing.Size(274, 281);
            ((System.ComponentModel.ISupportInitialize)(this.textEditIdSpeciment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditNurse.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlID;
        private DevExpress.XtraEditors.TextEdit textEditIdSpeciment;
        private SpecimentNameLookUpEdit specimentNameLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControlDate;
        private DevExpress.XtraEditors.DateEdit dateEditDate;
        private DevExpress.XtraEditors.LabelControl labelControlNurse;
        private DevExpress.XtraEditors.TextEdit textEditNurse;
        private OrderLookUpEdit orderLookUpEdit;
        private SpecimentStatusLookUpEdit specimentStatusLookUpEdit;
        public System.Windows.Forms.Button buttonOK;
        public System.Windows.Forms.Button buttonClear;
    }
}