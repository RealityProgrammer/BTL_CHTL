using System.ComponentModel;

namespace CHTL.GUI.SanPham {
    partial class FormSanPhamView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSanPhamView));
            this.panelHeaderSearch = new Krypton.Toolkit.KryptonPanel();
            this.txt_search = new Krypton.Toolkit.KryptonTextBox();
            this.labelSearch = new Krypton.Toolkit.KryptonLabel();
            this.panelHeaderLeft = new Krypton.Toolkit.KryptonPanel();
            this.btn_add = new Krypton.Toolkit.KryptonButton();
            this.labelHeader = new Krypton.Toolkit.KryptonLabel();
            this.panelHeader = new Krypton.Toolkit.KryptonPanel();
            this.separator = new Krypton.Toolkit.KryptonSeparator();
            this.panelBody = new Krypton.Toolkit.KryptonPanel();
            this.dgv_san_pham = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBanCuoiCung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderSearch)).BeginInit();
            this.panelHeaderSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderLeft)).BeginInit();
            this.panelHeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderSearch
            // 
            this.panelHeaderSearch.Controls.Add(this.txt_search);
            this.panelHeaderSearch.Controls.Add(this.labelSearch);
            this.panelHeaderSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderSearch.Location = new System.Drawing.Point(497, 10);
            this.panelHeaderSearch.Name = "panelHeaderSearch";
            this.panelHeaderSearch.Size = new System.Drawing.Size(370, 115);
            this.panelHeaderSearch.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeaderSearch.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelHeaderSearch.TabIndex = 1;
            // 
            // txt_search
            // 
            this.txt_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_search.Location = new System.Drawing.Point(0, 36);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(370, 44);
            this.txt_search.StateCommon.Border.Rounding = 8F;
            this.txt_search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSearch.Location = new System.Drawing.Point(0, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(370, 36);
            this.labelSearch.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Values.Text = "Tìm kiếm";
            // 
            // panelHeaderLeft
            // 
            this.panelHeaderLeft.Controls.Add(this.btn_add);
            this.panelHeaderLeft.Controls.Add(this.labelHeader);
            this.panelHeaderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHeaderLeft.Location = new System.Drawing.Point(10, 10);
            this.panelHeaderLeft.Name = "panelHeaderLeft";
            this.panelHeaderLeft.Size = new System.Drawing.Size(314, 115);
            this.panelHeaderLeft.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeaderLeft.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelHeaderLeft.TabIndex = 1;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(0, 42);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 64);
            this.btn_add.StateCommon.Back.Draw = Krypton.Toolkit.InheritBool.False;
            this.btn_add.StateCommon.Border.Draw = Krypton.Toolkit.InheritBool.False;
            this.btn_add.TabIndex = 1;
            this.btn_add.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_add.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Values.Image")));
            this.btn_add.Values.Text = "";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(314, 42);
            this.labelHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Values.Text = "Thông tin sản phẩm";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHeaderLeft);
            this.panelHeader.Controls.Add(this.panelHeaderSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelHeader.Size = new System.Drawing.Size(877, 125);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeader.TabIndex = 0;
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 125);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(877, 10);
            this.separator.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.separator.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.separator.StateCommon.Separator.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separator.StateCommon.Separator.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separator.StateCommon.Separator.Padding = new System.Windows.Forms.Padding(-1, 10, -1, 10);
            this.separator.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dgv_san_pham);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 135);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(877, 328);
            this.panelBody.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelBody.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelBody.TabIndex = 2;
            // 
            // dgv_san_pham
            // 
            this.dgv_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_san_pham.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgv_san_pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_san_pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSanPham,
            this.colTenSanPham,
            this.colMaDanhMuc,
            this.colSoLuongTon,
            this.colNgayHetHan,
            this.colGiaBan,
            this.colGiamGia,
            this.colGiaBanCuoiCung,
            this.colEdit,
            this.colDelete});
            this.dgv_san_pham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_san_pham.Location = new System.Drawing.Point(0, 0);
            this.dgv_san_pham.Name = "dgv_san_pham";
            this.dgv_san_pham.RowHeadersWidth = 51;
            this.dgv_san_pham.RowTemplate.Height = 30;
            this.dgv_san_pham.Size = new System.Drawing.Size(877, 328);
            this.dgv_san_pham.TabIndex = 6;
            this.dgv_san_pham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_san_pham_CellClick);
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.MinimumWidth = 6;
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Width = 120;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.MinimumWidth = 6;
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // colMaDanhMuc
            // 
            this.colMaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.colMaDanhMuc.HeaderText = "Mã danh mục";
            this.colMaDanhMuc.MinimumWidth = 6;
            this.colMaDanhMuc.Name = "colMaDanhMuc";
            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.DataPropertyName = "SoLuongTon";
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.MinimumWidth = 6;
            this.colSoLuongTon.Name = "colSoLuongTon";
            // 
            // colNgayHetHan
            // 
            this.colNgayHetHan.DataPropertyName = "NgayHetHan";
            this.colNgayHetHan.HeaderText = "Ngày hết hạn";
            this.colNgayHetHan.MinimumWidth = 6;
            this.colNgayHetHan.Name = "colNgayHetHan";
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 6;
            this.colGiaBan.Name = "colGiaBan";
            // 
            // colGiamGia
            // 
            this.colGiamGia.DataPropertyName = "GiamGia";
            this.colGiamGia.HeaderText = "Giảm giá";
            this.colGiamGia.MinimumWidth = 6;
            this.colGiamGia.Name = "colGiamGia";
            // 
            // colGiaBanCuoiCung
            // 
            this.colGiaBanCuoiCung.DataPropertyName = "GiaBanCuoiCung";
            this.colGiaBanCuoiCung.HeaderText = "Giá bán cuối cùng";
            this.colGiaBanCuoiCung.MinimumWidth = 6;
            this.colGiaBanCuoiCung.Name = "colGiaBanCuoiCung";
            this.colGiaBanCuoiCung.ReadOnly = true;
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Sửa";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Sửa";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Xóa";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // FormSanPhamView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(877, 463);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.Name = "FormSanPhamView";
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderSearch)).EndInit();
            this.panelHeaderSearch.ResumeLayout(false);
            this.panelHeaderSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderLeft)).EndInit();
            this.panelHeaderLeft.ResumeLayout(false);
            this.panelHeaderLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.DataGridView dgv_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBanCuoiCung;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private Krypton.Toolkit.KryptonButton btn_add;

        private Krypton.Toolkit.KryptonPanel panelBody;
        private Krypton.Toolkit.KryptonSeparator separator;
        private Krypton.Toolkit.KryptonPanel panelHeaderSearch;
        private Krypton.Toolkit.KryptonLabel labelSearch;
        private Krypton.Toolkit.KryptonPanel panelHeaderLeft;
        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel labelHeader;
        private Krypton.Toolkit.KryptonTextBox txt_search;

        #endregion
    }
}