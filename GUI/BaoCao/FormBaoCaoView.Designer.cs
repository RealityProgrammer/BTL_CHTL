using System.ComponentModel;

namespace CHTL.GUI.BaoCao {
    partial class FormBaoCaoView {
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
            Krypton.Toolkit.KryptonPanel kryptonPanel1;
            Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
            Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
            Krypton.Toolkit.KryptonPanel kryptonPanel2;
            Krypton.Toolkit.KryptonLabel kryptonLabel5;
            Krypton.Toolkit.KryptonLabel kryptonLabel4;
            Krypton.Toolkit.KryptonLabel kryptonLabel3;
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.dtpLocDenNgay = new Krypton.Toolkit.KryptonDateTimePicker();
            this.dtpLocTuNgay = new Krypton.Toolkit.KryptonDateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageThongKe = new System.Windows.Forms.TabPage();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.labelSanPhamBanChay = new Krypton.Toolkit.KryptonLabel();
            this.labelSoHoaDon = new Krypton.Toolkit.KryptonLabel();
            this.labelTongDoanhThu = new Krypton.Toolkit.KryptonLabel();
            this.tabPageChiTietHoaDon = new System.Windows.Forms.TabPage();
            this.tabPageBieuDo = new System.Windows.Forms.TabPage();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.colMaHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenNguoiBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel1)).BeginInit();
            kryptonPanel1.SuspendLayout();
            kryptonTableLayoutPanel2.SuspendLayout();
            kryptonTableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel2)).BeginInit();
            kryptonPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageThongKe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.kryptonTableLayoutPanel3.SuspendLayout();
            this.tabPageChiTietHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(kryptonTableLayoutPanel2);
            kryptonPanel1.Controls.Add(kryptonTableLayoutPanel1);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            kryptonPanel1.Size = new System.Drawing.Size(960, 97);
            kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel1.TabIndex = 0;
            // 
            // kryptonTableLayoutPanel2
            // 
            kryptonTableLayoutPanel2.ColumnCount = 3;
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.Controls.Add(this.kryptonButton2, 2, 1);
            kryptonTableLayoutPanel2.Controls.Add(this.kryptonButton1, 0, 1);
            kryptonTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Right;
            kryptonTableLayoutPanel2.Location = new System.Drawing.Point(609, 10);
            kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            kryptonTableLayoutPanel2.RowCount = 3;
            kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel2.Size = new System.Drawing.Size(341, 87);
            kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel2.TabIndex = 2;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton2.Location = new System.Drawing.Point(183, 26);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.Size = new System.Drawing.Size(155, 34);
            this.kryptonButton2.StateCommon.Border.Rounding = 8F;
            this.kryptonButton2.TabIndex = 1;
            this.kryptonButton2.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton2.Values.Text = "Lưu báo cáo";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonButton1.Location = new System.Drawing.Point(3, 26);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(154, 34);
            this.kryptonButton1.StateCommon.Border.Rounding = 8F;
            this.kryptonButton1.TabIndex = 0;
            this.kryptonButton1.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.kryptonButton1.Values.Text = "Xem báo cáo";
            // 
            // kryptonTableLayoutPanel1
            // 
            kryptonTableLayoutPanel1.ColumnCount = 2;
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            kryptonTableLayoutPanel1.Controls.Add(this.kryptonLabel2, 0, 2);
            kryptonTableLayoutPanel1.Controls.Add(this.kryptonLabel1, 0, 0);
            kryptonTableLayoutPanel1.Controls.Add(this.dtpLocDenNgay, 2, 2);
            kryptonTableLayoutPanel1.Controls.Add(this.dtpLocTuNgay, 1, 0);
            kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            kryptonTableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            kryptonTableLayoutPanel1.RowCount = 3;
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            kryptonTableLayoutPanel1.Size = new System.Drawing.Size(328, 87);
            kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel2.Location = new System.Drawing.Point(3, 51);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(60, 32);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.TabIndex = 12;
            this.kryptonLabel2.Values.Text = "Đến";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(60, 32);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.TabIndex = 11;
            this.kryptonLabel1.Values.Text = "Từ";
            // 
            // dtpLocDenNgay
            // 
            this.dtpLocDenNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpLocDenNgay.Location = new System.Drawing.Point(69, 51);
            this.dtpLocDenNgay.Name = "dtpLocDenNgay";
            this.dtpLocDenNgay.Size = new System.Drawing.Size(256, 33);
            this.dtpLocDenNgay.StateCommon.Border.Rounding = 8F;
            this.dtpLocDenNgay.TabIndex = 3;
            // 
            // dtpLocTuNgay
            // 
            this.dtpLocTuNgay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpLocTuNgay.Location = new System.Drawing.Point(69, 3);
            this.dtpLocTuNgay.Name = "dtpLocTuNgay";
            this.dtpLocTuNgay.Size = new System.Drawing.Size(256, 32);
            this.dtpLocTuNgay.StateCommon.Border.Rounding = 8F;
            this.dtpLocTuNgay.TabIndex = 2;
            this.dtpLocTuNgay.ValueNullable = new System.DateTime(2025, 1, 1, 0, 0, 0, 0);
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(this.tabControl1);
            kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel2.Location = new System.Drawing.Point(0, 97);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Padding = new System.Windows.Forms.Padding(10);
            kryptonPanel2.Size = new System.Drawing.Size(960, 492);
            kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageThongKe);
            this.tabControl1.Controls.Add(this.tabPageChiTietHoaDon);
            this.tabControl1.Controls.Add(this.tabPageBieuDo);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(10, 10);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(940, 472);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageThongKe
            // 
            this.tabPageThongKe.Controls.Add(this.kryptonPanel3);
            this.tabPageThongKe.Location = new System.Drawing.Point(4, 25);
            this.tabPageThongKe.Name = "tabPageThongKe";
            this.tabPageThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageThongKe.Size = new System.Drawing.Size(887, 459);
            this.tabPageThongKe.TabIndex = 2;
            this.tabPageThongKe.Text = "Thống kê";
            this.tabPageThongKe.UseVisualStyleBackColor = true;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonTableLayoutPanel3);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel3.Location = new System.Drawing.Point(3, 3);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.kryptonPanel3.Size = new System.Drawing.Size(881, 453);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPanel3.TabIndex = 3;
            // 
            // kryptonTableLayoutPanel3
            // 
            this.kryptonTableLayoutPanel3.ColumnCount = 2;
            this.kryptonTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.kryptonTableLayoutPanel3.Controls.Add(this.labelSanPhamBanChay, 1, 2);
            this.kryptonTableLayoutPanel3.Controls.Add(this.labelSoHoaDon, 1, 1);
            this.kryptonTableLayoutPanel3.Controls.Add(kryptonLabel5, 0, 1);
            this.kryptonTableLayoutPanel3.Controls.Add(kryptonLabel4, 0, 2);
            this.kryptonTableLayoutPanel3.Controls.Add(this.labelTongDoanhThu, 1, 0);
            this.kryptonTableLayoutPanel3.Controls.Add(kryptonLabel3, 0, 0);
            this.kryptonTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel3.Location = new System.Drawing.Point(0, 10);
            this.kryptonTableLayoutPanel3.Name = "kryptonTableLayoutPanel3";
            this.kryptonTableLayoutPanel3.RowCount = 3;
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.kryptonTableLayoutPanel3.Size = new System.Drawing.Size(881, 443);
            this.kryptonTableLayoutPanel3.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel3.StateCommon.Color2 = System.Drawing.Color.White;
            this.kryptonTableLayoutPanel3.TabIndex = 0;
            // 
            // labelSanPhamBanChay
            // 
            this.labelSanPhamBanChay.Location = new System.Drawing.Point(443, 73);
            this.labelSanPhamBanChay.Name = "labelSanPhamBanChay";
            this.labelSanPhamBanChay.Size = new System.Drawing.Size(48, 28);
            this.labelSanPhamBanChay.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(175)))), ((int)(((byte)(228)))));
            this.labelSanPhamBanChay.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.labelSanPhamBanChay.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSanPhamBanChay.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.labelSanPhamBanChay.TabIndex = 5;
            this.labelSanPhamBanChay.Values.Text = "???";
            // 
            // labelSoHoaDon
            // 
            this.labelSoHoaDon.Location = new System.Drawing.Point(443, 38);
            this.labelSoHoaDon.Name = "labelSoHoaDon";
            this.labelSoHoaDon.Size = new System.Drawing.Size(25, 28);
            this.labelSoHoaDon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(175)))), ((int)(((byte)(228)))));
            this.labelSoHoaDon.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.labelSoHoaDon.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoHoaDon.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.labelSoHoaDon.TabIndex = 4;
            this.labelSoHoaDon.Values.Text = "0";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonLabel5.Location = new System.Drawing.Point(3, 38);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new System.Drawing.Size(434, 29);
            kryptonLabel5.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            kryptonLabel5.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kryptonLabel5.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel5.TabIndex = 2;
            kryptonLabel5.Values.Text = "Số hóa đơn";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonLabel4.Location = new System.Drawing.Point(3, 73);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new System.Drawing.Size(434, 367);
            kryptonLabel4.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            kryptonLabel4.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kryptonLabel4.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel4.TabIndex = 1;
            kryptonLabel4.Values.Text = "Sản phẩm bán chạy";
            // 
            // labelTongDoanhThu
            // 
            this.labelTongDoanhThu.Location = new System.Drawing.Point(443, 3);
            this.labelTongDoanhThu.Name = "labelTongDoanhThu";
            this.labelTongDoanhThu.Size = new System.Drawing.Size(74, 28);
            this.labelTongDoanhThu.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(175)))), ((int)(((byte)(228)))));
            this.labelTongDoanhThu.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.labelTongDoanhThu.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongDoanhThu.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.labelTongDoanhThu.TabIndex = 3;
            this.labelTongDoanhThu.Values.Text = "0 VND";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonLabel3.Location = new System.Drawing.Point(3, 3);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new System.Drawing.Size(434, 29);
            kryptonLabel3.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            kryptonLabel3.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kryptonLabel3.StateCommon.ShortText.TextV = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonLabel3.TabIndex = 0;
            kryptonLabel3.Values.Text = "Tổng doanh thu";
            // 
            // tabPageChiTietHoaDon
            // 
            this.tabPageChiTietHoaDon.Controls.Add(this.dgvChiTiet);
            this.tabPageChiTietHoaDon.Location = new System.Drawing.Point(4, 25);
            this.tabPageChiTietHoaDon.Name = "tabPageChiTietHoaDon";
            this.tabPageChiTietHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChiTietHoaDon.Size = new System.Drawing.Size(932, 443);
            this.tabPageChiTietHoaDon.TabIndex = 1;
            this.tabPageChiTietHoaDon.Text = "Chi tiết hóa đơn";
            this.tabPageChiTietHoaDon.UseVisualStyleBackColor = true;
            // 
            // tabPageBieuDo
            // 
            this.tabPageBieuDo.Location = new System.Drawing.Point(4, 25);
            this.tabPageBieuDo.Name = "tabPageBieuDo";
            this.tabPageBieuDo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBieuDo.Size = new System.Drawing.Size(903, 475);
            this.tabPageBieuDo.TabIndex = 3;
            this.tabPageBieuDo.Text = "Biểu đồ";
            this.tabPageBieuDo.UseVisualStyleBackColor = true;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaHoaDon, this.colNgayBan, this.colTenNguoiBan, this.colTongTien, this.colDetails
            });
            this.dgvChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTiet.Location = new System.Drawing.Point(3, 3);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.Size = new System.Drawing.Size(926, 437);
            this.dgvChiTiet.TabIndex = 10;
            // 
            // colMaHoaDon
            // 
            this.colMaHoaDon.DataPropertyName = "MaHoaDon";
            this.colMaHoaDon.HeaderText = "Mã hóa đơn";
            this.colMaHoaDon.Name = "colMaHoaDon";
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
            // 
            // FormBaoCaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 589);
            this.Controls.Add(kryptonPanel2);
            this.Controls.Add(kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoView";
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel1)).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel2.ResumeLayout(false);
            kryptonTableLayoutPanel1.ResumeLayout(false);
            kryptonTableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel2)).EndInit();
            kryptonPanel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageThongKe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonTableLayoutPanel3.ResumeLayout(false);
            this.kryptonTableLayoutPanel3.PerformLayout();
            this.tabPageChiTietHoaDon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
        }
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenNguoiBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTongTien;
        private System.Windows.Forms.DataGridViewButtonColumn colDetails;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel labelTongDoanhThu;
        private Krypton.Toolkit.KryptonLabel labelSoHoaDon;
        private Krypton.Toolkit.KryptonLabel labelSanPhamBanChay;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPageBieuDo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageThongKe;
        private System.Windows.Forms.TabPage tabPageChiTietHoaDon;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonDateTimePicker dtpLocDenNgay;
        private Krypton.Toolkit.KryptonDateTimePicker dtpLocTuNgay;

        #endregion
    }
}