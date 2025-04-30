using System.ComponentModel;

namespace CHTL.GUI.DanhMuc {
    partial class FormDanhMucView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhMucView));
            this.panelHeader = new Krypton.Toolkit.KryptonPanel();
            this.panelHeaderSearch = new Krypton.Toolkit.KryptonPanel();
            this.txt_search = new Krypton.Toolkit.KryptonTextBox();
            this.labelSearch = new Krypton.Toolkit.KryptonLabel();
            this.panelHeaderLeft = new Krypton.Toolkit.KryptonPanel();
            this.btn_add = new Krypton.Toolkit.KryptonButton();
            this.labelHeader = new Krypton.Toolkit.KryptonLabel();
            this.separator = new Krypton.Toolkit.KryptonSeparator();
            this.panelBody = new Krypton.Toolkit.KryptonPanel();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.colMaDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenDanhMuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderSearch)).BeginInit();
            this.panelHeaderSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderLeft)).BeginInit();
            this.panelHeaderLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.panelHeaderSearch);
            this.panelHeader.Controls.Add(this.panelHeaderLeft);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panelHeader.Size = new System.Drawing.Size(858, 121);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeader.TabIndex = 0;
            // 
            // panelHeaderSearch
            // 
            this.panelHeaderSearch.Controls.Add(this.txt_search);
            this.panelHeaderSearch.Controls.Add(this.labelSearch);
            this.panelHeaderSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderSearch.Location = new System.Drawing.Point(478, 10);
            this.panelHeaderSearch.Name = "panelHeaderSearch";
            this.panelHeaderSearch.Size = new System.Drawing.Size(370, 111);
            this.panelHeaderSearch.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeaderSearch.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelHeaderSearch.TabIndex = 3;
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
            this.panelHeaderLeft.Size = new System.Drawing.Size(314, 111);
            this.panelHeaderLeft.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelHeaderLeft.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelHeaderLeft.TabIndex = 2;
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
            // 
            // labelHeader
            // 
            this.labelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHeader.Location = new System.Drawing.Point(0, 0);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(314, 36);
            this.labelHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Values.Text = "Thông tin danh mục";
            // 
            // separator
            // 
            this.separator.Dock = System.Windows.Forms.DockStyle.Top;
            this.separator.Location = new System.Drawing.Point(0, 121);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(858, 10);
            this.separator.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.separator.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.separator.StateCommon.Separator.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separator.StateCommon.Separator.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.separator.StateCommon.Separator.Padding = new System.Windows.Forms.Padding(-1, 10, -1, 10);
            this.separator.TabIndex = 1;
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.dgvDanhMuc);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 131);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(858, 443);
            this.panelBody.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.panelBody.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.panelBody.TabIndex = 2;
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colMaDanhMuc, this.colTenDanhMuc, this.colEdit, this.colDelete
            });
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.RowTemplate.Height = 30;
            this.dgvDanhMuc.Size = new System.Drawing.Size(858, 443);
            this.dgvDanhMuc.TabIndex = 6;
            this.dgvDanhMuc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_muc_CellClick);
            this.dgvDanhMuc.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_muc_CellMouseEnter);
            this.dgvDanhMuc.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danh_muc_CellMouseLeave);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(858, 574);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Inherit;
            this.Name = "FormDanhMucView";
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderSearch)).EndInit();
            this.panelHeaderSearch.ResumeLayout(false);
            this.panelHeaderSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderLeft)).EndInit();
            this.panelHeaderLeft.ResumeLayout(false);
            this.panelHeaderLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);
        }
        private Krypton.Toolkit.KryptonPanel panelHeaderLeft;
        private Krypton.Toolkit.KryptonButton btn_add;
        private Krypton.Toolkit.KryptonLabel labelHeader;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenDanhMuc;
        private System.Windows.Forms.DataGridViewButtonColumn colEdit;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        protected Krypton.Toolkit.KryptonPanel panelBody;
        protected Krypton.Toolkit.KryptonSeparator separator;
        private Krypton.Toolkit.KryptonPanel panelHeaderSearch;
        private Krypton.Toolkit.KryptonLabel labelSearch;
        protected Krypton.Toolkit.KryptonPanel panelHeader;
        private Krypton.Toolkit.KryptonTextBox txt_search;

        #endregion
    }
}