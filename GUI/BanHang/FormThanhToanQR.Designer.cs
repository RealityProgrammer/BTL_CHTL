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
            System.Windows.Forms.Panel panel1;
            Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.panelFooter = new CHTL.GUI.Controls.SaveOrCancelPanel();
            this.pbQR = new Krypton.Toolkit.KryptonPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            panel1.SuspendLayout();
            kryptonTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(this.labelTrangThai);
            panel1.Controls.Add(this.panelFooter);
            panel1.Controls.Add(kryptonTableLayoutPanel2);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 59);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(464, 365);
            panel1.TabIndex = 2;
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrangThai.Location = new System.Drawing.Point(0, 245);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(464, 25);
            this.labelTrangThai.TabIndex = 0;
            this.labelTrangThai.Text = "Mã QR đang được tạo...";
            this.labelTrangThai.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Transparent;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 270);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(464, 95);
            this.panelFooter.TabIndex = 4;
            this.panelFooter.TabStop = false;
            this.panelFooter.SaveButtonClick += new System.EventHandler(this.btnSave_Click);
            this.panelFooter.CancelButtonClick += new System.EventHandler(this.btnCancel_Click);
            // 
            // kryptonTableLayoutPanel2
            // 
            kryptonTableLayoutPanel2.ColumnCount = 3;
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.Controls.Add(this.pbQR, 1, 0);
            kryptonTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            kryptonTableLayoutPanel2.RowCount = 1;
            kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            kryptonTableLayoutPanel2.Size = new System.Drawing.Size(464, 244);
            kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            kryptonTableLayoutPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel2.TabIndex = 2;
            // 
            // pbQR
            // 
            this.pbQR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbQR.Location = new System.Drawing.Point(110, 0);
            this.pbQR.Margin = new System.Windows.Forms.Padding(0);
            this.pbQR.Name = "pbQR";
            this.pbQR.Size = new System.Drawing.Size(244, 244);
            this.pbQR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbQR.TabIndex = 1;
            this.pbQR.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(464, 426);
            this.Controls.Add(panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(480, 480);
            this.MinimumSize = new System.Drawing.Size(480, 480);
            this.Name = "FormThanhToanQR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.Text = "Thanh toán QR";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormThanhToanQR_FormClosed);
            panel1.ResumeLayout(false);
            kryptonTableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbQR)).EndInit();
            this.ResumeLayout(false);

        }
        private Krypton.Toolkit.KryptonPictureBox pbQR;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.Label label1;

        #endregion

        private Controls.SaveOrCancelPanel panelFooter;
    }
}