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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelSidebar = new Krypton.Toolkit.KryptonPanel();
            this.btnDangXuat = new Krypton.Toolkit.KryptonButton();
            this.btnAITips = new Krypton.Toolkit.KryptonButton();
            this.btnBaoCao = new Krypton.Toolkit.KryptonButton();
            this.btnBanHang = new Krypton.Toolkit.KryptonButton();
            this.btnSanPham = new Krypton.Toolkit.KryptonButton();
            this.btnDanhMuc = new Krypton.Toolkit.KryptonButton();
            this.btnNguoiDung = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.panelContent = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonCustomPaletteBase(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).BeginInit();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnAITips);
            this.panelSidebar.Controls.Add(this.btnBaoCao);
            this.panelSidebar.Controls.Add(this.btnBanHang);
            this.panelSidebar.Controls.Add(this.btnSanPham);
            this.panelSidebar.Controls.Add(this.btnDanhMuc);
            this.panelSidebar.Controls.Add(this.btnNguoiDung);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.kryptonLabel1);
            resources.ApplyResources(this.panelSidebar, "panelSidebar");
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelSidebar.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            // 
            // btnDangXuat
            // 
            resources.ApplyResources(this.btnDangXuat, "btnDangXuat");
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDangXuat.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDangXuat.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnDangXuat.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnDangXuat.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDangXuat.StateCommon.Border.Rounding = 10F;
            this.btnDangXuat.StateCommon.Border.Width = 1;
            this.btnDangXuat.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnDangXuat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDangXuat.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDangXuat.Values.Text = resources.GetString("btnDangXuat.Values.Text");
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnAITips
            // 
            resources.ApplyResources(this.btnAITips, "btnAITips");
            this.btnAITips.Name = "btnAITips";
            this.btnAITips.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnAITips.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnAITips.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnAITips.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnAITips.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAITips.StateCommon.Border.Rounding = 10F;
            this.btnAITips.StateCommon.Border.Width = 1;
            this.btnAITips.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAITips.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAITips.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAITips.Values.Text = resources.GetString("btnAITips.Values.Text");
            this.btnAITips.Click += new System.EventHandler(this.btn_ai_tips_Click);
            this.btnAITips.MouseEnter += new System.EventHandler(this.buttonColorHighlight);
            // 
            // btnBaoCao
            // 
            resources.ApplyResources(this.btnBaoCao, "btnBaoCao");
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBaoCao.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBaoCao.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnBaoCao.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnBaoCao.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBaoCao.StateCommon.Border.Rounding = 10F;
            this.btnBaoCao.StateCommon.Border.Width = 1;
            this.btnBaoCao.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBaoCao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBaoCao.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBaoCao.Values.Text = resources.GetString("btnBaoCao.Values.Text");
            this.btnBaoCao.Click += new System.EventHandler(this.btn_bao_cao_Click);
            this.btnBaoCao.MouseEnter += new System.EventHandler(this.buttonColorHighlight);
            // 
            // btnBanHang
            // 
            resources.ApplyResources(this.btnBanHang, "btnBanHang");
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBanHang.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnBanHang.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnBanHang.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnBanHang.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBanHang.StateCommon.Border.Rounding = 10F;
            this.btnBanHang.StateCommon.Border.Width = 1;
            this.btnBanHang.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnBanHang.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBanHang.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnBanHang.Values.Text = resources.GetString("btnBanHang.Values.Text");
            this.btnBanHang.Click += new System.EventHandler(this.btn_ban_hang_Click);
            this.btnBanHang.MouseEnter += new System.EventHandler(this.buttonColorHighlight);
            // 
            // btnSanPham
            // 
            resources.ApplyResources(this.btnSanPham, "btnSanPham");
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnSanPham.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnSanPham.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnSanPham.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnSanPham.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSanPham.StateCommon.Border.Rounding = 10F;
            this.btnSanPham.StateCommon.Border.Width = 1;
            this.btnSanPham.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSanPham.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnSanPham.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSanPham.Values.Text = resources.GetString("btnSanPham.Values.Text");
            this.btnSanPham.Click += new System.EventHandler(this.btn_san_pham_Click);
            this.btnSanPham.MouseEnter += new System.EventHandler(this.buttonColorHighlight);
            // 
            // btnDanhMuc
            // 
            resources.ApplyResources(this.btnDanhMuc, "btnDanhMuc");
            this.btnDanhMuc.Name = "btnDanhMuc";
            this.btnDanhMuc.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnDanhMuc.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnDanhMuc.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnDanhMuc.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnDanhMuc.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnDanhMuc.StateCommon.Border.Rounding = 10F;
            this.btnDanhMuc.StateCommon.Border.Width = 1;
            this.btnDanhMuc.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnDanhMuc.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnDanhMuc.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnDanhMuc.Values.Text = resources.GetString("btnDanhMuc.Values.Text");
            this.btnDanhMuc.Click += new System.EventHandler(this.btn_danh_muc_Click);
            this.btnDanhMuc.MouseEnter += new System.EventHandler(this.buttonColorHighlight);
            // 
            // btnNguoiDung
            // 
            resources.ApplyResources(this.btnNguoiDung, "btnNguoiDung");
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnNguoiDung.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.btnNguoiDung.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNguoiDung.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnNguoiDung.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNguoiDung.StateCommon.Border.Rounding = 10F;
            this.btnNguoiDung.StateCommon.Border.Width = 1;
            this.btnNguoiDung.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnNguoiDung.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnNguoiDung.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnNguoiDung.Values.Text = resources.GetString("btnNguoiDung.Values.Text");
            this.btnNguoiDung.Click += new System.EventHandler(this.btn_nguoi_dung_Click);
            this.btnNguoiDung.MouseEnter += new System.EventHandler(this.buttonColorHighlight);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            resources.ApplyResources(this.kryptonLabel1, "kryptonLabel1");
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.Values.Text = resources.GetString("kryptonLabel1.Values.Text");
            // 
            // panelContent
            // 
            resources.ApplyResources(this.panelContent, "panelContent");
            this.panelContent.Name = "panelContent";
            this.panelContent.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panelContent.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette1.FormStyles.FormMain.StateCommon.Border.Rounding = 16F;
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.kryptonPalette1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonPalette1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelSidebar)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelContent)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
        private Krypton.Toolkit.KryptonPanel panelContent;
        public Krypton.Toolkit.KryptonPanel panelSidebar;
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