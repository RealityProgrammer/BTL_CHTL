using System.Drawing;
namespace CHTL.GUI
{
    partial class FormDangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.textboxTaiKhoan = new Krypton.Toolkit.KryptonTextBox();
            this.textboxMatKhau = new Krypton.Toolkit.KryptonTextBox();
            this.btnDangNhap = new Krypton.Toolkit.KryptonButton();
            this.btnHuy = new Krypton.Toolkit.KryptonButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.kryptonLabelDangNhap = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.Red;
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(500, 160);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(119, 36);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Tài khoản";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel2.Location = new System.Drawing.Point(500, 280);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(116, 36);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Mật khẩu";
            // 
            // textboxTaiKhoan
            // 
            this.textboxTaiKhoan.CueHint.CueHintText = "Nhập tài khoản...";
            this.textboxTaiKhoan.CueHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.textboxTaiKhoan.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.textboxTaiKhoan.Location = new System.Drawing.Point(500, 200);
            this.textboxTaiKhoan.Name = "textboxTaiKhoan";
            this.textboxTaiKhoan.Size = new System.Drawing.Size(400, 44);
            this.textboxTaiKhoan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.textboxTaiKhoan.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.textboxTaiKhoan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textboxTaiKhoan.StateCommon.Border.Rounding = 15F;
            this.textboxTaiKhoan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textboxTaiKhoan.TabIndex = 4;
            // 
            // textboxMatKhau
            // 
            this.textboxMatKhau.CueHint.CueHintText = "Nhập mật khẩu...";
            this.textboxMatKhau.CueHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxMatKhau.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.textboxMatKhau.Location = new System.Drawing.Point(500, 320);
            this.textboxMatKhau.Name = "textboxMatKhau";
            this.textboxMatKhau.PasswordChar = '●';
            this.textboxMatKhau.Size = new System.Drawing.Size(400, 44);
            this.textboxMatKhau.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.textboxMatKhau.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.textboxMatKhau.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textboxMatKhau.StateCommon.Border.Rounding = 15F;
            this.textboxMatKhau.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textboxMatKhau.TabIndex = 5;
            this.textboxMatKhau.UseSystemPasswordChar = true;
            this.textboxMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_mat_khau_KeyDown);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(500, 400);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(190, 60);
            this.btnDangNhap.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangNhap.StateCommon.Border.Rounding = 15F;
            this.btnDangNhap.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDangNhap.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangNhap.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDangNhap.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDangNhap.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.btnDangNhap.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(109)))), ((int)(((byte)(155)))));
            this.btnDangNhap.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDangNhap.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDangNhap.Values.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btn_dang_nhap_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(710, 400);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(190, 60);
            this.btnHuy.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnHuy.StateCommon.Border.Rounding = 15F;
            this.btnHuy.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnHuy.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnHuy.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnHuy.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btnHuy.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(50)))), ((int)(((byte)(39)))));
            this.btnHuy.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnHuy.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnHuy.TabIndex = 7;
            this.btnHuy.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnHuy.Values.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btn_huy_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(200, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(280, 30);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(60, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(120, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // kryptonLabelDangNhap
            // 
            this.kryptonLabelDangNhap.Location = new System.Drawing.Point(500, 60);
            this.kryptonLabelDangNhap.Name = "kryptonLabelDangNhap";
            this.kryptonLabelDangNhap.Size = new System.Drawing.Size(373, 46);
            this.kryptonLabelDangNhap.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.kryptonLabelDangNhap.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.kryptonLabelDangNhap.TabIndex = 11;
            this.kryptonLabelDangNhap.Values.Text = "ĐĂNG NHẬP HỆ THỐNG";
            // 
            // FormDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(958, 599);
            this.Controls.Add(this.kryptonLabelDangNhap);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textboxMatKhau);
            this.Controls.Add(this.textboxTaiKhoan);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.LocalCustomPalette = this.kryptonPalette1;
            this.Name = "FormDangNhap";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox textboxTaiKhoan;
        private Krypton.Toolkit.KryptonTextBox textboxMatKhau;
        private Krypton.Toolkit.KryptonButton btnDangNhap;
        private Krypton.Toolkit.KryptonButton btnHuy;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Krypton.Toolkit.KryptonLabel kryptonLabelDangNhap;
    }
}