using System.ComponentModel;

namespace CHTL.GUI.SanPham {
    partial class FormSanPhamAdd {
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
            Krypton.Toolkit.KryptonPanel panelHeader;
            Krypton.Toolkit.KryptonPanel panelBody;
            Krypton.Toolkit.KryptonTableLayoutPanel tableFields;
            Krypton.Toolkit.KryptonPanel kryptonPanel3;
            Krypton.Toolkit.KryptonLabel labelGiamGia;
            Krypton.Toolkit.KryptonPanel kryptonPanel2;
            Krypton.Toolkit.KryptonLabel labelNgayHetHan;
            Krypton.Toolkit.KryptonPanel kryptonPanel1;
            Krypton.Toolkit.KryptonLabel labelSoLuongTon;
            Krypton.Toolkit.KryptonPanel panelCell4;
            Krypton.Toolkit.KryptonLabel labelGia;
            Krypton.Toolkit.KryptonPanel panelCell3;
            Krypton.Toolkit.KryptonLabel labelDanhMuc;
            Krypton.Toolkit.KryptonPanel panelCell2;
            Krypton.Toolkit.KryptonLabel labelName;
            Krypton.Toolkit.KryptonPanel panelCell1;
            Krypton.Toolkit.KryptonLabel labelID;
            this.labelTitle = new Krypton.Toolkit.KryptonLabel();
            this.textboxGiamGia = new Krypton.Toolkit.KryptonTextBox();
            this.dtpNgayHetHan = new Krypton.Toolkit.KryptonDateTimePicker();
            this.textboxSoLuongTon = new Krypton.Toolkit.KryptonTextBox();
            this.textboxGia = new Krypton.Toolkit.KryptonTextBox();
            this.cbDanhMuc = new Krypton.Toolkit.KryptonComboBox();
            this.textboxTen = new Krypton.Toolkit.KryptonTextBox();
            this.textboxID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.saveOrCancelPanel1 = new CHTL.GUI.Controls.SaveOrCancelPanel();
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            panelBody = new Krypton.Toolkit.KryptonPanel();
            tableFields = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            labelGiamGia = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            labelNgayHetHan = new Krypton.Toolkit.KryptonLabel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            labelSoLuongTon = new Krypton.Toolkit.KryptonLabel();
            panelCell4 = new Krypton.Toolkit.KryptonPanel();
            labelGia = new Krypton.Toolkit.KryptonLabel();
            panelCell3 = new Krypton.Toolkit.KryptonPanel();
            labelDanhMuc = new Krypton.Toolkit.KryptonLabel();
            panelCell2 = new Krypton.Toolkit.KryptonPanel();
            labelName = new Krypton.Toolkit.KryptonLabel();
            panelCell1 = new Krypton.Toolkit.KryptonPanel();
            labelID = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(panelHeader)).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelBody)).BeginInit();
            panelBody.SuspendLayout();
            tableFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel3)).BeginInit();
            kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel2)).BeginInit();
            kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel1)).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell4)).BeginInit();
            panelCell4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell3)).BeginInit();
            panelCell3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(panelCell2)).BeginInit();
            panelCell2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell1)).BeginInit();
            panelCell1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(this.labelTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(602, 96);
            panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(12, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(191, 36);
            this.labelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Values.Text = "Thêm sản phẩm";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(tableFields);
            panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBody.Location = new System.Drawing.Point(0, 96);
            panelBody.Name = "panelBody";
            panelBody.Padding = new System.Windows.Forms.Padding(15);
            panelBody.Size = new System.Drawing.Size(602, 401);
            panelBody.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelBody.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelBody.TabIndex = 1;
            // 
            // tableFields
            // 
            tableFields.ColumnCount = 3;
            tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            tableFields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            tableFields.Controls.Add(kryptonPanel3, 2, 1);
            tableFields.Controls.Add(kryptonPanel2, 0, 3);
            tableFields.Controls.Add(kryptonPanel1, 2, 2);
            tableFields.Controls.Add(panelCell4, 2, 0);
            tableFields.Controls.Add(panelCell3, 0, 2);
            tableFields.Controls.Add(panelCell2, 0, 1);
            tableFields.Controls.Add(panelCell1, 0, 0);
            tableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            tableFields.Location = new System.Drawing.Point(15, 15);
            tableFields.Name = "tableFields";
            tableFields.RowCount = 4;
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.Size = new System.Drawing.Size(572, 371);
            tableFields.StateCommon.Color1 = System.Drawing.Color.Transparent;
            tableFields.StateCommon.Color2 = System.Drawing.Color.Transparent;
            tableFields.TabIndex = 1;
            // 
            // kryptonPanel3
            // 
            kryptonPanel3.Controls.Add(this.textboxGiamGia);
            kryptonPanel3.Controls.Add(labelGiamGia);
            kryptonPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel3.Location = new System.Drawing.Point(299, 75);
            kryptonPanel3.Name = "kryptonPanel3";
            kryptonPanel3.Size = new System.Drawing.Size(270, 66);
            kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel3.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel3.TabIndex = 6;
            // 
            // textboxGiamGia
            // 
            this.textboxGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxGiamGia.Location = new System.Drawing.Point(0, 24);
            this.textboxGiamGia.Name = "textboxGiamGia";
            this.textboxGiamGia.Size = new System.Drawing.Size(270, 33);
            this.textboxGiamGia.StateCommon.Border.Rounding = 8F;
            this.textboxGiamGia.TabIndex = 1;
            // 
            // labelGiamGia
            // 
            labelGiamGia.Dock = System.Windows.Forms.DockStyle.Top;
            labelGiamGia.Location = new System.Drawing.Point(0, 0);
            labelGiamGia.Name = "labelGiamGia";
            labelGiamGia.Size = new System.Drawing.Size(270, 24);
            labelGiamGia.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelGiamGia.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelGiamGia.TabIndex = 0;
            labelGiamGia.Values.Text = "Giảm giá";
            // 
            // kryptonPanel2
            // 
            kryptonPanel2.Controls.Add(this.dtpNgayHetHan);
            kryptonPanel2.Controls.Add(labelNgayHetHan);
            kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel2.Location = new System.Drawing.Point(3, 219);
            kryptonPanel2.Name = "kryptonPanel2";
            kryptonPanel2.Size = new System.Drawing.Size(270, 156);
            kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel2.TabIndex = 5;
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(0, 24);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(270, 31);
            this.dtpNgayHetHan.StateCommon.Border.Rounding = 8F;
            this.dtpNgayHetHan.TabIndex = 1;
            // 
            // labelNgayHetHan
            // 
            labelNgayHetHan.Dock = System.Windows.Forms.DockStyle.Top;
            labelNgayHetHan.Location = new System.Drawing.Point(0, 0);
            labelNgayHetHan.Name = "labelNgayHetHan";
            labelNgayHetHan.Size = new System.Drawing.Size(270, 24);
            labelNgayHetHan.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelNgayHetHan.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelNgayHetHan.TabIndex = 0;
            labelNgayHetHan.Values.Text = "Ngày hết hạn";
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(this.textboxSoLuongTon);
            kryptonPanel1.Controls.Add(labelSoLuongTon);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(299, 147);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(270, 66);
            kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel1.TabIndex = 4;
            // 
            // textboxSoLuongTon
            // 
            this.textboxSoLuongTon.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxSoLuongTon.Location = new System.Drawing.Point(0, 24);
            this.textboxSoLuongTon.Name = "textboxSoLuongTon";
            this.textboxSoLuongTon.Size = new System.Drawing.Size(270, 33);
            this.textboxSoLuongTon.StateCommon.Border.Rounding = 8F;
            this.textboxSoLuongTon.TabIndex = 1;
            // 
            // labelSoLuongTon
            // 
            labelSoLuongTon.Dock = System.Windows.Forms.DockStyle.Top;
            labelSoLuongTon.Location = new System.Drawing.Point(0, 0);
            labelSoLuongTon.Name = "labelSoLuongTon";
            labelSoLuongTon.Size = new System.Drawing.Size(270, 24);
            labelSoLuongTon.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelSoLuongTon.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelSoLuongTon.TabIndex = 0;
            labelSoLuongTon.Values.Text = "Số lượng tồn";
            // 
            // panelCell4
            // 
            panelCell4.Controls.Add(this.textboxGia);
            panelCell4.Controls.Add(labelGia);
            panelCell4.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell4.Location = new System.Drawing.Point(299, 3);
            panelCell4.Name = "panelCell4";
            panelCell4.Size = new System.Drawing.Size(270, 66);
            panelCell4.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell4.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell4.TabIndex = 3;
            // 
            // textboxGia
            // 
            this.textboxGia.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxGia.Location = new System.Drawing.Point(0, 24);
            this.textboxGia.Name = "textboxGia";
            this.textboxGia.Size = new System.Drawing.Size(270, 33);
            this.textboxGia.StateCommon.Border.Rounding = 8F;
            this.textboxGia.TabIndex = 1;
            // 
            // labelGia
            // 
            labelGia.Dock = System.Windows.Forms.DockStyle.Top;
            labelGia.Location = new System.Drawing.Point(0, 0);
            labelGia.Name = "labelGia";
            labelGia.Size = new System.Drawing.Size(270, 24);
            labelGia.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelGia.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelGia.TabIndex = 0;
            labelGia.Values.Text = "Giá";
            // 
            // panelCell3
            // 
            panelCell3.Controls.Add(this.cbDanhMuc);
            panelCell3.Controls.Add(labelDanhMuc);
            panelCell3.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell3.Location = new System.Drawing.Point(3, 147);
            panelCell3.Name = "panelCell3";
            panelCell3.Size = new System.Drawing.Size(270, 66);
            panelCell3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell3.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell3.TabIndex = 2;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDanhMuc.DropDownWidth = 255;
            this.cbDanhMuc.Location = new System.Drawing.Point(0, 24);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(270, 32);
            this.cbDanhMuc.StateCommon.ComboBox.Border.Rounding = 8F;
            this.cbDanhMuc.TabIndex = 1;
            // 
            // labelDanhMuc
            // 
            labelDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            labelDanhMuc.Location = new System.Drawing.Point(0, 0);
            labelDanhMuc.Name = "labelDanhMuc";
            labelDanhMuc.Size = new System.Drawing.Size(270, 24);
            labelDanhMuc.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelDanhMuc.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelDanhMuc.TabIndex = 0;
            labelDanhMuc.Values.Text = "Danh mục";
            // 
            // panelCell2
            // 
            panelCell2.Controls.Add(this.textboxTen);
            panelCell2.Controls.Add(labelName);
            panelCell2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell2.Location = new System.Drawing.Point(3, 75);
            panelCell2.Name = "panelCell2";
            panelCell2.Size = new System.Drawing.Size(270, 66);
            panelCell2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell2.TabIndex = 1;
            // 
            // textboxTen
            // 
            this.textboxTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxTen.Location = new System.Drawing.Point(0, 24);
            this.textboxTen.Name = "textboxTen";
            this.textboxTen.Size = new System.Drawing.Size(270, 33);
            this.textboxTen.StateCommon.Border.Rounding = 8F;
            this.textboxTen.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = System.Windows.Forms.DockStyle.Top;
            labelName.Location = new System.Drawing.Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(270, 24);
            labelName.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelName.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelName.TabIndex = 0;
            labelName.Values.Text = "Tên";
            // 
            // panelCell1
            // 
            panelCell1.Controls.Add(this.textboxID);
            panelCell1.Controls.Add(labelID);
            panelCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell1.Location = new System.Drawing.Point(3, 3);
            panelCell1.Name = "panelCell1";
            panelCell1.Size = new System.Drawing.Size(270, 66);
            panelCell1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell1.TabIndex = 0;
            // 
            // textboxID
            // 
            this.textboxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxID.Location = new System.Drawing.Point(0, 24);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(270, 33);
            this.textboxID.StateCommon.Border.Rounding = 8F;
            this.textboxID.TabIndex = 1;
            // 
            // labelID
            // 
            labelID.Dock = System.Windows.Forms.DockStyle.Top;
            labelID.Location = new System.Drawing.Point(0, 0);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(270, 24);
            labelID.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelID.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelID.TabIndex = 0;
            labelID.Values.Text = "Mã";
            // 
            // kryptonTableLayoutPanel3
            // 
            this.kryptonTableLayoutPanel3.ColumnCount = 1;
            this.kryptonTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.kryptonTableLayoutPanel3.Name = "kryptonTableLayoutPanel3";
            this.kryptonTableLayoutPanel3.RowCount = 3;
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.kryptonTableLayoutPanel3.TabIndex = 0;
            // 
            // saveOrCancelPanel1
            // 
            this.saveOrCancelPanel1.BackColor = System.Drawing.Color.Transparent;
            this.saveOrCancelPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveOrCancelPanel1.Location = new System.Drawing.Point(0, 406);
            this.saveOrCancelPanel1.Name = "saveOrCancelPanel1";
            this.saveOrCancelPanel1.Size = new System.Drawing.Size(602, 91);
            this.saveOrCancelPanel1.TabIndex = 3;
            this.saveOrCancelPanel1.SaveButtonClick += new System.EventHandler(this.btnSave_Click);
            this.saveOrCancelPanel1.CancelButtonClick += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSanPhamAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(602, 497);
            this.Controls.Add(this.saveOrCancelPanel1);
            this.Controls.Add(panelBody);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(600, 520);
            this.Name = "FormSanPhamAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(panelHeader)).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelBody)).EndInit();
            panelBody.ResumeLayout(false);
            tableFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel3)).EndInit();
            kryptonPanel3.ResumeLayout(false);
            kryptonPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel2)).EndInit();
            kryptonPanel2.ResumeLayout(false);
            kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel1)).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell4)).EndInit();
            panelCell4.ResumeLayout(false);
            panelCell4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell3)).EndInit();
            panelCell3.ResumeLayout(false);
            panelCell3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(panelCell2)).EndInit();
            panelCell2.ResumeLayout(false);
            panelCell2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell1)).EndInit();
            panelCell1.ResumeLayout(false);
            panelCell1.PerformLayout();
            this.ResumeLayout(false);

        }
        private Krypton.Toolkit.KryptonTextBox textboxGiamGia;
        private Krypton.Toolkit.KryptonDateTimePicker dtpNgayHetHan;
        private Krypton.Toolkit.KryptonComboBox cbDanhMuc;
        private Krypton.Toolkit.KryptonTextBox textboxGia;
        private Krypton.Toolkit.KryptonLabel labelTitle;
        private Krypton.Toolkit.KryptonTextBox textboxSoLuongTon;
        private Krypton.Toolkit.KryptonTextBox textboxTen;
        private Krypton.Toolkit.KryptonTextBox textboxID;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;

        #endregion

        private Controls.SaveOrCancelPanel saveOrCancelPanel1;
    }
}