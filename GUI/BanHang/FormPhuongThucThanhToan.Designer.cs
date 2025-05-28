using System.ComponentModel;

namespace CHTL.GUI.BanHang {
    partial class FormPhuongThucThanhToan {
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
            System.Windows.Forms.Label label1;
            Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
            this.btnQR = new Krypton.Toolkit.KryptonButton();
            this.btnCash = new Krypton.Toolkit.KryptonButton();
            this.btnCancel = new Krypton.Toolkit.KryptonButton();
            label1 = new System.Windows.Forms.Label();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonTableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            label1.Location = new System.Drawing.Point(10, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(364, 65);
            label1.TabIndex = 0;
            label1.Text = "Chọn phương thức thanh toán";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.ColumnCount = 3;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            kryptonTableLayoutPanel1.Controls.Add(this.btnQR, 1, 0);
            kryptonTableLayoutPanel1.Controls.Add(this.btnCash, 1, 2);
            kryptonTableLayoutPanel1.Controls.Add(this.btnCancel, 1, 4);
            kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            kryptonTableLayoutPanel1.Location = new System.Drawing.Point(10, 142);
            kryptonTableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 5;
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            kryptonTableLayoutPanel1.Size = new System.Drawing.Size(364, 132);
            kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel1.TabIndex = 3;
            // 
            // btnQR
            // 
            this.btnQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQR.Location = new System.Drawing.Point(72, 0);
            this.btnQR.Margin = new System.Windows.Forms.Padding(0);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(218, 37);
            this.btnQR.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQR.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQR.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnQR.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnQR.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.True;
            this.btnQR.StateCommon.Border.Rounding = 16F;
            this.btnQR.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnQR.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnQR.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQR.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQR.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnQR.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnQR.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnQR.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnQR.TabIndex = 1;
            this.btnQR.TabStop = false;
            this.btnQR.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQR.Values.Text = "Chuyển khoản QR";
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnCash
            // 
            this.btnCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCash.Location = new System.Drawing.Point(72, 47);
            this.btnCash.Margin = new System.Windows.Forms.Padding(0);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(218, 37);
            this.btnCash.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCash.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.btnCash.StateCommon.Border.Rounding = 16F;
            this.btnCash.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCash.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCash.StateNormal.Back.Color1 = System.Drawing.Color.LimeGreen;
            this.btnCash.StateNormal.Back.Color2 = System.Drawing.Color.LimeGreen;
            this.btnCash.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnCash.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            this.btnCash.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnCash.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(0)))));
            this.btnCash.TabIndex = 2;
            this.btnCash.TabStop = false;
            this.btnCash.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCash.Values.Text = "Tiền mặt";
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(72, 94);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(218, 38);
            this.btnCancel.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.btnCancel.StateCommon.Border.Rounding = 16F;
            this.btnCancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnCancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.StateNormal.Back.Color1 = System.Drawing.Color.Red;
            this.btnCancel.StateNormal.Back.Color2 = System.Drawing.Color.Red;
            this.btnCancel.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.TabIndex = 3;
            this.btnCancel.TabStop = false;
            this.btnCancel.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnCancel.Values.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormPhuongThucThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 284);
            this.Controls.Add(kryptonTableLayoutPanel1);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "FormPhuongThucThanhToan";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.StateCommon.Border.Width = 5;
            kryptonTableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Krypton.Toolkit.KryptonButton btnQR;
        private Krypton.Toolkit.KryptonButton btnCash;
        private Krypton.Toolkit.KryptonButton btnCancel;

        #endregion
    }
}