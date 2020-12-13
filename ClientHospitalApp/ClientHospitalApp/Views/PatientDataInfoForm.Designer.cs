namespace ClientHospitalApp.Views
{
    partial class PatientDataInfoForm
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
            ClientHospitalApp.ClientEntities.PatientClient patientClient1 = new ClientHospitalApp.ClientEntities.PatientClient();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientDataInfoForm));
            this.patientSearchExtendForm1 = new ClientHospitalApp.Views.PatientSearchExtendForm();
            this.SuspendLayout();
            // 
            // patientSearchExtendForm1
            // 
            this.patientSearchExtendForm1.GenderDataSource = null;
            this.patientSearchExtendForm1.Location = new System.Drawing.Point(12, 12);
            this.patientSearchExtendForm1.Name = "patientSearchExtendForm1";
            patientClient1.DOB = new System.DateTime(((long)(0)));
            patientClient1.Firstname = "";
            patientClient1.Gender = new ServiceReferenceDAOLayer.Gender();
            patientClient1.ID_Patient = -1;
            patientClient1.Lastname = "";
            patientClient1.RelativeList = ((System.Collections.Generic.List<ClientHospitalApp.ServiceReferenceDAOLayer.Relative>)(resources.GetObject("patientClient1.RelativeList")));
            patientClient1.SSN = 0;
            this.patientSearchExtendForm1.PatientData = patientClient1;
            this.patientSearchExtendForm1.Size = new System.Drawing.Size(779, 306);
            this.patientSearchExtendForm1.TabIndex = 0;
            // 
            // PatientDataInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 342);
            this.Controls.Add(this.patientSearchExtendForm1);
            this.Name = "PatientDataInfoForm";
            this.Text = "PatientDataInfoForm";
            this.ResumeLayout(false);

        }

        #endregion

        public PatientSearchExtendForm patientSearchExtendForm1;
    }
}