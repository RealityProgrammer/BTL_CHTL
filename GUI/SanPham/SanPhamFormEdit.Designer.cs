using System.ComponentModel;

namespace CHTL.GUI.SanPham {
    partial class SanPhamFormEdit {
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
            Krypton.Toolkit.KryptonLabel kryptonLabel1;
            Krypton.Toolkit.KryptonLabel kryptonLabel3;
            Krypton.Toolkit.KryptonLabel kryptonLabel4;
            Krypton.Toolkit.KryptonLabel kryptonLabel5;
            Krypton.Toolkit.KryptonLabel kryptonLabel6;
            Krypton.Toolkit.KryptonLabel kryptonLabel2;
            Krypton.Toolkit.KryptonLabel kryptonLabel9;
            Krypton.Toolkit.KryptonLabel kryptonLabel7;
            Krypton.Toolkit.KryptonLabel kryptonLabel8;
            Krypton.Toolkit.KryptonLabel kryptonLabel10;
            Krypton.Toolkit.KryptonLabel kryptonLabel11;
            Krypton.Toolkit.KryptonLabel kryptonLabel12;
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.btn_close = new Krypton.Toolkit.KryptonButton();
            this.btn_save = new Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textboxID = new Krypton.Toolkit.KryptonTextBox();
            this.textboxName = new Krypton.Toolkit.KryptonTextBox();
            this.textboxInventoryAmount = new Krypton.Toolkit.KryptonTextBox();
            this.textboxPrice = new Krypton.Toolkit.KryptonTextBox();
            this.textboxSale = new Krypton.Toolkit.KryptonTextBox();
            this.dtpExpiration = new Krypton.Toolkit.KryptonDateTimePicker();
            this.cbCategoryId = new Krypton.Toolkit.KryptonComboBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoryId)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new System.Drawing.Point(160, 31);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new System.Drawing.Size(193, 42);
            kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "Sửa sản phẩm";
            // 
            // kryptonLabel3
            // 
            kryptonLabel3.Location = new System.Drawing.Point(23, 73);
            kryptonLabel3.Name = "kryptonLabel3";
            kryptonLabel3.Size = new System.Drawing.Size(107, 24);
            kryptonLabel3.TabIndex = 3;
            kryptonLabel3.Values.Text = "Tên sản phẩm";
            // 
            // kryptonLabel4
            // 
            kryptonLabel4.Location = new System.Drawing.Point(23, 123);
            kryptonLabel4.Name = "kryptonLabel4";
            kryptonLabel4.Size = new System.Drawing.Size(100, 24);
            kryptonLabel4.TabIndex = 4;
            kryptonLabel4.Values.Text = "Số lượng tồn";
            // 
            // kryptonLabel5
            // 
            kryptonLabel5.Location = new System.Drawing.Point(23, 173);
            kryptonLabel5.Name = "kryptonLabel5";
            kryptonLabel5.Size = new System.Drawing.Size(103, 24);
            kryptonLabel5.TabIndex = 5;
            kryptonLabel5.Values.Text = "Ngày hết hạn";
            // 
            // kryptonLabel6
            // 
            kryptonLabel6.Location = new System.Drawing.Point(23, 223);
            kryptonLabel6.Name = "kryptonLabel6";
            kryptonLabel6.Size = new System.Drawing.Size(105, 24);
            kryptonLabel6.TabIndex = 6;
            kryptonLabel6.Values.Text = "Mã danh mục";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new System.Drawing.Point(34, 123);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new System.Drawing.Size(104, 24);
            kryptonLabel2.TabIndex = 4;
            kryptonLabel2.Values.Text = "Mã sản phẩm";
            // 
            // kryptonLabel9
            // 
            kryptonLabel9.Location = new System.Drawing.Point(34, 173);
            kryptonLabel9.Name = "kryptonLabel9";
            kryptonLabel9.Size = new System.Drawing.Size(107, 24);
            kryptonLabel9.TabIndex = 5;
            kryptonLabel9.Values.Text = "Tên sản phẩm";
            // 
            // kryptonLabel7
            // 
            kryptonLabel7.Location = new System.Drawing.Point(34, 223);
            kryptonLabel7.Name = "kryptonLabel7";
            kryptonLabel7.Size = new System.Drawing.Size(105, 24);
            kryptonLabel7.TabIndex = 6;
            kryptonLabel7.Values.Text = "Mã danh mục";
            // 
            // kryptonLabel8
            // 
            kryptonLabel8.Location = new System.Drawing.Point(34, 273);
            kryptonLabel8.Name = "kryptonLabel8";
            kryptonLabel8.Size = new System.Drawing.Size(130, 24);
            kryptonLabel8.TabIndex = 7;
            kryptonLabel8.Values.Text = "Số lượng tồn kho";
            // 
            // kryptonLabel10
            // 
            kryptonLabel10.Location = new System.Drawing.Point(34, 323);
            kryptonLabel10.Name = "kryptonLabel10";
            kryptonLabel10.Size = new System.Drawing.Size(103, 24);
            kryptonLabel10.TabIndex = 8;
            kryptonLabel10.Values.Text = "Ngày hết hạn";
            // 
            // kryptonLabel11
            // 
            kryptonLabel11.Location = new System.Drawing.Point(444, 123);
            kryptonLabel11.Name = "kryptonLabel11";
            kryptonLabel11.Size = new System.Drawing.Size(64, 24);
            kryptonLabel11.TabIndex = 9;
            kryptonLabel11.Values.Text = "Giá bán";
            // 
            // kryptonLabel12
            // 
            kryptonLabel12.Location = new System.Drawing.Point(444, 173);
            kryptonLabel12.Name = "kryptonLabel12";
            kryptonLabel12.Size = new System.Drawing.Size(72, 24);
            kryptonLabel12.TabIndex = 10;
            kryptonLabel12.Values.Text = "Giảm giá";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.pictureBox1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(824, 103);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(34, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 77);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btn_close);
            this.kryptonPanel3.Controls.Add(this.btn_save);
            this.kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 346);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(824, 107);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonPanel3.TabIndex = 3;
            // 
            // btn_close
            // 
            this.btn_close.AutoSize = true;
            this.btn_close.Location = new System.Drawing.Point(233, 24);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(139, 50);
            this.btn_close.StateCommon.Back.Color1 = System.Drawing.Color.Red;
            this.btn_close.StateCommon.Back.Color2 = System.Drawing.Color.Red;
            this.btn_close.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_close.StateCommon.Border.Rounding = 19F;
            this.btn_close.StateCommon.Border.Width = 1;
            this.btn_close.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.TabIndex = 2;
            this.btn_close.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_close.Values.Text = "Close";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.AutoSize = true;
            this.btn_save.Location = new System.Drawing.Point(65, 24);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(139, 50);
            this.btn_save.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_save.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_save.StateCommon.Border.Rounding = 19F;
            this.btn_save.StateCommon.Border.Width = 1;
            this.btn_save.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.TabIndex = 2;
            this.btn_save.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btn_save.Values.Text = "Save";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(kryptonLabel6);
            this.panel1.Controls.Add(kryptonLabel5);
            this.panel1.Controls.Add(kryptonLabel4);
            this.panel1.Controls.Add(kryptonLabel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(802, 481);
            this.panel1.TabIndex = 4;
            // 
            // textboxID
            // 
            this.textboxID.Location = new System.Drawing.Point(168, 120);
            this.textboxID.Name = "textboxID";
            this.textboxID.ReadOnly = true;
            this.textboxID.Size = new System.Drawing.Size(241, 27);
            this.textboxID.TabIndex = 11;
            // 
            // textboxName
            // 
            this.textboxName.Location = new System.Drawing.Point(168, 170);
            this.textboxName.Name = "textboxName";
            this.textboxName.Size = new System.Drawing.Size(241, 27);
            this.textboxName.TabIndex = 12;
            // 
            // textboxInventoryAmount
            // 
            this.textboxInventoryAmount.Location = new System.Drawing.Point(168, 270);
            this.textboxInventoryAmount.Name = "textboxInventoryAmount";
            this.textboxInventoryAmount.Size = new System.Drawing.Size(241, 27);
            this.textboxInventoryAmount.TabIndex = 14;
            // 
            // textboxPrice
            // 
            this.textboxPrice.Location = new System.Drawing.Point(524, 120);
            this.textboxPrice.Name = "textboxPrice";
            this.textboxPrice.Size = new System.Drawing.Size(241, 27);
            this.textboxPrice.TabIndex = 16;
            // 
            // textboxSale
            // 
            this.textboxSale.Location = new System.Drawing.Point(524, 170);
            this.textboxSale.Name = "textboxSale";
            this.textboxSale.Size = new System.Drawing.Size(241, 27);
            this.textboxSale.TabIndex = 17;
            // 
            // dtpExpiration
            // 
            this.dtpExpiration.Location = new System.Drawing.Point(168, 322);
            this.dtpExpiration.Name = "dtpExpiration";
            this.dtpExpiration.Size = new System.Drawing.Size(241, 25);
            this.dtpExpiration.TabIndex = 18;
            // 
            // cbCategoryId
            // 
            this.cbCategoryId.DropDownWidth = 241;
            this.cbCategoryId.Location = new System.Drawing.Point(168, 221);
            this.cbCategoryId.Name = "cbCategoryId";
            this.cbCategoryId.Size = new System.Drawing.Size(241, 26);
            this.cbCategoryId.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbCategoryId.TabIndex = 19;
            // 
            // FormSanPhamEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 453);
            this.Controls.Add(this.cbCategoryId);
            this.Controls.Add(this.dtpExpiration);
            this.Controls.Add(this.textboxSale);
            this.Controls.Add(this.textboxPrice);
            this.Controls.Add(this.textboxInventoryAmount);
            this.Controls.Add(this.textboxName);
            this.Controls.Add(this.textboxID);
            this.Controls.Add(kryptonLabel12);
            this.Controls.Add(kryptonLabel11);
            this.Controls.Add(kryptonLabel10);
            this.Controls.Add(kryptonLabel8);
            this.Controls.Add(kryptonLabel7);
            this.Controls.Add(kryptonLabel9);
            this.Controls.Add(kryptonLabel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.kryptonPanel3);
            this.Name = "SanPhamFormEdit";
            this.Text = "FormSanPhamEdit";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbCategoryId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private Krypton.Toolkit.KryptonComboBox cbCategoryId;
        private Krypton.Toolkit.KryptonTextBox textboxID;
        private Krypton.Toolkit.KryptonTextBox textboxName;
        private Krypton.Toolkit.KryptonTextBox textboxInventoryAmount;
        private Krypton.Toolkit.KryptonTextBox textboxPrice;
        private Krypton.Toolkit.KryptonTextBox textboxSale;
        private Krypton.Toolkit.KryptonDateTimePicker dtpExpiration;
        private System.Windows.Forms.Panel panel1;
        public Krypton.Toolkit.KryptonPanel kryptonPanel1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton btn_close;
        private Krypton.Toolkit.KryptonButton btn_save;

        #endregion
    }
}