namespace ClientHospitalApp.Views
{
    partial class OrderDetail
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
            this.labelID = new DevExpress.XtraEditors.LabelControl();
            this.textEditID = new DevExpress.XtraEditors.TextEdit();
            this.labelDateOrder = new DevExpress.XtraEditors.LabelControl();
            this.labelSymptoms = new DevExpress.XtraEditors.LabelControl();
            this.textEditSymptoms = new DevExpress.XtraEditors.TextEdit();
            this.dateEditDateOrder = new DevExpress.XtraEditors.DateEdit();
            this.patientLookUpEdit = new ClientHospitalApp.Views.PatientLookUpEdit();
            this.doctorLookUpEdit = new ClientHospitalApp.Views.DoctorLookUpEdit();
            this.orderStatusLookUpEdit = new ClientHospitalApp.Views.OrderStatusLookUpEdit();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSymptoms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOrder.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOrder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Appearance.Options.UseFont = true;
            this.labelID.Location = new System.Drawing.Point(12, 10);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(62, 14);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID of Order";
            // 
            // textEditID
            // 
            this.textEditID.Location = new System.Drawing.Point(123, 7);
            this.textEditID.Name = "textEditID";
            this.textEditID.Properties.AutoHeight = false;
            this.textEditID.Size = new System.Drawing.Size(145, 20);
            this.textEditID.TabIndex = 2;
            // 
            // labelDateOrder
            // 
            this.labelDateOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDateOrder.Appearance.Options.UseFont = true;
            this.labelDateOrder.Location = new System.Drawing.Point(12, 43);
            this.labelDateOrder.Name = "labelDateOrder";
            this.labelDateOrder.Size = new System.Drawing.Size(76, 14);
            this.labelDateOrder.TabIndex = 3;
            this.labelDateOrder.Text = "Date of Order";
            // 
            // labelSymptoms
            // 
            this.labelSymptoms.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSymptoms.Appearance.Options.UseFont = true;
            this.labelSymptoms.Location = new System.Drawing.Point(11, 80);
            this.labelSymptoms.Name = "labelSymptoms";
            this.labelSymptoms.Size = new System.Drawing.Size(57, 14);
            this.labelSymptoms.TabIndex = 4;
            this.labelSymptoms.Text = "Symptoms";
            // 
            // textEditSymptoms
            // 
            this.textEditSymptoms.Location = new System.Drawing.Point(124, 77);
            this.textEditSymptoms.Name = "textEditSymptoms";
            this.textEditSymptoms.Properties.AutoHeight = false;
            this.textEditSymptoms.Size = new System.Drawing.Size(145, 22);
            this.textEditSymptoms.TabIndex = 5;
            // 
            // dateEditDateOrder
            // 
            this.dateEditDateOrder.EditValue = null;
            this.dateEditDateOrder.Location = new System.Drawing.Point(124, 41);
            this.dateEditDateOrder.Name = "dateEditDateOrder";
            this.dateEditDateOrder.Properties.AutoHeight = false;
            this.dateEditDateOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateOrder.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateOrder.Size = new System.Drawing.Size(145, 22);
            this.dateEditDateOrder.TabIndex = 6;
            // 
            // patientLookUpEdit
            // 
            this.patientLookUpEdit.Location = new System.Drawing.Point(5, 104);
            this.patientLookUpEdit.Name = "patientLookUpEdit";
            this.patientLookUpEdit.Patient = null;
            this.patientLookUpEdit.PatientDataSource = null;
            this.patientLookUpEdit.Size = new System.Drawing.Size(269, 40);
            this.patientLookUpEdit.TabIndex = 7;
            // 
            // doctorLookUpEdit
            // 
            this.doctorLookUpEdit.Doctor = null;
            this.doctorLookUpEdit.DoctorDataSource = null;
            this.doctorLookUpEdit.Location = new System.Drawing.Point(5, 141);
            this.doctorLookUpEdit.Name = "doctorLookUpEdit";
            this.doctorLookUpEdit.Size = new System.Drawing.Size(269, 40);
            this.doctorLookUpEdit.TabIndex = 8;
            // 
            // orderStatusLookUpEdit
            // 
            this.orderStatusLookUpEdit.Location = new System.Drawing.Point(5, 175);
            this.orderStatusLookUpEdit.Name = "orderStatusLookUpEdit";
            this.orderStatusLookUpEdit.OrderStatus = null;
            this.orderStatusLookUpEdit.OrderStatusDataSource = null;
            this.orderStatusLookUpEdit.Size = new System.Drawing.Size(269, 40);
            this.orderStatusLookUpEdit.TabIndex = 9;
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.Location = new System.Drawing.Point(169, 230);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(70, 28);
            this.buttonClear.TabIndex = 13;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(42, 230);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 28);
            this.buttonOK.TabIndex = 12;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // OrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.orderStatusLookUpEdit);
            this.Controls.Add(this.doctorLookUpEdit);
            this.Controls.Add(this.patientLookUpEdit);
            this.Controls.Add(this.dateEditDateOrder);
            this.Controls.Add(this.textEditSymptoms);
            this.Controls.Add(this.labelSymptoms);
            this.Controls.Add(this.labelDateOrder);
            this.Controls.Add(this.textEditID);
            this.Controls.Add(this.labelID);
            this.Name = "OrderDetail";
            this.Size = new System.Drawing.Size(280, 268);
            ((System.ComponentModel.ISupportInitialize)(this.textEditID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSymptoms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOrder.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOrder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelID;
        private DevExpress.XtraEditors.TextEdit textEditID;
        private DevExpress.XtraEditors.LabelControl labelDateOrder;
        private DevExpress.XtraEditors.LabelControl labelSymptoms;
        private DevExpress.XtraEditors.TextEdit textEditSymptoms;
        private DevExpress.XtraEditors.DateEdit dateEditDateOrder;
        private PatientLookUpEdit patientLookUpEdit;
        private DoctorLookUpEdit doctorLookUpEdit;
        private OrderStatusLookUpEdit orderStatusLookUpEdit;
        public System.Windows.Forms.Button buttonClear;
        public System.Windows.Forms.Button buttonOK;
    }
}