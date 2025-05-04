using System.ComponentModel;

namespace CHTL.GUI.NguoiDung {
    partial class FormNguoiDungAdd {
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
            Krypton.Toolkit.KryptonPanel kryptonPanel1;
            Krypton.Toolkit.KryptonLabel labelPassword;
            Krypton.Toolkit.KryptonPanel panelCell4;
            Krypton.Toolkit.KryptonLabel labelUsername;
            Krypton.Toolkit.KryptonPanel panelCell3;
            Krypton.Toolkit.KryptonLabel labelRole;
            Krypton.Toolkit.KryptonPanel panelCell2;
            Krypton.Toolkit.KryptonLabel labelName;
            Krypton.Toolkit.KryptonPanel panelCell1;
            Krypton.Toolkit.KryptonLabel labelID;
            this.labelTitle = new Krypton.Toolkit.KryptonLabel();
            this.textboxMatKhau = new Krypton.Toolkit.KryptonTextBox();
            this.textboxTenDangNhap = new Krypton.Toolkit.KryptonTextBox();
            this.cbVaiTro = new Krypton.Toolkit.KryptonComboBox();
            this.textboxTen = new Krypton.Toolkit.KryptonTextBox();
            this.textboxID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.saveOrCancelPanel1 = new CHTL.GUI.Controls.SaveOrCancelPanel();
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            panelBody = new Krypton.Toolkit.KryptonPanel();
            tableFields = new Krypton.Toolkit.KryptonTableLayoutPanel();
            kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            labelPassword = new Krypton.Toolkit.KryptonLabel();
            panelCell4 = new Krypton.Toolkit.KryptonPanel();
            labelUsername = new Krypton.Toolkit.KryptonLabel();
            panelCell3 = new Krypton.Toolkit.KryptonPanel();
            labelRole = new Krypton.Toolkit.KryptonLabel();
            panelCell2 = new Krypton.Toolkit.KryptonPanel();
            labelName = new Krypton.Toolkit.KryptonLabel();
            panelCell1 = new Krypton.Toolkit.KryptonPanel();
            labelID = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(panelHeader)).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelBody)).BeginInit();
            panelBody.SuspendLayout();
            tableFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel1)).BeginInit();
            kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell4)).BeginInit();
            panelCell4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell3)).BeginInit();
            panelCell3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbVaiTro)).BeginInit();
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
            panelHeader.Size = new System.Drawing.Size(588, 96);
            panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(12, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(325, 36);
            this.labelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Values.Text = "Thêm thông tin người dùng";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(tableFields);
            panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBody.Location = new System.Drawing.Point(0, 96);
            panelBody.Name = "panelBody";
            panelBody.Padding = new System.Windows.Forms.Padding(15);
            panelBody.Size = new System.Drawing.Size(588, 354);
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
            tableFields.Controls.Add(kryptonPanel1, 2, 1);
            tableFields.Controls.Add(panelCell4, 2, 0);
            tableFields.Controls.Add(panelCell3, 0, 2);
            tableFields.Controls.Add(panelCell2, 0, 1);
            tableFields.Controls.Add(panelCell1, 0, 0);
            tableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            tableFields.Location = new System.Drawing.Point(15, 15);
            tableFields.Name = "tableFields";
            tableFields.RowCount = 3;
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableFields.Size = new System.Drawing.Size(558, 324);
            tableFields.StateCommon.Color1 = System.Drawing.Color.Transparent;
            tableFields.StateCommon.Color2 = System.Drawing.Color.Transparent;
            tableFields.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(this.textboxMatKhau);
            kryptonPanel1.Controls.Add(labelPassword);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(292, 75);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(263, 66);
            kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel1.TabIndex = 4;
            // 
            // textboxMatKhau
            // 
            this.textboxMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxMatKhau.Location = new System.Drawing.Point(0, 24);
            this.textboxMatKhau.Name = "textboxMatKhau";
            this.textboxMatKhau.Size = new System.Drawing.Size(263, 33);
            this.textboxMatKhau.StateCommon.Border.Rounding = 8F;
            this.textboxMatKhau.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            labelPassword.Location = new System.Drawing.Point(0, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(263, 24);
            labelPassword.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelPassword.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelPassword.TabIndex = 0;
            labelPassword.Values.Text = "Mật khẩu";
            // 
            // panelCell4
            // 
            panelCell4.Controls.Add(this.textboxTenDangNhap);
            panelCell4.Controls.Add(labelUsername);
            panelCell4.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell4.Location = new System.Drawing.Point(292, 3);
            panelCell4.Name = "panelCell4";
            panelCell4.Size = new System.Drawing.Size(263, 66);
            panelCell4.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell4.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell4.TabIndex = 3;
            // 
            // textboxTenDangNhap
            // 
            this.textboxTenDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxTenDangNhap.Location = new System.Drawing.Point(0, 24);
            this.textboxTenDangNhap.Name = "textboxTenDangNhap";
            this.textboxTenDangNhap.Size = new System.Drawing.Size(263, 33);
            this.textboxTenDangNhap.StateCommon.Border.Rounding = 8F;
            this.textboxTenDangNhap.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            labelUsername.Location = new System.Drawing.Point(0, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(263, 24);
            labelUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelUsername.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelUsername.TabIndex = 0;
            labelUsername.Values.Text = "Tên đăng nhập";
            // 
            // panelCell3
            // 
            panelCell3.Controls.Add(this.cbVaiTro);
            panelCell3.Controls.Add(labelRole);
            panelCell3.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell3.Location = new System.Drawing.Point(3, 147);
            panelCell3.Name = "panelCell3";
            panelCell3.Size = new System.Drawing.Size(263, 188);
            panelCell3.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell3.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell3.TabIndex = 2;
            // 
            // cbVaiTro
            // 
            this.cbVaiTro.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVaiTro.DropDownWidth = 255;
            this.cbVaiTro.Location = new System.Drawing.Point(0, 24);
            this.cbVaiTro.Name = "cbVaiTro";
            this.cbVaiTro.Size = new System.Drawing.Size(263, 32);
            this.cbVaiTro.StateCommon.ComboBox.Border.Rounding = 8F;
            this.cbVaiTro.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbVaiTro.TabIndex = 1;
            // 
            // labelRole
            // 
            labelRole.Dock = System.Windows.Forms.DockStyle.Top;
            labelRole.Location = new System.Drawing.Point(0, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new System.Drawing.Size(263, 24);
            labelRole.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelRole.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelRole.TabIndex = 0;
            labelRole.Values.Text = "Vai trò";
            // 
            // panelCell2
            // 
            panelCell2.Controls.Add(this.textboxTen);
            panelCell2.Controls.Add(labelName);
            panelCell2.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell2.Location = new System.Drawing.Point(3, 75);
            panelCell2.Name = "panelCell2";
            panelCell2.Size = new System.Drawing.Size(263, 66);
            panelCell2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell2.TabIndex = 1;
            // 
            // textboxTen
            // 
            this.textboxTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxTen.Location = new System.Drawing.Point(0, 24);
            this.textboxTen.Name = "textboxTen";
            this.textboxTen.Size = new System.Drawing.Size(263, 33);
            this.textboxTen.StateCommon.Border.Rounding = 8F;
            this.textboxTen.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = System.Windows.Forms.DockStyle.Top;
            labelName.Location = new System.Drawing.Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(263, 24);
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
            panelCell1.Size = new System.Drawing.Size(263, 66);
            panelCell1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell1.TabIndex = 0;
            // 
            // textboxID
            // 
            this.textboxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxID.Location = new System.Drawing.Point(0, 24);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(263, 33);
            this.textboxID.StateCommon.Border.Rounding = 8F;
            this.textboxID.TabIndex = 1;
            // 
            // labelID
            // 
            labelID.Dock = System.Windows.Forms.DockStyle.Top;
            labelID.Location = new System.Drawing.Point(0, 0);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(263, 24);
            labelID.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelID.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelID.TabIndex = 0;
            labelID.Values.Text = "Mã người dùng";
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
            this.saveOrCancelPanel1.Location = new System.Drawing.Point(0, 359);
            this.saveOrCancelPanel1.Name = "saveOrCancelPanel1";
            this.saveOrCancelPanel1.Size = new System.Drawing.Size(588, 91);
            this.saveOrCancelPanel1.TabIndex = 2;
            this.saveOrCancelPanel1.SaveButtonClick += new System.EventHandler(this.btnSave_Click);
            this.saveOrCancelPanel1.CancelButtonClick += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormNguoiDungAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.saveOrCancelPanel1);
            this.Controls.Add(panelBody);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "FormNguoiDungAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm thông tin người dùng";
            ((System.ComponentModel.ISupportInitialize)(panelHeader)).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelBody)).EndInit();
            panelBody.ResumeLayout(false);
            tableFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(kryptonPanel1)).EndInit();
            kryptonPanel1.ResumeLayout(false);
            kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell4)).EndInit();
            panelCell4.ResumeLayout(false);
            panelCell4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell3)).EndInit();
            panelCell3.ResumeLayout(false);
            panelCell3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbVaiTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(panelCell2)).EndInit();
            panelCell2.ResumeLayout(false);
            panelCell2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell1)).EndInit();
            panelCell1.ResumeLayout(false);
            panelCell1.PerformLayout();
            this.ResumeLayout(false);

        }
        private Krypton.Toolkit.KryptonComboBox cbVaiTro;
        private Krypton.Toolkit.KryptonTextBox textboxTenDangNhap;
        private Krypton.Toolkit.KryptonLabel labelTitle;
        private Krypton.Toolkit.KryptonTextBox textboxMatKhau;
        private Krypton.Toolkit.KryptonTextBox textboxTen;
        private Krypton.Toolkit.KryptonTextBox textboxID;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;

        #endregion

        private Controls.SaveOrCancelPanel saveOrCancelPanel1;
    }
}