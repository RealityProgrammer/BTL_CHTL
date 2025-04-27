using System.Drawing;
namespace CHTL.GUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.btnDangXuat = new Krypton.Toolkit.KryptonButton();
            this.btnAITips = new Krypton.Toolkit.KryptonButton();
            this.btnBaoCao = new Krypton.Toolkit.KryptonButton();
            this.btnBanHang = new Krypton.Toolkit.KryptonButton();
            this.btnSanPham = new Krypton.Toolkit.KryptonButton();
            this.btnDanhMuc = new Krypton.Toolkit.KryptonButton();
            this.btnNguoiDung = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.btnDangXuat);
            this.kryptonPanel1.Controls.Add(this.btnAITips);
            this.kryptonPanel1.Controls.Add(this.btnBaoCao);
            this.kryptonPanel1.Controls.Add(this.btnBanHang);
            this.kryptonPanel1.Controls.Add(this.btnSanPham);
            this.kryptonPanel1.Controls.Add(this.btnDanhMuc);
            this.kryptonPanel1.Controls.Add(this.btnNguoiDung);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(250, 700);
            this.kryptonPanel1.StateCommon.Color1 = Color.FromArgb(44, 62, 80); // Xanh dương đậm
            this.kryptonPanel1.StateCommon.Color2 = Color.FromArgb(44, 62, 80);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(20, 620);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(210, 50);
            this.btnDangXuat.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60); // Đỏ nhạt
            this.btnDangXuat.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            this.btnDangXuat.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnDangXuat.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnDangXuat.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangXuat.StateCommon.Border.Rounding = 10F;
            this.btnDangXuat.StateCommon.Border.Width = 1;
            this.btnDangXuat.StateCommon.Content.ShortText.Color1 = Color.White;
            this.btnDangXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.Values.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnAITips
            // 
            this.btnAITips.Location = new System.Drawing.Point(20, 550);
            this.btnAITips.Name = "btnAITips";
            this.btnAITips.Size = new System.Drawing.Size(210, 50);
            this.btnAITips.StateCommon.Back.Color1 = Color.White;
            this.btnAITips.StateCommon.Back.Color2 = Color.White;
            this.btnAITips.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnAITips.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnAITips.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAITips.StateCommon.Border.Rounding = 10F;
            this.btnAITips.StateCommon.Border.Width = 1;
            this.btnAITips.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.btnAITips.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAITips.Values.Text = "AI Tips";
            this.btnAITips.Click += new System.EventHandler(this.btn_ai_tips_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(20, 480);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(210, 50);
            this.btnBaoCao.StateCommon.Back.Color1 = Color.White;
            this.btnBaoCao.StateCommon.Back.Color2 = Color.White;
            this.btnBaoCao.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnBaoCao.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnBaoCao.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBaoCao.StateCommon.Border.Rounding = 10F;
            this.btnBaoCao.StateCommon.Border.Width = 1;
            this.btnBaoCao.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.btnBaoCao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.Values.Text = "Báo cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btn_bao_cao_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Location = new System.Drawing.Point(20, 410);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(210, 50);
            this.btnBanHang.StateCommon.Back.Color1 = Color.White;
            this.btnBanHang.StateCommon.Back.Color2 = Color.White;
            this.btnBanHang.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnBanHang.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnBanHang.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBanHang.StateCommon.Border.Rounding = 10F;
            this.btnBanHang.StateCommon.Border.Width = 1;
            this.btnBanHang.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.btnBanHang.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.Values.Text = "Bán hàng";
            this.btnBanHang.Click += new System.EventHandler(this.btn_ban_hang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Location = new System.Drawing.Point(20, 340);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(210, 50);
            this.btnSanPham.StateCommon.Back.Color1 = Color.White;
            this.btnSanPham.StateCommon.Back.Color2 = Color.White;
            this.btnSanPham.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnSanPham.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnSanPham.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSanPham.StateCommon.Border.Rounding = 10F;
            this.btnSanPham.StateCommon.Border.Width = 1;
            this.btnSanPham.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.btnSanPham.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.Values.Text = "Sản phẩm";
            this.btnSanPham.Click += new System.EventHandler(this.btn_san_pham_Click);
            // 
            // btnDanhMuc
            // 
            this.btnDanhMuc.Location = new System.Drawing.Point(20, 270);
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.Size = new System.Drawing.Size(210, 50);
            this.btnDanhMuc.StateCommon.Back.Color1 = Color.White;
            this.btnDanhMuc.StateCommon.Back.Color2 = Color.White;
            this.btnDanhMuc.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnDanhMuc.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnDanhMuc.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDanhMuc.StateCommon.Border.Rounding = 10F;
            this.btnDanhMuc.StateCommon.Border.Width = 1;
            this.btnDanhMuc.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.btnDanhMuc.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDanhMuc.Values.Text = "Danh mục";
            this.btnDanhMuc.Click += new System.EventHandler(this.btn_danh_muc_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Location = new System.Drawing.Point(20, 200);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(210, 50);
            this.btnNguoiDung.StateCommon.Back.Color1 = Color.White;
            this.btnNguoiDung.StateCommon.Back.Color2 = Color.White;
            this.btnNguoiDung.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.btnNguoiDung.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.btnNguoiDung.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNguoiDung.StateCommon.Border.Rounding = 10F;
            this.btnNguoiDung.StateCommon.Border.Width = 1;
            this.btnNguoiDung.StateCommon.Content.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.btnNguoiDung.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnNguoiDung.Values.Text = "Người dùng";
            this.btnNguoiDung.Click += new System.EventHandler(this.btn_nguoi_dung_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(20, 130);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(210, 50);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.Values.Text = "QUẢN LÝ CỬA HÀNG";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Location = new System.Drawing.Point(250, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(950, 700);
            this.kryptonPanel2.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.kryptonPanel2.StateCommon.Color2 = Color.FromArgb(236, 240, 241);
            //this.kryptonPanel2.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            //this.kryptonPanel2.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Left;
            //this.kryptonPanel2.StateCommon.Border.Width = 1;
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = Color.FromArgb(236, 240, 241);
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = Color.FromArgb(189, 195, 199);
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = Color.White;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        public Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonPalette1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton btnBaoCao;
        private Krypton.Toolkit.KryptonButton btnBanHang;
        private Krypton.Toolkit.KryptonButton btnSanPham;
        private Krypton.Toolkit.KryptonButton btnDanhMuc;
        private Krypton.Toolkit.KryptonButton btnNguoiDung;
        private Krypton.Toolkit.KryptonButton btnAITips;
        private Krypton.Toolkit.KryptonButton btnDangXuat;
    }
}