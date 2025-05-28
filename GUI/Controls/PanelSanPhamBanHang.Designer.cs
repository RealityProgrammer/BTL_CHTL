namespace CHTL.GUI.Controls {
    partial class PanelSanPhamBanHang {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnQuayLai = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.labelDanhMuc = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(3, 3);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(90, 32);
            this.btnQuayLai.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnQuayLai.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btnQuayLai.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuayLai.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQuayLai.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnQuayLai.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.btnQuayLai.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.btnQuayLai.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuayLai.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnQuayLai.TabIndex = 0;
            this.btnQuayLai.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnQuayLai.Values.Text = "Quay lại";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.labelDanhMuc);
            this.kryptonPanel1.Controls.Add(this.btnQuayLai);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(634, 42);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel1.TabIndex = 1;
            // 
            // labelDanhMuc
            // 
            this.labelDanhMuc.AutoSize = true;
            this.labelDanhMuc.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhMuc.Location = new System.Drawing.Point(99, 6);
            this.labelDanhMuc.Name = "labelDanhMuc";
            this.labelDanhMuc.Size = new System.Drawing.Size(36, 25);
            this.labelDanhMuc.TabIndex = 1;
            this.labelDanhMuc.Text = "???\r\n";
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContent.Location = new System.Drawing.Point(0, 42);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(634, 404);
            this.flpContent.TabIndex = 2;
            // 
            // PanelSanPhamBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.kryptonPanel1);
            this.DoubleBuffered = true;
            this.Name = "PanelSanPhamBanHang";
            this.Size = new System.Drawing.Size(634, 446);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonButton btnQuayLai;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.Label labelDanhMuc;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}
