namespace ClientHospitalApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.buttonGetPatient = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.labelFirstname = new System.Windows.Forms.Label();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelSSN = new System.Windows.Forms.Label();
            this.labelIDGender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter ID of Patient:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(180, 28);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(118, 24);
            this.textBoxID.TabIndex = 1;
            // 
            // buttonGetPatient
            // 
            this.buttonGetPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetPatient.Location = new System.Drawing.Point(317, 27);
            this.buttonGetPatient.Name = "buttonGetPatient";
            this.buttonGetPatient.Size = new System.Drawing.Size(80, 25);
            this.buttonGetPatient.TabIndex = 2;
            this.buttonGetPatient.Text = "OK";
            this.buttonGetPatient.UseVisualStyleBackColor = true;
            this.buttonGetPatient.Click += new System.EventHandler(this.buttonGetPatient_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID.Location = new System.Drawing.Point(33, 95);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 18);
            this.labelID.TabIndex = 3;
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastname.Location = new System.Drawing.Point(33, 130);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(0, 18);
            this.labelLastname.TabIndex = 4;
            // 
            // labelFirstname
            // 
            this.labelFirstname.AutoSize = true;
            this.labelFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstname.Location = new System.Drawing.Point(36, 169);
            this.labelFirstname.Name = "labelFirstname";
            this.labelFirstname.Size = new System.Drawing.Size(0, 18);
            this.labelFirstname.TabIndex = 5;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDOB.Location = new System.Drawing.Point(34, 202);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(0, 18);
            this.labelDOB.TabIndex = 6;
            // 
            // labelSSN
            // 
            this.labelSSN.AutoSize = true;
            this.labelSSN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSSN.Location = new System.Drawing.Point(36, 233);
            this.labelSSN.Name = "labelSSN";
            this.labelSSN.Size = new System.Drawing.Size(0, 18);
            this.labelSSN.TabIndex = 7;
            // 
            // labelIDGender
            // 
            this.labelIDGender.AutoSize = true;
            this.labelIDGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIDGender.Location = new System.Drawing.Point(37, 267);
            this.labelIDGender.Name = "labelIDGender";
            this.labelIDGender.Size = new System.Drawing.Size(0, 18);
            this.labelIDGender.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelIDGender);
            this.Controls.Add(this.labelSSN);
            this.Controls.Add(this.labelDOB);
            this.Controls.Add(this.labelFirstname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.buttonGetPatient);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGetPatient;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.Label labelFirstname;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelSSN;
        private System.Windows.Forms.Label labelIDGender;
        private System.Windows.Forms.TextBox textBoxID;
    }
}

