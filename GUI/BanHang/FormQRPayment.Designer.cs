namespace CHTL.GUI.BanHang
{
    partial class FormQRPayment
    {
        private System.ComponentModel.IContainer components = null;

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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.labelLoading = new Krypton.Toolkit.KryptonLabel();
            this.lblInstruction = new Krypton.Toolkit.KryptonLabel();
            this.pbQRCode = new System.Windows.Forms.PictureBox();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.btnOk = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.kryptonPanel1.Size = new System.Drawing.Size(450, 80);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(52, 152, 219);
            //this.kryptonPanel1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            //this.kryptonPanel1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            //    | Krypton.Toolkit.PaletteDrawBorders.Left)
            //    | Krypton.Toolkit.PaletteDrawBorders.Right)));
            //this.kryptonPanel1.StateCommon.Border.Rounding = 10F;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(80, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(350, 40);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 4;
            this.kryptonLabel1.Values.Text = "THANH TOÁN QUA MÃ QR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.labelLoading);
            this.kryptonPanel2.Controls.Add(this.lblInstruction);
            this.kryptonPanel2.Controls.Add(this.pbQRCode);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 80);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(450, 340);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(236, 240, 241);
            //this.kryptonPanel2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // labelLoading
            // 
            //this.labelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLoading.Location = new System.Drawing.Point(80, 280);
            this.labelLoading.Name = "labelLoading";
            this.labelLoading.Size = new System.Drawing.Size(450, 340);
            this.labelLoading.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(44, 62, 80);
            this.labelLoading.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelLoading.TabIndex = 3;
            this.labelLoading.Values.Text = "Mã QR đang được tạo...";
            //this.labelLoading.Values.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Location = new System.Drawing.Point(80, 280);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(290, 30);
            this.lblInstruction.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(44, 62, 80);
            this.lblInstruction.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblInstruction.TabIndex = 1;
            this.lblInstruction.Values.Text = "Quét mã QR để thanh toán ";
            // 
            // pbQRCode
            // 
            this.pbQRCode.Location = new System.Drawing.Point(100, 20);
            this.pbQRCode.Name = "pbQRCode";
            this.pbQRCode.Size = new System.Drawing.Size(250, 250);
            this.pbQRCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQRCode.TabIndex = 0;
            this.pbQRCode.TabStop = false;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btnClose);
            this.kryptonPanel3.Controls.Add(this.btnOk);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 420);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Padding = new System.Windows.Forms.Padding(15);
            this.kryptonPanel3.Size = new System.Drawing.Size(450, 80);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(236, 240, 241);
            //this.kryptonPanel3.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.kryptonPanel3.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(330, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 10F;
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.TabIndex = 2;
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
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(200, 20);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(120, 40);
            this.btnOk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnOk.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnOk.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            this.btnOk.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnOk.StateCommon.Border.Rounding = 10F;
            this.btnOk.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnOk.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnOk.TabIndex = 1;
            this.btnOk.Values.Text = "OK";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler((s, e) =>
            {
                btnOk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(41, 128, 185);
                btnOk.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(41, 128, 185);
            });
            this.btnOk.MouseLeave += new System.EventHandler((s, e) =>
            {
                btnOk.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(52, 152, 219);
                btnOk.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(52, 152, 219);
            });
            // 
            // FormQRPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Controls.Add(this.kryptonPanel3);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQRPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán qua mã QR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQRPayment_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonLabel labelLoading;
        private Krypton.Toolkit.KryptonLabel lblInstruction;
        private System.Windows.Forms.PictureBox pbQRCode;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton btnClose;
        private Krypton.Toolkit.KryptonButton btnOk;
    }
}