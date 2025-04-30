namespace CHTL.GUI.SanPham
{
    partial class FormSanPhamAdd
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
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txt_ma_san_pham = new Krypton.Toolkit.KryptonTextBox();
            this.txt_ten_san_pham = new Krypton.Toolkit.KryptonTextBox();
            this.txt_gia_ban = new Krypton.Toolkit.KryptonTextBox();
            this.txt_so_luong_ton = new Krypton.Toolkit.KryptonTextBox();
            this.cbMaDanhMuc = new Krypton.Toolkit.KryptonComboBox();
            this.dtp_ngay_het_han = new Krypton.Toolkit.KryptonDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.panelHeader.Size = new System.Drawing.Size(804, 103);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // kryptonPanel2
            // 
            this.panelBody.Controls.Add(this.dtp_ngay_het_han);
            this.panelBody.Controls.Add(this.cbMaDanhMuc);
            this.panelBody.Controls.Add(this.txt_so_luong_ton);
            this.panelBody.Controls.Add(this.txt_gia_ban);
            this.panelBody.Controls.Add(this.txt_ten_san_pham);
            this.panelBody.Controls.Add(this.txt_ma_san_pham);
            this.panelBody.Controls.Add(this.kryptonLabel7);
            this.panelBody.Controls.Add(this.kryptonLabel6);
            this.panelBody.Controls.Add(this.kryptonLabel5);
            this.panelBody.Controls.Add(this.kryptonLabel4);
            this.panelBody.Controls.Add(this.kryptonLabel3);
            this.panelBody.Controls.Add(this.kryptonLabel2);
            this.panelBody.Size = new System.Drawing.Size(804, 333);
            this.panelBody.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonPanel3
            // 
            this.panelFooter.Location = new System.Drawing.Point(0, 329);
            this.panelFooter.Size = new System.Drawing.Size(804, 107);
            this.panelFooter.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = "ADD";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(65, 35);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(104, 24);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Mã sản phẩm";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(65, 79);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(107, 24);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Tên sản phẩm";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(65, 128);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(64, 24);
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Giá bán";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(347, 35);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(81, 24);
            this.kryptonLabel5.TabIndex = 3;
            this.kryptonLabel5.Values.Text = "Danh mục";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(347, 79);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(100, 24);
            this.kryptonLabel6.TabIndex = 4;
            this.kryptonLabel6.Values.Text = "Số lượng tồn";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(347, 128);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(103, 24);
            this.kryptonLabel7.TabIndex = 5;
            this.kryptonLabel7.Values.Text = "Ngày hết hạn";
            // 
            // txt_ma_san_pham
            // 
            this.txt_ma_san_pham.Location = new System.Drawing.Point(189, 32);
            this.txt_ma_san_pham.Name = "txt_ma_san_pham";
            this.txt_ma_san_pham.Size = new System.Drawing.Size(139, 27);
            this.txt_ma_san_pham.TabIndex = 6;
            // 
            // txt_ten_san_pham
            // 
            this.txt_ten_san_pham.Location = new System.Drawing.Point(189, 76);
            this.txt_ten_san_pham.Name = "txt_ten_san_pham";
            this.txt_ten_san_pham.Size = new System.Drawing.Size(139, 27);
            this.txt_ten_san_pham.TabIndex = 7;
            // 
            // txt_gia_ban
            // 
            this.txt_gia_ban.Location = new System.Drawing.Point(189, 125);
            this.txt_gia_ban.Name = "txt_gia_ban";
            this.txt_gia_ban.Size = new System.Drawing.Size(139, 27);
            this.txt_gia_ban.TabIndex = 8;
            // 
            // txt_so_luong_ton
            // 
            this.txt_so_luong_ton.Location = new System.Drawing.Point(488, 76);
            this.txt_so_luong_ton.Name = "txt_so_luong_ton";
            this.txt_so_luong_ton.Size = new System.Drawing.Size(139, 27);
            this.txt_so_luong_ton.TabIndex = 9;
            // 
            // cbMaDanhMuc
            // 
            this.cbMaDanhMuc.DropDownWidth = 138;
            this.cbMaDanhMuc.Location = new System.Drawing.Point(488, 38);
            this.cbMaDanhMuc.Name = "cbMaDanhMuc";
            this.cbMaDanhMuc.Size = new System.Drawing.Size(138, 26);
            this.cbMaDanhMuc.TabIndex = 11;
            // 
            // dtp_ngay_het_han
            // 
            this.dtp_ngay_het_han.Location = new System.Drawing.Point(488, 127);
            this.dtp_ngay_het_han.Name = "dtp_ngay_het_han";
            this.dtp_ngay_het_han.Size = new System.Drawing.Size(150, 25);
            this.dtp_ngay_het_han.TabIndex = 12;
            // 
            // FormSanPhamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 436);
            this.Name = "FormSanPhamAdd";
            this.Text = "FormSanPhamAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbMaDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonDateTimePicker dtp_ngay_het_han;
        private Krypton.Toolkit.KryptonComboBox cbMaDanhMuc;
        private Krypton.Toolkit.KryptonTextBox txt_so_luong_ton;
        private Krypton.Toolkit.KryptonTextBox txt_gia_ban;
        private Krypton.Toolkit.KryptonTextBox txt_ten_san_pham;
        private Krypton.Toolkit.KryptonTextBox txt_ma_san_pham;
    }
}