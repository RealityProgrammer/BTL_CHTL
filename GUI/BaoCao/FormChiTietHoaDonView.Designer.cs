using System.ComponentModel;

namespace CHTL.GUI.BaoCao {
    partial class FormChiTietHoaDonView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelReceiptId = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.panelProductDetails = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReceiptId
            // 
            this.labelReceiptId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelReceiptId.Location = new System.Drawing.Point(10, 10);
            this.labelReceiptId.Name = "labelReceiptId";
            this.labelReceiptId.Size = new System.Drawing.Size(812, 44);
            this.labelReceiptId.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.labelReceiptId.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.labelReceiptId.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReceiptId.TabIndex = 0;
            this.labelReceiptId.Values.Text = "<Mã hóa đơn>";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.labelReceiptId);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.kryptonPanel1.Size = new System.Drawing.Size(832, 64);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPanel1.TabIndex = 1;
            // 
            // panelProductDetails
            // 
            this.panelProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDetails.Location = new System.Drawing.Point(0, 64);
            this.panelProductDetails.Name = "panelProductDetails";
            this.panelProductDetails.Padding = new System.Windows.Forms.Padding(8);
            this.panelProductDetails.Size = new System.Drawing.Size(832, 274);
            this.panelProductDetails.TabIndex = 2;
            // 
            // FormChiTietHoaDonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 338);
            this.Controls.Add(this.panelProductDetails);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "FormChiTietHoaDonView";
            this.Text = "FormChiTietHoaDonView";
            this.Load += new System.EventHandler(this.FormChiTietHoaDonView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.Panel panelProductDetails;
        private Krypton.Toolkit.KryptonLabel labelReceiptId;
        public Krypton.Toolkit.KryptonPanel kryptonPanel1;

        #endregion
    }
}