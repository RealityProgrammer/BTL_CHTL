using System.ComponentModel;

namespace CHTL.GUI.BanHang {
    partial class FormThanhToanQR {
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
            Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
            System.Windows.Forms.Panel panel1;
            Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
            this.btnHuy = new Krypton.Toolkit.KryptonButton();
            this.btnOK = new Krypton.Toolkit.KryptonButton();
            this.pbQR = new Krypton.Toolkit.KryptonPictureBox();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            panel1 = new System.Windows.Forms.Panel();
            kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonTableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            kryptonTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.ColumnCount = 5;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            kryptonTableLayoutPanel1.Controls.Add(this.btnHuy, 3, 1);
            kryptonTableLayoutPanel1.Controls.Add(this.btnOK, 1, 1);
            kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            kryptonTableLayoutPanel1.Location = new System.Drawing.Point(0, 339);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 3;
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            kryptonTableLayoutPanel1.Size = new System.Drawing.Size(464, 93);
            kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel1.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.Location = new System.Drawing.Point(255, 23);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(166, 47);
            this.btnHuy.StateCommon.Border.Rounding = 16F;
            this.btnHuy.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHuy.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnHuy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHuy.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnHuy.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnHuy.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.btnHuy.TabIndex = 1;
            this.btnHuy.TabStop = false;
            this.btnHuy.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnHuy.Values.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(43, 23);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(166, 47);
            this.btnOK.StateCommon.Border.Rounding = 16F;
            this.btnOK.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.StatePressed.Back.Color1 = System.Drawing.Color.Lime;
            this.btnOK.StatePressed.Back.Color2 = System.Drawing.Color.Lime;
            this.btnOK.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnOK.TabIndex = 2;
            this.btnOK.TabStop = false;
            this.btnOK.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnOK.Values.Text = "Xong";
            this.btnOK.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panel1
            // 
            panel1.Controls.Add(kryptonTableLayoutPanel2);
            panel1.Controls.Add(this.labelTrangThai);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(464, 280);
            panel1.TabIndex = 2;
            // 
            // kryptonTableLayoutPanel2
            // 
            kryptonTableLayoutPanel2.ColumnCount = 3;
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.Controls.Add(this.pbQR, 1, 0);
            kryptonTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            kryptonTableLayoutPanel2.RowCount = 1;
            kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            kryptonTableLayoutPanel2.Size = new System.Drawing.Size(464, 255);
            kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel2.TabIndex = 2;
            // 
            // pbQR
            // 
            this.pbQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQR.Location = new System.Drawing.Point(104, 0);
            this.pbQR.Margin = new System.Windows.Forms.Padding(0);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(255, 255);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQR.TabIndex = 1;
            this.pbQR.TabStop = false;
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThai.Location = new System.Drawing.Point(0, 255);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(464, 25);
            this.labelTrangThai.TabIndex = 0;
            this.labelTrangThai.Text = "Mã QR đang được tạo...";
            this.labelTrangThai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(464, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "THANH TOÁN BẰNG MÃ QR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThanhToanQR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(464, 432);
            this.Controls.Add(panel1);
            this.Controls.Add(kryptonTableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(480, 480);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FormThanhToanQR";
            this.Text = "Thanh toán QR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThanhToanQR_FormClosed);
            kryptonTableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            kryptonTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);
        }
        private Krypton.Toolkit.KryptonPictureBox pbQR;
        private System.Windows.Forms.Label labelTrangThai;
        private Krypton.Toolkit.KryptonButton btnHuy;
        private Krypton.Toolkit.KryptonButton btnOK;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}