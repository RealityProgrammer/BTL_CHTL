namespace CHTL.GUI.NguoiDung
{
    partial class FormNguoiDungView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        private void InitializeComponent()
        {
           
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.colMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.colDelete = new ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn();
            this.dgv_nguoi_dung = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoi_dung)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(590, 23);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(590, 65);
            this.txt_search.Size = new System.Drawing.Size(260, 42);
            this.txt_search.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_search.StateCommon.Border.Rounding = 12;
            this.txt_search.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.txt_search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Size = new System.Drawing.Size(149, 42);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.Values.Text = "Nhân viên";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(31, 139);
            this.kryptonSeparator1.Size = new System.Drawing.Size(819, 10);
            this.kryptonSeparator1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kryptonSeparator1.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonSeparator1.StateCommon.Separator.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // dgv_nguoi_dung
            // 
            this.dgv_nguoi_dung.AllowUserToResizeColumns = false;
            this.dgv_nguoi_dung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoi_dung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaNguoiDung,
            this.colTenDangNhap,
            this.colVaiTro,
            this.colHoTen,
            this.colEdit,
            this.colDelete});
            this.dgv_nguoi_dung.Location = new System.Drawing.Point(39, 197);
            this.dgv_nguoi_dung.Name = "dgv_nguoi_dung";
            this.dgv_nguoi_dung.RowHeadersWidth = 51;
            this.dgv_nguoi_dung.Size = new System.Drawing.Size(811, 410);
            this.dgv_nguoi_dung.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_nguoi_dung.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.dgv_nguoi_dung.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dgv_nguoi_dung.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.MidnightBlue;
            this.dgv_nguoi_dung.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.Black;
            this.dgv_nguoi_dung.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.Black;
            this.dgv_nguoi_dung.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.Black;
            this.dgv_nguoi_dung.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.Black;
            this.dgv_nguoi_dung.TabIndex = 5;
            this.dgv_nguoi_dung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_nguoi_dung_CellClick);
            // 
            // colMaNguoiDung
            // 
            this.colMaNguoiDung.DataPropertyName = "MaNguoiDung";
            this.colMaNguoiDung.HeaderText = "Mã Người Dùng";
            this.colMaNguoiDung.MinimumWidth = 6;
            this.colMaNguoiDung.Name = "colMaNguoiDung";
            this.colMaNguoiDung.Width = 125;
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            this.colTenDangNhap.Width = 125;
            // 
            // colVaiTro
            // 
            this.colVaiTro.DataPropertyName = "VaiTro";
            this.colVaiTro.HeaderText = "Vai Trò";
            this.colVaiTro.MinimumWidth = 6;
            this.colVaiTro.Name = "colVaiTro";
            this.colVaiTro.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 125;
            // 
            // colEdit
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Sửa";
            this.colEdit.DefaultCellStyle = dataGridViewCellStyle1;
            this.colEdit.HeaderText = "Sửa";
            this.colEdit.MinimumWidth = 6;
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Sửa";
            this.colEdit.UseColumnTextForButtonValue = true;
            this.colEdit.Width = 125;
            // 
            // colDelete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "Xóa";
            this.colDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.MinimumWidth = 6;
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Xóa";
            this.colDelete.UseColumnTextForButtonValue = true;
            this.colDelete.Width = 125;
            // 
            // FormNguoiDungView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 663);
            this.Controls.Add(this.dgv_nguoi_dung);
            this.Name = "FormNguoiDungView";
            this.Text = "FormNguoiDungView";
            this.WindowState = System.Windows.Forms.FormWindowState.Normal;
            this.Load += new System.EventHandler(this.FormNguoiDungView_Load);
            this.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.Controls.SetChildIndex(this.txt_search, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.Controls.SetChildIndex(this.kryptonSeparator1, 0);
            this.Controls.SetChildIndex(this.dgv_nguoi_dung, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoi_dung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn colEdit;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridViewButtonColumn colDelete;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView dgv_nguoi_dung;
    }
}