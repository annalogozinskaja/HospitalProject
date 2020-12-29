namespace ClientHospitalApp.Views
{
    partial class TestDetail
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
            this.testNameLookUpEdit = new ClientHospitalApp.Views.TestNameLookUpEdit();
            this.labelControlDateStart = new DevExpress.XtraEditors.LabelControl();
            this.labelControlDateEnd = new DevExpress.XtraEditors.LabelControl();
            this.labelControlResult = new DevExpress.XtraEditors.LabelControl();
            this.dateEditDateStart = new DevExpress.XtraEditors.DateEdit();
            this.dateEditDateEnd = new DevExpress.XtraEditors.DateEdit();
            this.textEditResult = new DevExpress.XtraEditors.TextEdit();
            this.textEditIDTest = new DevExpress.XtraEditors.TextEdit();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResult.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIDTest.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlID
            // 
            this.labelControlID.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlID.Appearance.Options.UseFont = true;
            this.labelControlID.Location = new System.Drawing.Point(12, 10);
            this.labelControlID.Name = "labelControlID";
            this.labelControlID.Size = new System.Drawing.Size(56, 14);
            this.labelControlID.TabIndex = 0;
            this.labelControlID.Text = "ID of Test";
            // 
            // testNameLookUpEdit
            // 
            this.testNameLookUpEdit.Location = new System.Drawing.Point(5, 33);
            this.testNameLookUpEdit.Name = "testNameLookUpEdit";
            this.testNameLookUpEdit.Size = new System.Drawing.Size(252, 38);
            this.testNameLookUpEdit.TabIndex = 2;
            this.testNameLookUpEdit.TestName = null;
            this.testNameLookUpEdit.TestNameDataSource = null;
            // 
            // labelControlDateStart
            // 
            this.labelControlDateStart.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlDateStart.Appearance.Options.UseFont = true;
            this.labelControlDateStart.Location = new System.Drawing.Point(12, 79);
            this.labelControlDateStart.Name = "labelControlDateStart";
            this.labelControlDateStart.Size = new System.Drawing.Size(55, 14);
            this.labelControlDateStart.TabIndex = 3;
            this.labelControlDateStart.Text = "Date start";
            // 
            // labelControlDateEnd
            // 
            this.labelControlDateEnd.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlDateEnd.Appearance.Options.UseFont = true;
            this.labelControlDateEnd.Location = new System.Drawing.Point(13, 115);
            this.labelControlDateEnd.Name = "labelControlDateEnd";
            this.labelControlDateEnd.Size = new System.Drawing.Size(51, 14);
            this.labelControlDateEnd.TabIndex = 4;
            this.labelControlDateEnd.Text = "Date end";
            // 
            // labelControlResult
            // 
            this.labelControlResult.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlResult.Appearance.Options.UseFont = true;
            this.labelControlResult.Location = new System.Drawing.Point(14, 152);
            this.labelControlResult.Name = "labelControlResult";
            this.labelControlResult.Size = new System.Drawing.Size(33, 14);
            this.labelControlResult.TabIndex = 5;
            this.labelControlResult.Text = "Result";
            // 
            // dateEditDateStart
            // 
            this.dateEditDateStart.EditValue = null;
            this.dateEditDateStart.Location = new System.Drawing.Point(105, 76);
            this.dateEditDateStart.Name = "dateEditDateStart";
            this.dateEditDateStart.Properties.AutoHeight = false;
            this.dateEditDateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateStart.Size = new System.Drawing.Size(145, 22);
            this.dateEditDateStart.TabIndex = 6;
            // 
            // dateEditDateEnd
            // 
            this.dateEditDateEnd.EditValue = null;
            this.dateEditDateEnd.Location = new System.Drawing.Point(105, 112);
            this.dateEditDateEnd.Name = "dateEditDateEnd";
            this.dateEditDateEnd.Properties.AutoHeight = false;
            this.dateEditDateEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateEnd.Size = new System.Drawing.Size(145, 22);
            this.dateEditDateEnd.TabIndex = 7;
            // 
            // textEditResult
            // 
            this.textEditResult.Location = new System.Drawing.Point(105, 148);
            this.textEditResult.Name = "textEditResult";
            this.textEditResult.Properties.AutoHeight = false;
            this.textEditResult.Size = new System.Drawing.Size(145, 22);
            this.textEditResult.TabIndex = 8;
            // 
            // textEditIDTest
            // 
            this.textEditIDTest.Location = new System.Drawing.Point(105, 6);
            this.textEditIDTest.Name = "textEditIDTest";
            this.textEditIDTest.Properties.AutoHeight = false;
            this.textEditIDTest.Size = new System.Drawing.Size(145, 22);
            this.textEditIDTest.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOK.Location = new System.Drawing.Point(28, 200);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(70, 28);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(150, 200);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 28);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Clear";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // TestDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 241);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textEditIDTest);
            this.Controls.Add(this.textEditResult);
            this.Controls.Add(this.dateEditDateEnd);
            this.Controls.Add(this.dateEditDateStart);
            this.Controls.Add(this.labelControlResult);
            this.Controls.Add(this.labelControlDateEnd);
            this.Controls.Add(this.labelControlDateStart);
            this.Controls.Add(this.testNameLookUpEdit);
            this.Controls.Add(this.labelControlID);
            this.Name = "TestDetail";
            this.Text = "TestDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditResult.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditIDTest.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlID;
        private TestNameLookUpEdit testNameLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControlDateStart;
        private DevExpress.XtraEditors.LabelControl labelControlDateEnd;
        private DevExpress.XtraEditors.LabelControl labelControlResult;
        private DevExpress.XtraEditors.DateEdit dateEditDateStart;
        private DevExpress.XtraEditors.DateEdit dateEditDateEnd;
        private DevExpress.XtraEditors.TextEdit textEditResult;
        private DevExpress.XtraEditors.TextEdit textEditIDTest;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
    }
}