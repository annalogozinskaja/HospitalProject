﻿namespace ClientHospitalApp.Views
{
    partial class PatientSearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientSearchForm));
            this.patientDetail1 = new ClientHospitalApp.PatientDetail();
            this.SuspendLayout();
            // 
            // patientDetail1
            // 
            this.patientDetail1.DataSourceGender = null;
            this.patientDetail1.Location = new System.Drawing.Point(2, 2);
            this.patientDetail1.Name = "patientDetail1";
            this.patientDetail1.PatientData = ((ClientHospitalApp.ServiceReferenceDAOLayer.Patient)(resources.GetObject("patientDetail1.PatientData")));
            this.patientDetail1.Size = new System.Drawing.Size(283, 307);
            this.patientDetail1.TabIndex = 0;
            // 
            // PatientSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 311);
            this.Controls.Add(this.patientDetail1);
            this.Name = "PatientSearchForm";
            this.Text = "PatientSearchForm";
            this.ResumeLayout(false);

        }

        #endregion

        public PatientDetail patientDetail1;
    }
}