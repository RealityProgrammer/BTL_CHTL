using System.Windows.Forms;
using System.Drawing;
namespace CHTL.GUI.BaoCao
{
    partial class FormBaoCaoView
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblSanPhamBanChay = new System.Windows.Forms.Label();
            this.lblSoLuongBanChay = new System.Windows.Forms.Label();
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabBieuDo = new System.Windows.Forms.TabPage();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpNgayBatDau = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpNgayKetThuc = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnXemBaoCao = new Krypton.Toolkit.KryptonButton();
            this.btnInBaoCao = new Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.tabBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabThongKe);
            this.tabControl.Controls.Add(this.tabChiTiet);
            this.tabControl.Controls.Add(this.tabBieuDo);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(930, 510);
            this.tabControl.TabIndex = 0;
            // 
            // tabThongKe
            // 
            this.tabThongKe.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.tabThongKe.Controls.Add(this.label3);
            this.tabThongKe.Controls.Add(this.label4);
            this.tabThongKe.Controls.Add(this.label5);
            this.tabThongKe.Controls.Add(this.label6);
            this.tabThongKe.Controls.Add(this.lblTongDoanhThu);
            this.tabThongKe.Controls.Add(this.lblTongHoaDon);
            this.tabThongKe.Controls.Add(this.lblSanPhamBanChay);
            this.tabThongKe.Controls.Add(this.lblSoLuongBanChay);
            this.tabThongKe.Location = new System.Drawing.Point(4, 34);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(20);
            this.tabThongKe.Size = new System.Drawing.Size(922, 472);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Text = "Thống Kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(30, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(30, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng số hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(30, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sản phẩm bán chạy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(30, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng bán chạy:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTongDoanhThu.Location = new System.Drawing.Point(300, 50);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(0, 32);
            this.lblTongDoanhThu.TabIndex = 5;
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTongHoaDon.Location = new System.Drawing.Point(300, 100);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(0, 32);
            this.lblTongHoaDon.TabIndex = 6;
            // 
            // lblSanPhamBanChay
            // 
            this.lblSanPhamBanChay.AutoSize = true;
            this.lblSanPhamBanChay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSanPhamBanChay.Location = new System.Drawing.Point(300, 150);
            this.lblSanPhamBanChay.Name = "lblSanPhamBanChay";
            this.lblSanPhamBanChay.Size = new System.Drawing.Size(0, 32);
            this.lblSanPhamBanChay.TabIndex = 7;
            // 
            // lblSoLuongBanChay
            // 
            this.lblSoLuongBanChay.AutoSize = true;
            this.lblSoLuongBanChay.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblSoLuongBanChay.Location = new System.Drawing.Point(300, 200);
            this.lblSoLuongBanChay.Name = "lblSoLuongBanChay";
            this.lblSoLuongBanChay.Size = new System.Drawing.Size(0, 32);
            this.lblSoLuongBanChay.TabIndex = 8;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.dgvChiTiet);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 34);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(10);
            this.tabChiTiet.Size = new System.Drawing.Size(922, 472);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaHoaDon,
                this.colNgayBan,
                this.colTenNguoiBan,
                this.colTongTien,
                this.colDetails});
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(10, 10);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 30;
            this.dgvChiTiet.Size = new System.Drawing.Size(902, 452);
            this.dgvChiTiet.TabIndex = 9;
            this.dgvChiTiet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellClick);
            this.dgvChiTiet.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellMouseEnter);
            this.dgvChiTiet.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellMouseLeave);
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.DataPropertyName = "MaHoaDon";
            this.colMaHoaDon.HeaderText = "Mã hóa đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
            this.colMaHoaDon.Width = 150;
            this.colMaHoaDon.ReadOnly = true;
            // 
            // colNgayBan
            // 
            this.colNgayBan.DataPropertyName = "NgayBan";
            this.colNgayBan.HeaderText = "Ngày bán";
            this.colNgayBan.Name = "colNgayBan";
            this.colNgayBan.ReadOnly = true;
            // 
            // colTenNguoiBan
            // 
            this.colTenNguoiBan.DataPropertyName = "TenNguoiDung";
            this.colTenNguoiBan.HeaderText = "Tên người bán";
            this.colTenNguoiBan.Name = "colTenNguoiBan";
            this.colTenNguoiBan.ReadOnly = true;
            // 
            // colTongTien
            // 
            this.colTongTien.DataPropertyName = "TongTien";
            this.colTongTien.HeaderText = "Tổng tiền";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.ReadOnly = true;
            // 
            // colDetails
            // 
            this.colDetails.HeaderText = "Chi tiết";
            this.colDetails.Name = "colDetails";
            this.colDetails.Text = "Xem";
            this.colDetails.UseColumnTextForButtonValue = true;
            this.colDetails.Width = 100;
            // 
            // tabBieuDo
            // 
            this.tabBieuDo.Controls.Add(this.chartDoanhThu);
            this.tabBieuDo.Location = new System.Drawing.Point(4, 34);
            this.tabBieuDo.Name = "tabBieuDo";
            this.tabBieuDo.Size = new System.Drawing.Size(922, 472);
            this.tabBieuDo.TabIndex = 2;
            this.tabBieuDo.Text = "Biểu Đồ";
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Size = new System.Drawing.Size(922, 472);
            this.chartDoanhThu.TabIndex = 10;
            this.chartDoanhThu.Text = "chartDoanhThu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(120, 15);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 40);
            this.dtpNgayBatDau.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.dtpNgayBatDau.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayBatDau.StateCommon.Border.Rounding = 10F;
            this.dtpNgayBatDau.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.dtpNgayBatDau.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayBatDau.TabIndex = 1;
            this.dtpNgayBatDau.ValueChanged += new System.EventHandler(this.dtpNgayBatDau_ValueChanged);
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(120, 65);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 40);
            this.dtpNgayKetThuc.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199);
            this.dtpNgayKetThuc.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayKetThuc.StateCommon.Border.Rounding = 10F;
            this.dtpNgayKetThuc.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80);
            this.dtpNgayKetThuc.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayKetThuc.TabIndex = 2;
            this.dtpNgayKetThuc.ValueChanged += new System.EventHandler(this.dtpNgayKetThuc_ValueChanged);
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Location = new System.Drawing.Point(550, 30);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(140, 40);
            this.btnXemBaoCao.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            this.btnXemBaoCao.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            this.btnXemBaoCao.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199);
            this.btnXemBaoCao.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnXemBaoCao.StateCommon.Border.Rounding = 10F;
            this.btnXemBaoCao.StateCommon.Content.ShortText.Color1 = Color.White;
            this.btnXemBaoCao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Values.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            this.btnXemBaoCao.MouseEnter += new System.EventHandler((s, e) =>
            {
                btnXemBaoCao.StateCommon.Back.Color1 = Color.FromArgb(41, 128, 185); // Xanh đậm
                btnXemBaoCao.StateCommon.Back.Color2 = Color.FromArgb(41, 128, 185);
            });
            this.btnXemBaoCao.MouseLeave += new System.EventHandler((s, e) =>
            {
                btnXemBaoCao.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
                btnXemBaoCao.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            });
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.Location = new System.Drawing.Point(750, 30);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(140, 40);
            this.btnInBaoCao.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18); // Cam nhạt
            this.btnInBaoCao.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            this.btnInBaoCao.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199);
            this.btnInBaoCao.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnInBaoCao.StateCommon.Border.Rounding = 10F;
            this.btnInBaoCao.StateCommon.Content.ShortText.Color1 = Color.White;
            this.btnInBaoCao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnInBaoCao.TabIndex = 4;
            this.btnInBaoCao.Values.Text = "In Báo Cáo";
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            this.btnInBaoCao.MouseEnter += new System.EventHandler((s, e) =>
            {
                btnInBaoCao.StateCommon.Back.Color1 = Color.FromArgb(230, 126, 34); // Cam đậm
                btnInBaoCao.StateCommon.Back.Color2 = Color.FromArgb(230, 126, 34);
            });
            this.btnInBaoCao.MouseLeave += new System.EventHandler((s, e) =>
            {
                btnInBaoCao.StateCommon.Back.Color1 = Color.FromArgb(243, 156, 18);
                btnInBaoCao.StateCommon.Back.Color2 = Color.FromArgb(243, 156, 18);
            });
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = Color.FromArgb(44, 62, 80);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến";
            // 
            // panel1
            // 
            this.panel1.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnInBaoCao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnXemBaoCao);
            this.panel1.Controls.Add(this.dtpNgayBatDau);
            this.panel1.Controls.Add(this.dtpNgayKetThuc);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 120);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(930, 510);
            this.panel2.TabIndex = 14;
            // 
            // FormBaoCaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoView";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "";
            this.Load += new System.EventHandler(this.FormBaoCaoView_Load);
            this.tabControl.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            this.tabChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.tabBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.TabPage tabChiTiet;
        private System.Windows.Forms.TabPage tabBieuDo;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNgayBatDau;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNgayKetThuc;
        private Krypton.Toolkit.KryptonButton btnXemBaoCao;
        private Krypton.Toolkit.KryptonButton btnInBaoCao;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblSanPhamBanChay;
        private System.Windows.Forms.Label lblSoLuongBanChay;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}