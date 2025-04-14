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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colTenSanPhamCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBanCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
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
            this.flpSanPham.Location = new System.Drawing.Point(30, 120);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(335, 450);
            this.flpSanPham.TabIndex = 0;
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTenSanPhamCT, this.colSoLuongCT, this.colGiaBanCT, this.colThanhTien, this.colDelete
            });
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(390, 120);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 24;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(453, 350);
            this.dgvChiTietHoaDon.TabIndex = 1;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            // 
            // colTenSanPhamCT
            // 
            this.colTenSanPhamCT.DataPropertyName = "TenSanPham";
            this.colTenSanPhamCT.HeaderText = "Sản phẩm";
            this.colTenSanPhamCT.MinimumWidth = 6;
            this.colTenSanPhamCT.Name = "colTenSanPhamCT";
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
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Xóa";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 68);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 40);
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10F;
            this.txtSearch.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.TabIndex = 7;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Location = new System.Drawing.Point(310, 68);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(150, 39);
            this.dtpNgayBan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayBan.StateCommon.Border.Rounding = 10F;
            this.dtpNgayBan.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.dtpNgayBan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayBan.TabIndex = 6;
            // 
            // cbNguoiBan
            // 
            this.cbNguoiBan.DropDownWidth = 144;
            this.cbNguoiBan.Enabled = false;
            this.cbNguoiBan.Items.AddRange(new object[] {
                "Nguyen Van A (ND001)"
            });
            this.cbNguoiBan.Location = new System.Drawing.Point(530, 68);
            this.cbNguoiBan.Name = "cbNguoiBan";
            this.cbNguoiBan.Size = new System.Drawing.Size(150, 39);
            this.cbNguoiBan.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cbNguoiBan.StateCommon.ComboBox.Border.Rounding = 10F;
            this.cbNguoiBan.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.cbNguoiBan.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbNguoiBan.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(405, 490);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 40);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.btnSave.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.TabIndex = 4;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(548, 490);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 40);
            this.btnClear.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnClear.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.btnClear.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClear.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.TabIndex = 3;
            this.btnClear.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnClear.Values.Text = "Xóa";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(692, 490);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(117, 40);
            this.btnAddNew.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNew.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAddNew.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnAddNew.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddNew.TabIndex = 2;
            this.btnAddNew.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnAddNew.Values.Text = "Thêm mới";
            // 
            // lblSearch
            // 
            this.lblSearch.Location = new System.Drawing.Point(30, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(103, 32);
            this.lblSearch.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblSearch.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSearch.TabIndex = 10;
            this.lblSearch.Values.Text = "Tìm kiếm";
            // 
            // lblNgayBan
            // 
            this.lblNgayBan.Location = new System.Drawing.Point(310, 30);
            this.lblNgayBan.Name = "lblNgayBan";
            this.lblNgayBan.Size = new System.Drawing.Size(106, 32);
            this.lblNgayBan.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblNgayBan.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNgayBan.TabIndex = 9;
            this.lblNgayBan.Values.Text = "Ngày bán";
            // 
            // lblNguoiBan
            // 
            this.lblNguoiBan.Location = new System.Drawing.Point(530, 30);
            this.lblNguoiBan.Name = "lblNguoiBan";
            this.lblNguoiBan.Size = new System.Drawing.Size(117, 32);
            this.lblNguoiBan.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblNguoiBan.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNguoiBan.TabIndex = 8;
            this.lblNguoiBan.Values.Text = "Người bán";
            // 
            // lblGrandTotalTitle
            // 
            this.lblGrandTotalTitle.Location = new System.Drawing.Point(466, 540);
            this.lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            this.lblGrandTotalTitle.Size = new System.Drawing.Size(123, 36);
            this.lblGrandTotalTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.lblGrandTotalTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotalTitle.TabIndex = 1;
            this.lblGrandTotalTitle.Values.Text = "Tổng tiền";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Location = new System.Drawing.Point(596, 540);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(62, 36);
            this.lblGrandTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(71)))));
            this.lblGrandTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Values.Text = "0.00";
            // 
            // FormBanHangView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(869, 568);
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
            this.Text = "Bán hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNguoiBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPhamCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
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