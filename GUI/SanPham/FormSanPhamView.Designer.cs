namespace CHTL.GUI.SanPham
{
    partial class FormSanPhamView
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
            this.dgv_san_pham = new System.Windows.Forms.DataGridView();
            this.colMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(604, 38);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(587, 80);
            this.txt_search.Size = new System.Drawing.Size(261, 42);
            this.txt_search.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_search.StateCommon.Border.Rounding = 12F;
            this.txt_search.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.txt_search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(23, 16);
            this.kryptonLabel2.Size = new System.Drawing.Size(145, 42);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = System.Drawing.Color.Navy;
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.Values.Text = "Sản phẩm";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(8, 138);
            this.kryptonSeparator1.Size = new System.Drawing.Size(829, 11);
            this.kryptonSeparator1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kryptonSeparator1.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonSeparator1.StateCommon.Separator.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(33, 58);
            this.btn_add.Size = new System.Drawing.Size(120, 64);
            // 
            // dgv_san_pham
            // 
            this.dgv_san_pham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_san_pham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_san_pham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_san_pham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaSanPham, this.colTenSanPham, this.colGiaBan, this.colMaDanhMuc, this.colSoLuongTon, this.colNgayHetHan, this.colEdit, this.colDelete
            });
            this.dgv_san_pham.GridColor = System.Drawing.Color.Gray;
            this.dgv_san_pham.Location = new System.Drawing.Point(8, 155);
            this.dgv_san_pham.Name = "dgv_san_pham";
            this.dgv_san_pham.RowHeadersWidth = 51;
            this.dgv_san_pham.RowTemplate.Height = 24;
            this.dgv_san_pham.Size = new System.Drawing.Size(829, 450);
            this.dgv_san_pham.TabIndex = 5;
            this.dgv_san_pham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_san_pham_CellClick);
            // 
            // colMaSanPham
            // 
            this.colMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaSanPham.DataPropertyName = "MaSanPham";
            this.colMaSanPham.HeaderText = "Mã sản phẩm";
            this.colMaSanPham.MinimumWidth = 6;
            this.colMaSanPham.Name = "colMaSanPham";
            this.colMaSanPham.Width = 150;
            // 
            // colTenSanPham
            // 
            this.colTenSanPham.DataPropertyName = "TenSanPham";
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.MinimumWidth = 6;
            this.colTenSanPham.Name = "colTenSanPham";
            // 
            // colGiaBan
            // 
            this.colGiaBan.DataPropertyName = "GiaBan";
            this.colGiaBan.HeaderText = "Giá bán";
            this.colGiaBan.MinimumWidth = 6;
            this.colGiaBan.Name = "colGiaBan";
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
            // colEdit
            // 
            this.colEdit.HeaderText = "Sửa";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(844, 592);
            this.Controls.Add(this.dgv_san_pham);
            this.Name = "FormSanPhamView";
            this.Text = "FormSanPhamView";
            this.Controls.SetChildIndex(this.dgv_san_pham, 0);
            this.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.Controls.SetChildIndex(this.txt_search, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.Controls.SetChildIndex(this.kryptonSeparator1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_san_pham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.DataGridView dgv_san_pham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayHetHan;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}