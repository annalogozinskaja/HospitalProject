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
            this.labelIdPatient = new System.Windows.Forms.Label();
            this.textBoxIdPatient = new System.Windows.Forms.TextBox();
            this.textBoxLnm = new System.Windows.Forms.TextBox();
            this.labelLnm = new System.Windows.Forms.Label();
            this.textBoxFnm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            // labelIdPatient
            // 
            this.labelIdPatient.AutoSize = true;
            this.labelIdPatient.Location = new System.Drawing.Point(85, 33);
            this.labelIdPatient.Name = "labelIdPatient";
            this.labelIdPatient.Size = new System.Drawing.Size(66, 13);
            this.labelIdPatient.TabIndex = 2;
            this.labelIdPatient.Text = "ID of Patient";
            // 
            // textBoxIdPatient
            // 
            this.textBoxIdPatient.Location = new System.Drawing.Point(179, 33);
            this.textBoxIdPatient.Name = "textBoxIdPatient";
            this.textBoxIdPatient.Size = new System.Drawing.Size(130, 20);
            this.textBoxIdPatient.TabIndex = 3;
            // 
            // textBoxLnm
            // 
            this.textBoxLnm.Location = new System.Drawing.Point(179, 74);
            this.textBoxLnm.Name = "textBoxLnm";
            this.textBoxLnm.Size = new System.Drawing.Size(130, 20);
            this.textBoxLnm.TabIndex = 5;
            // 
            // labelLnm
            // 
            this.labelLnm.AutoSize = true;
            this.labelLnm.Location = new System.Drawing.Point(85, 74);
            this.labelLnm.Name = "labelLnm";
            this.labelLnm.Size = new System.Drawing.Size(53, 13);
            this.labelLnm.TabIndex = 4;
            this.labelLnm.Text = "Lastname";
            // 
            // textBoxFnm
            // 
            this.textBoxFnm.Location = new System.Drawing.Point(179, 113);
            this.textBoxFnm.Name = "textBoxFnm";
            this.textBoxFnm.Size = new System.Drawing.Size(130, 20);
            this.textBoxFnm.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Firstname";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 450);
            this.Controls.Add(this.textBoxFnm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLnm);
            this.Controls.Add(this.labelLnm);
            this.Controls.Add(this.textBoxIdPatient);
            this.Controls.Add(this.labelIdPatient);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelIdPatient;
        private System.Windows.Forms.TextBox textBoxIdPatient;
        private System.Windows.Forms.TextBox textBoxLnm;
        private System.Windows.Forms.Label labelLnm;
        private System.Windows.Forms.TextBox textBoxFnm;
        private System.Windows.Forms.Label label2;
    }
}