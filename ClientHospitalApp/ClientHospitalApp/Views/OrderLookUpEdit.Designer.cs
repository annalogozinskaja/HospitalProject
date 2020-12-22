namespace ClientHospitalApp.Views
{
    partial class OrderLookUpEdit
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
            this.labelControlOrder = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditOrder = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditOrder.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControlOrder
            // 
            this.labelControlOrder.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControlOrder.Appearance.Options.UseFont = true;
            this.labelControlOrder.Location = new System.Drawing.Point(7, 12);
            this.labelControlOrder.Name = "labelControlOrder";
            this.labelControlOrder.Size = new System.Drawing.Size(31, 14);
            this.labelControlOrder.TabIndex = 0;
            this.labelControlOrder.Text = "Order";
            // 
            // lookUpEditOrder
            // 
            this.lookUpEditOrder.Location = new System.Drawing.Point(119, 9);
            this.lookUpEditOrder.Name = "lookUpEditOrder";
            this.lookUpEditOrder.Properties.AutoHeight = false;
            this.lookUpEditOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditOrder.Size = new System.Drawing.Size(145, 22);
            this.lookUpEditOrder.TabIndex = 1;
            // 
            // OrderLookUpEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lookUpEditOrder);
            this.Controls.Add(this.labelControlOrder);
            this.Name = "OrderLookUpEdit";
            this.Size = new System.Drawing.Size(269, 40);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditOrder.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControlOrder;
        public DevExpress.XtraEditors.LookUpEdit lookUpEditOrder;
    }
}