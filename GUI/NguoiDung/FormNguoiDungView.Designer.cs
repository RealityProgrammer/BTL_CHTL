using System.ComponentModel;

namespace CHTL.GUI.NguoiDung {
    partial class FormNguoiDungView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham.FormSanPhamView));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeaderSearch = new Krypton.Toolkit.KryptonPanel();
            this.txt_search = new Krypton.Toolkit.KryptonTextBox();
            this.labelSearch = new Krypton.Toolkit.KryptonLabel();
            this.panelHeaderLeft = new Krypton.Toolkit.KryptonPanel();
            this.btn_add = new Krypton.Toolkit.KryptonButton();
            this.labelHeader = new Krypton.Toolkit.KryptonLabel();
            this.panelHeader = new Krypton.Toolkit.KryptonPanel();
            this.separator = new Krypton.Toolkit.KryptonSeparator();
            this.panelBody = new Krypton.Toolkit.KryptonPanel();
            this.dgv_nguoi_dung = new System.Windows.Forms.DataGridView();
            this.colMaNguoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoi_dung)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeaderSearch
            // 
            this.panelHeaderSearch.Controls.Add(this.txt_search);
            this.panelHeaderSearch.Controls.Add(this.labelSearch);
            this.panelHeaderSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderSearch.Location = new System.Drawing.Point(498, 10);
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
            this.txt_search.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelSearch.Location = new System.Drawing.Point(0, 0);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(370, 36);
            this.labelSearch.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.labelHeader.Size = new System.Drawing.Size(314, 36);
            this.labelHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Values.Text = "Thông tin người dùng";
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHeaderLeft);
            this.panelHeader.Controls.Add(this.panelHeaderSearch);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelHeader.Size = new System.Drawing.Size(878, 125);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeader.TabIndex = 0;
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 125);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(878, 10);
            this.separator.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.separator.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.separator.StateCommon.Separator.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separator.StateCommon.Separator.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separator.StateCommon.Separator.Padding = new System.Windows.Forms.Padding(-1, 10, -1, 10);
            this.separator.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dgv_nguoi_dung);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 135);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(878, 437);
            this.panelBody.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelBody.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelBody.TabIndex = 2;
            // 
            // dgv_nguoi_dung
            // 
            this.dgv_nguoi_dung.AllowUserToResizeColumns = false;
            this.dgv_nguoi_dung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_nguoi_dung.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_nguoi_dung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nguoi_dung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaNguoiDung, this.colTenDangNhap, this.colVaiTro, this.colHoTen, this.colEdit, this.colDelete
            });
            this.dgv_nguoi_dung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_nguoi_dung.Location = new System.Drawing.Point(0, 0);
            this.dgv_nguoi_dung.Name = "dgv_nguoi_dung";
            this.dgv_nguoi_dung.RowHeadersWidth = 51;
            this.dgv_nguoi_dung.Size = new System.Drawing.Size(878, 437);
            this.dgv_nguoi_dung.TabIndex = 5;
            this.dgv_nguoi_dung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kryptonDataGridView1_CellClick);
            // 
            // colMaNguoiDung
            // 
            this.colMaNguoiDung.DataPropertyName = "MaNguoiDung";
            this.colMaNguoiDung.HeaderText = "Mã Người Dùng";
            this.colMaNguoiDung.MinimumWidth = 6;
            this.colMaNguoiDung.Name = "colMaNguoiDung";
            // 
            // colTenDangNhap
            // 
            this.colTenDangNhap.DataPropertyName = "TenDangNhap";
            this.colTenDangNhap.HeaderText = "Tên Đăng Nhập";
            this.colTenDangNhap.MinimumWidth = 6;
            this.colTenDangNhap.Name = "colTenDangNhap";
            // 
            // colVaiTro
            // 
            this.colVaiTro.DataPropertyName = "VaiTro";
            this.colVaiTro.HeaderText = "Vai Trò";
            this.colVaiTro.MinimumWidth = 6;
            this.colVaiTro.Name = "colVaiTro";
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
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
            // 
            // FormNguoiDungView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(878, 572);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.Name = "FormNguoiDungView";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nguoi_dung)).EndInit();
            this.ResumeLayout(false);
        }
        private Krypton.Toolkit.KryptonButton btn_add;
        private System.Windows.Forms.DataGridView dgv_nguoi_dung;

        private Krypton.Toolkit.KryptonPanel panelBody;
        private Krypton.Toolkit.KryptonSeparator separator;
        private Krypton.Toolkit.KryptonPanel panelHeaderSearch;
        private Krypton.Toolkit.KryptonLabel labelSearch;
        private Krypton.Toolkit.KryptonPanel panelHeaderLeft;
        private Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonLabel labelHeader;
        private Krypton.Toolkit.KryptonTextBox txt_search;

        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNguoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        #endregion
    }
}