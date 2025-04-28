using System.ComponentModel;

namespace CHTL.GUI.BaoCao
{
    partial class FormChiTietHoaDonView
    {
        private IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelReceiptId = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.panelProductDetails = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelReceiptId
            // 
            this.labelReceiptId.Location = new System.Drawing.Point(20, 20);
            this.labelReceiptId.Name = "labelReceiptId";
            this.labelReceiptId.Size = new System.Drawing.Size(400, 40);
            this.labelReceiptId.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.labelReceiptId.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelReceiptId.TabIndex = 0;
            this.labelReceiptId.Values.Text = "<Mã hóa đơn>";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnClose);
            this.kryptonPanel1.Controls.Add(this.labelReceiptId);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.kryptonPanel1.Size = new System.Drawing.Size(600, 80);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(52, 152, 219);
            //this.kryptonPanel1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            //this.kryptonPanel1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            //    | Krypton.Toolkit.PaletteDrawBorders.Left)
            //    | Krypton.Toolkit.PaletteDrawBorders.Right)));
            //this.kryptonPanel1.StateCommon.Border.Rounding = 10F;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(450, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 40);
            this.btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 10F;
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.TabIndex = 1;
            this.btnClose.Values.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler((s, e) =>
            {
                btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(230, 126, 34);
                btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(230, 126, 34);
            });
            this.btnClose.MouseLeave += new System.EventHandler((s, e) =>
            {
                btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(243, 156, 18);
                btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(243, 156, 18);
            });
            // 
            // panelProductDetails
            // 
            this.panelProductDetails.AutoScroll = true;
            this.panelProductDetails.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panelProductDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductDetails.Location = new System.Drawing.Point(0, 80);
            this.panelProductDetails.Name = "panelProductDetails";
            this.panelProductDetails.Padding = new System.Windows.Forms.Padding(10);
            this.panelProductDetails.Size = new System.Drawing.Size(600, 420);
            this.panelProductDetails.TabIndex = 2;
            // 
            // FormChiTietHoaDonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.panelProductDetails);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChiTietHoaDonView";
            this.Text = "Chi Tiết Hóa Đơn";
            this.Load += new System.EventHandler(this.FormChiTietHoaDonView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelProductDetails;
        private Krypton.Toolkit.KryptonLabel labelReceiptId;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonButton btnClose;

        #endregion
    }
}