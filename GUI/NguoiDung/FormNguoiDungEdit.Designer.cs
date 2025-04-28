namespace CHTL.GUI.NguoiDung
{
    partial class FormNguoiDungEdit
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
            this.cbVaiTro = new Krypton.Toolkit.KryptonComboBox();
            this.txt_ho_ten = new Krypton.Toolkit.KryptonTextBox();
            this.txt_mat_khau = new Krypton.Toolkit.KryptonTextBox();
            this.txt_ten_dang_nhap = new Krypton.Toolkit.KryptonTextBox();
            this.txt_ma_nguoi_dung = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1_1 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVaiTro)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Size = new System.Drawing.Size(805, 103);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.cbVaiTro);
            this.kryptonPanel2.Controls.Add(this.txt_ho_ten);
            this.kryptonPanel2.Controls.Add(this.txt_mat_khau);
            this.kryptonPanel2.Controls.Add(this.txt_ten_dang_nhap);
            this.kryptonPanel2.Controls.Add(this.txt_ma_nguoi_dung);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel1_1);
            this.kryptonPanel2.Size = new System.Drawing.Size(805, 353);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 349);
            this.kryptonPanel3.Size = new System.Drawing.Size(805, 107);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = "EDIT";
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.DropDownWidth = 163;
            this.cbVaiTro.Items.AddRange(new object[] {
            "Admin",
            "NhanVien"});
            this.cbVaiTro.Location = new System.Drawing.Point(525, 54);
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(163, 26);
            this.cbVaiTro.TabIndex = 25;
            // 
            // txt_ho_ten
            // 
            this.txt_ho_ten.Location = new System.Drawing.Point(525, 111);
            this.txt_ho_ten.Name = "txt_ho_ten";
            this.txt_ho_ten.Size = new System.Drawing.Size(163, 27);
            this.txt_ho_ten.TabIndex = 24;
            // 
            // txt_mat_khau
            // 
            this.txt_mat_khau.Location = new System.Drawing.Point(233, 169);
            this.txt_mat_khau.Name = "txt_mat_khau";
            this.txt_mat_khau.Size = new System.Drawing.Size(163, 27);
            this.txt_mat_khau.TabIndex = 23;
            // 
            // txt_ten_dang_nhap
            // 
            this.txt_ten_dang_nhap.Location = new System.Drawing.Point(233, 111);
            this.txt_ten_dang_nhap.Name = "txt_ten_dang_nhap";
            this.txt_ten_dang_nhap.Size = new System.Drawing.Size(163, 27);
            this.txt_ten_dang_nhap.TabIndex = 22;
            // 
            // txt_ma_nguoi_dung
            // 
            this.txt_ma_nguoi_dung.Location = new System.Drawing.Point(233, 52);
            this.txt_ma_nguoi_dung.Name = "txt_ma_nguoi_dung";
            this.txt_ma_nguoi_dung.Size = new System.Drawing.Size(163, 27);
            this.txt_ma_nguoi_dung.TabIndex = 21;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(426, 111);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(77, 24);
            this.kryptonLabel5.TabIndex = 20;
            this.kryptonLabel5.Values.Text = "Họ và tên";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(426, 52);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(57, 24);
            this.kryptonLabel4.TabIndex = 19;
            this.kryptonLabel4.Values.Text = "Vai trò";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(88, 172);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(76, 24);
            this.kryptonLabel3.TabIndex = 18;
            this.kryptonLabel3.Values.Text = "Mật khẩu";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(88, 111);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(114, 24);
            this.kryptonLabel2.TabIndex = 17;
            this.kryptonLabel2.Values.Text = "Tên đăng nhập";
            // 
            // kryptonLabel1_1
            // 
            this.kryptonLabel1_1.Location = new System.Drawing.Point(88, 52);
            this.kryptonLabel1_1.Name = "kryptonLabel1_1";
            this.kryptonLabel1_1.Size = new System.Drawing.Size(117, 24);
            this.kryptonLabel1_1.TabIndex = 16;
            this.kryptonLabel1_1.Values.Text = "Mã người dùng";
            // 
            // FormNguoiDungEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 456);
            this.Name = "FormNguoiDungEdit";
            this.Text = "FormNguoiDungEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbVaiTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox cbVaiTro;
        private Krypton.Toolkit.KryptonTextBox txt_ho_ten;
        private Krypton.Toolkit.KryptonTextBox txt_mat_khau;
        private Krypton.Toolkit.KryptonTextBox txt_ten_dang_nhap;
        private Krypton.Toolkit.KryptonTextBox txt_ma_nguoi_dung;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1_1;
    }
}