using System.Drawing;
namespace CHTL.GUI.BanHang
{
    partial class FormBanHangView
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
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colTenSanPhamCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBanCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.dtpNgayBan = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbNguoiBan = new Krypton.Toolkit.KryptonComboBox();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new Krypton.Toolkit.KryptonButton();
            this.lblSearch = new Krypton.Toolkit.KryptonLabel();
            this.lblNgayBan = new Krypton.Toolkit.KryptonLabel();
            this.lblNguoiBan = new Krypton.Toolkit.KryptonLabel();
            this.lblGrandTotalTitle = new Krypton.Toolkit.KryptonLabel();
            this.lblGrandTotal = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNguoiBan)).BeginInit();
            this.SuspendLayout();
            // 
            // flpSanPham
            // 
            this.flpSanPham.AutoScroll = true;
            this.flpSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.flpSanPham.Location = new System.Drawing.Point(30, 130);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(400, 450);
            this.flpSanPham.TabIndex = 0;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTenSanPhamCT,
            this.colSoLuongCT,
            this.colGiaBanCT,
            this.colThanhTien});
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(450, 130);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 30;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(470, 400);
            this.dgvChiTietHoaDon.TabIndex = 1;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // colTenSanPhamCT
            // 
            this.colTenSanPhamCT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colTenSanPhamCT.DataPropertyName = "TenSanPham";
            this.colTenSanPhamCT.HeaderText = "Sản phẩm";
            this.colTenSanPhamCT.MinimumWidth = 6;
            this.colTenSanPhamCT.Name = "colTenSanPhamCT";
            this.colTenSanPhamCT.Width = 150;
            // 
            // colSoLuongCT
            // 
            this.colSoLuongCT.DataPropertyName = "SoLuong";
            this.colSoLuongCT.HeaderText = "Số lượng";
            this.colSoLuongCT.MinimumWidth = 6;
            this.colSoLuongCT.Name = "colSoLuongCT";
            // 
            // colGiaBanCT
            // 
            this.colGiaBanCT.DataPropertyName = "GiaBan";
            this.colGiaBanCT.HeaderText = "Giá";
            this.colGiaBanCT.MinimumWidth = 6;
            this.colGiaBanCT.Name = "colGiaBanCT";
            // 
            // colThanhTien
            // 
            this.colThanhTien.DataPropertyName = "ThanhTien";
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 40);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10F;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.TabIndex = 7;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(300, 70);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(200, 39);
            this.dtpNgayBan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dtpNgayBan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayBan.StateCommon.Border.Rounding = 10F;
            this.dtpNgayBan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dtpNgayBan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayBan.TabIndex = 6;
            // 
            // cbNguoiBan
            // 
            this.cbNguoiBan.DropDownWidth = 144;
            this.cbNguoiBan.Enabled = false;
            this.cbNguoiBan.Items.AddRange(new object[] {
            "Nguyen Van A (ND001)"});
            this.cbNguoiBan.Location = new System.Drawing.Point(520, 70);
            this.cbNguoiBan.Name = "cbNguoiBan";
            this.cbNguoiBan.Size = new System.Drawing.Size(200, 39);
            this.cbNguoiBan.StateCommon.ComboBox.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.cbNguoiBan.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbNguoiBan.StateCommon.ComboBox.Border.Rounding = 10F;
            this.cbNguoiBan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.cbNguoiBan.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbNguoiBan.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(450, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSave.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnSave.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSave.StateCommon.Border.Rounding = 10F;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.TabIndex = 4;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(610, 550);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(140, 40);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnClear.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnClear.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 10F;
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.TabIndex = 3;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "Xóa";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(780, 550);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(140, 40);
            this.btnAddNew.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnAddNew.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnAddNew.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnAddNew.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnAddNew.StateCommon.Border.Rounding = 10F;
            this.btnAddNew.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddNew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNew.Values.Text = "Làm mới";
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(30, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 32);
            this.lblSearch.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblSearch.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Values.Text = "Tìm kiếm";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.Location = new System.Drawing.Point(300, 30);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(106, 32);
            this.lblNgayBan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNgayBan.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNgayBan.TabIndex = 9;
            this.lblNgayBan.Values.Text = "Ngày bán";
            // 
            // lblNguoiBan
            // 
            this.lblNguoiBan.Location = new System.Drawing.Point(520, 30);
            this.lblNguoiBan.Name = "lblNguoiBan";
            this.lblNguoiBan.Size = new System.Drawing.Size(117, 32);
            this.lblNguoiBan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblNguoiBan.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNguoiBan.TabIndex = 8;
            this.lblNguoiBan.Values.Text = "Người bán";
            // 
            // lblGrandTotalTitle
            // 
            this.lblGrandTotalTitle.Location = new System.Drawing.Point(450, 600);
            this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            this.lblGrandTotalTitle.Size = new System.Drawing.Size(139, 41);
            this.lblGrandTotalTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lblGrandTotalTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotalTitle.TabIndex = 1;
            this.lblGrandTotalTitle.Values.Text = "Tổng tiền";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Location = new System.Drawing.Point(600, 600);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(70, 41);
            this.lblGrandTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblGrandTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Values.Text = "0.00";
            // 
            // FormBanHangView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(934, 634);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblGrandTotalTitle);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbNguoiBan);
            this.Controls.Add(this.dtpNgayBan);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblNguoiBan);
            this.Controls.Add(this.lblNgayBan);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.flpSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanHangView";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNguoiBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPhamCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNgayBan;
        private Krypton.Toolkit.KryptonComboBox cbNguoiBan;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonButton btnAddNew;
        private Krypton.Toolkit.KryptonLabel lblSearch;
        private Krypton.Toolkit.KryptonLabel lblNgayBan;
        private Krypton.Toolkit.KryptonLabel lblNguoiBan;
        private Krypton.Toolkit.KryptonLabel lblGrandTotalTitle;
        private Krypton.Toolkit.KryptonLabel lblGrandTotal;
    }
}