using System.Drawing; 
namespace CHTL.GUI.DanhMuc
{
    partial class FormDanhMucView
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
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.colMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(620, 30);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(119, 38);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel1.Values.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(620, 70);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(300, 40);
            this.txt_search.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.txt_search.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            | Krypton.Toolkit.PaletteDrawBorders.Left)
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_search.StateCommon.Border.Rounding = 10F;
            this.txt_search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(30, 30);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(300, 50);
            this.kryptonLabel2.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.kryptonLabel2.Values.Text = "Danh mục sản phẩm";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(30, 150);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Size = new System.Drawing.Size(890, 2);
            this.kryptonSeparator1.StateCommon.Back.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            this.kryptonSeparator1.StateCommon.Back.Color2 = Color.FromArgb(189, 195, 199);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(30, 70);
            this.btn_add.Name = "btn_add";
            
            //this.btn_add.Size = new System.Drawing.Size(150, 40);
            //this.btn_add.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            //this.btn_add.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            //this.btn_add.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            //this.btn_add.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
            //| Krypton.Toolkit.PaletteDrawBorders.Left)
            //| Krypton.Toolkit.PaletteDrawBorders.Right)));
            //this.btn_add.StateCommon.Border.Rounding = 10F;
            //this.btn_add.StateCommon.Content.ShortText.Color1 = Color.White;
            //this.btn_add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            //this.btn_add.Values.Text = "Thêm";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaDanhMuc,
            this.colTenDanhMuc,
            this.colEdit,
            this.colDelete});
            this.dgvDanhMuc.Location = new System.Drawing.Point(30, 170);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 30;
            this.dgvDanhMuc.Size = new System.Drawing.Size(890, 450);
            this.dgvDanhMuc.TabIndex = 5;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_muc_CellClick);
            this.dgvDanhMuc.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_muc_CellMouseEnter);
            this.dgvDanhMuc.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_muc_CellMouseLeave);
            // 
            // colMaDanhMuc
            // 
            this.colMaDanhMuc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaDanhMuc.DataPropertyName = "MaDanhMuc";
            this.colMaDanhMuc.HeaderText = "Mã danh mục";
            this.colMaDanhMuc.Name = "colMaDanhMuc";
            this.colMaDanhMuc.Width = 150;
            // 
            // colTenDanhMuc
            // 
            this.colTenDanhMuc.DataPropertyName = "TenDanhMuc";
            this.colTenDanhMuc.HeaderText = "Tên danh mục";
            this.colTenDanhMuc.Name = "colTenDanhMuc";
            // 
            // colEdit
            // 
            this.colEdit.HeaderText = "Sửa";
            this.colEdit.Name = "colEdit";
            this.colEdit.Text = "Sửa";
            this.colEdit.UseColumnTextForButtonValue = true;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "Xóa";
            this.colDelete.Name = "colDelete";
            this.colDelete.Text = "Xóa";
            this.colDelete.UseColumnTextForButtonValue = true;
            // 
            // FormDanhMucView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.dgvDanhMuc);
            this.Name = "FormDanhMucView";
            this.Controls.SetChildIndex(this.dgvDanhMuc, 0);
            this.Controls.SetChildIndex(this.kryptonLabel1, 0);
            this.Controls.SetChildIndex(this.txt_search, 0);
            this.Controls.SetChildIndex(this.btn_add, 0);
            this.Controls.SetChildIndex(this.kryptonLabel2, 0);
            this.Controls.SetChildIndex(this.kryptonSeparator1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
    }
}