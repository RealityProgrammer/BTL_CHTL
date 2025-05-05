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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.Panel panelHeader2;
            Krypton.Toolkit.KryptonLabel lblNgayBan;
            Krypton.Toolkit.KryptonTableLayoutPanel tableFooter;
            Krypton.Toolkit.KryptonLabel lblSearch;
            Krypton.Toolkit.KryptonLabel lblGrandTotalTitle;
            System.Windows.Forms.Panel panel1;
            this.dtpNgayBan = new Krypton.Toolkit.KryptonDateTimePicker();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.btnClear = new Krypton.Toolkit.KryptonButton();
            this.btnAddNew = new Krypton.Toolkit.KryptonButton();
            this.lblGrandTotal = new Krypton.Toolkit.KryptonLabel();
            this.flpSanPham = new System.Windows.Forms.FlowLayoutPanel();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.colTenSanPhamCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBanCT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new Krypton.Toolkit.KryptonTextBox();
            this.panelHeader = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panelHeader1 = new System.Windows.Forms.Panel();
            this.panelContent = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.panelContentRight = new System.Windows.Forms.Panel();
            panelHeader2 = new System.Windows.Forms.Panel();
            lblNgayBan = new Krypton.Toolkit.KryptonLabel();
            tableFooter = new Krypton.Toolkit.KryptonTableLayoutPanel();
            lblSearch = new Krypton.Toolkit.KryptonLabel();
            lblGrandTotalTitle = new Krypton.Toolkit.KryptonLabel();
            panel1 = new System.Windows.Forms.Panel();
            panelHeader2.SuspendLayout();
            tableFooter.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelHeader1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelContentRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader2
            // 
            panelHeader2.Controls.Add(this.dtpNgayBan);
            panelHeader2.Controls.Add(lblNgayBan);
            panelHeader2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelHeader2.Location = new System.Drawing.Point(401, 13);
            panelHeader2.Name = "panelHeader2";
            panelHeader2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            panelHeader2.Size = new System.Drawing.Size(383, 84);
            panelHeader2.TabIndex = 1;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayBan.Location = new System.Drawing.Point(5, 32);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(373, 39);
            this.dtpNgayBan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dtpNgayBan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpNgayBan.StateCommon.Border.Rounding = 10F;
            this.dtpNgayBan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dtpNgayBan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtpNgayBan.TabIndex = 6;
            // 
            // lblNgayBan
            // 
            lblNgayBan.Dock = System.Windows.Forms.DockStyle.Top;
            lblNgayBan.Location = new System.Drawing.Point(5, 0);
            lblNgayBan.Name = "lblNgayBan";
            lblNgayBan.Size = new System.Drawing.Size(373, 32);
            lblNgayBan.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            lblNgayBan.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblNgayBan.TabIndex = 9;
            lblNgayBan.Values.Text = "Ngày bán";
            // 
            // tableFooter
            // 
            tableFooter.ColumnCount = 5;
            tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            tableFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            tableFooter.Controls.Add(this.btnSave, 0, 0);
            tableFooter.Controls.Add(this.btnClear, 2, 0);
            tableFooter.Controls.Add(this.btnAddNew, 4, 0);
            tableFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            tableFooter.Location = new System.Drawing.Point(0, 260);
            tableFooter.Name = "tableFooter";
            tableFooter.RowCount = 1;
            tableFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableFooter.Size = new System.Drawing.Size(383, 46);
            tableFooter.StateCommon.Color1 = System.Drawing.Color.Transparent;
            tableFooter.StateCommon.Color2 = System.Drawing.Color.Transparent;
            tableFooter.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 40);
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
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClear.Location = new System.Drawing.Point(140, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 40);
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
            this.btnAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddNew.Location = new System.Drawing.Point(277, 3);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(103, 40);
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
            lblSearch.Dock = System.Windows.Forms.DockStyle.Top;
            lblSearch.Location = new System.Drawing.Point(5, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new System.Drawing.Size(372, 32);
            lblSearch.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            lblSearch.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            lblSearch.TabIndex = 10;
            lblSearch.Values.Text = "Tìm kiếm";
            // 
            // lblGrandTotalTitle
            // 
            lblGrandTotalTitle.Location = new System.Drawing.Point(3, 3);
            lblGrandTotalTitle.Name = "lblGrandTotalTitle";
            lblGrandTotalTitle.Size = new System.Drawing.Size(139, 41);
            lblGrandTotalTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            lblGrandTotalTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblGrandTotalTitle.TabIndex = 1;
            lblGrandTotalTitle.Values.Text = "Tổng tiền";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblGrandTotalTitle);
            panel1.Controls.Add(this.lblGrandTotal);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 215);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(383, 45);
            panel1.TabIndex = 2;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.Location = new System.Drawing.Point(136, 3);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(70, 41);
            this.lblGrandTotal.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.lblGrandTotal.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.TabIndex = 0;
            this.lblGrandTotal.Values.Text = "0.00";
            // 
            // flpSanPham
            // 
            this.flpSanPham.AutoScroll = true;
            this.flpSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.flpSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpSanPham.Location = new System.Drawing.Point(13, 3);
            this.flpSanPham.Name = "flpSanPham";
            this.flpSanPham.Size = new System.Drawing.Size(382, 306);
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
            this.dgvChiTietHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(0, 0);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.RowHeadersWidth = 51;
            this.dgvChiTietHoaDon.RowTemplate.Height = 30;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(383, 306);
            this.dgvChiTietHoaDon.TabIndex = 1;
            this.dgvChiTietHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellClick);
            this.dgvChiTietHoaDon.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellMouseEnter);
            this.dgvChiTietHoaDon.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietHoaDon_CellMouseLeave);
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
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Location = new System.Drawing.Point(5, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(372, 40);
            this.txtSearch.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.txtSearch.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtSearch.StateCommon.Border.Rounding = 10F;
            this.txtSearch.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.TabIndex = 7;
            // 
            // panelHeader
            // 
            this.panelHeader.ColumnCount = 2;
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.panelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.panelHeader.Controls.Add(this.panelHeader1, 0, 0);
            this.panelHeader.Controls.Add(panelHeader2, 1, 0);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelHeader.RowCount = 1;
            this.panelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelHeader.Size = new System.Drawing.Size(797, 100);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeader.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelHeader.TabIndex = 14;
            // 
            // panelHeader1
            // 
            this.panelHeader1.Controls.Add(this.txtSearch);
            this.panelHeader1.Controls.Add(lblSearch);
            this.panelHeader1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeader1.Location = new System.Drawing.Point(13, 13);
            this.panelHeader1.Name = "panelHeader1";
            this.panelHeader1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.panelHeader1.Size = new System.Drawing.Size(382, 84);
            this.panelHeader1.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.ColumnCount = 2;
            this.panelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContent.Controls.Add(this.flpSanPham, 0, 0);
            this.panelContent.Controls.Add(this.panelContentRight, 1, 0);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 100);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.panelContent.RowCount = 1;
            this.panelContent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelContent.Size = new System.Drawing.Size(797, 322);
            this.panelContent.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelContent.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelContent.TabIndex = 16;
            // 
            // panelContentRight
            // 
            this.panelContentRight.Controls.Add(panel1);
            this.panelContentRight.Controls.Add(tableFooter);
            this.panelContentRight.Controls.Add(this.dgvChiTietHoaDon);
            this.panelContentRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentRight.Location = new System.Drawing.Point(401, 3);
            this.panelContentRight.Name = "panelContentRight";
            this.panelContentRight.Size = new System.Drawing.Size(383, 306);
            this.panelContentRight.TabIndex = 1;
            // 
            // FormBanHangView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(797, 422);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanHangView";
            panelHeader2.ResumeLayout(false);
            panelHeader2.PerformLayout();
            tableFooter.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader1.ResumeLayout(false);
            this.panelHeader1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContentRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelContentRight;
        private Krypton.Toolkit.KryptonTableLayoutPanel panelContent;
        private System.Windows.Forms.Panel panelHeader1;
        private Krypton.Toolkit.KryptonTableLayoutPanel panelHeader;

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpSanPham;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPhamCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanCT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private Krypton.Toolkit.KryptonTextBox txtSearch;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNgayBan;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnClear;
        private Krypton.Toolkit.KryptonButton btnAddNew;
        private Krypton.Toolkit.KryptonLabel lblGrandTotal;
    }
}