namespace ClientHospitalApp.Views
{
    partial class OrderStatusLookUpEdit
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
            this.labelOrderStatus = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditOrderStatus = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditOrderStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelOrderStatus
            // 
            this.labelOrderStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOrderStatus.Appearance.Options.UseFont = true;
            this.labelOrderStatus.Location = new System.Drawing.Point(6, 13);
            this.labelOrderStatus.Name = "labelOrderStatus";
            this.labelOrderStatus.Size = new System.Drawing.Size(85, 14);
            this.labelOrderStatus.TabIndex = 0;
            this.labelOrderStatus.Text = "Status of Order";
            // 
            // lookUpEditOrderStatus
            // 
            this.lookUpEditOrderStatus.Location = new System.Drawing.Point(118, 10);
            this.lookUpEditOrderStatus.Name = "lookUpEditOrderStatus";
            this.lookUpEditOrderStatus.Properties.AutoHeight = false;
            this.lookUpEditOrderStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditOrderStatus.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditOrderStatus.TabIndex = 1;
            // 
            // OrderStatusLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditOrderStatus);
            this.Controls.Add(this.labelOrderStatus);
            this.Name = "OrderStatusLookUpEdit";
            this.Size = new System.Drawing.Size(269, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditOrderStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelOrderStatus;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditOrderStatus;
    }
}