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
            Krypton.Toolkit.KryptonTableLayoutPanel panelFooter;
            this.labelTitle = new Krypton.Toolkit.KryptonLabel();
            this.textboxMatKhau = new Krypton.Toolkit.KryptonTextBox();
            this.textboxTenDangNhap = new Krypton.Toolkit.KryptonTextBox();
            this.cbVaiTro = new Krypton.Toolkit.KryptonComboBox();
            this.textboxTen = new Krypton.Toolkit.KryptonTextBox();
            this.textboxID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.btnSave = new Krypton.Toolkit.KryptonButton();
            this.kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.btnExit = new Krypton.Toolkit.KryptonButton();
            this.kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
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
            panelFooter = new Krypton.Toolkit.KryptonTableLayoutPanel();
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
            panelFooter.SuspendLayout();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            this.kryptonTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(this.labelTitle);
            panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            panelHeader.Location = new System.Drawing.Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new System.Drawing.Size(584, 96);
            panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            panelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(12, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(345, 36);
            this.labelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            panelBody.Size = new System.Drawing.Size(584, 274);
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
            tableFields.Size = new System.Drawing.Size(554, 244);
            tableFields.StateCommon.Color1 = System.Drawing.Color.Transparent;
            tableFields.StateCommon.Color2 = System.Drawing.Color.Transparent;
            tableFields.TabIndex = 1;
            // 
            // kryptonPanel1
            // 
            kryptonPanel1.Controls.Add(this.textboxMatKhau);
            kryptonPanel1.Controls.Add(labelPassword);
            kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            kryptonPanel1.Location = new System.Drawing.Point(290, 75);
            kryptonPanel1.Name = "kryptonPanel1";
            kryptonPanel1.Size = new System.Drawing.Size(261, 66);
            kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            kryptonPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            kryptonPanel1.TabIndex = 4;
            // 
            // textboxMatKhau
            // 
            this.textboxMatKhau.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxMatKhau.Location = new System.Drawing.Point(0, 24);
            this.textboxMatKhau.Name = "textboxMatKhau";
            this.textboxMatKhau.Size = new System.Drawing.Size(261, 33);
            this.textboxMatKhau.StateCommon.Border.Rounding = 8F;
            this.textboxMatKhau.TabIndex = 1;
            // 
            // labelPassword
            // 
            labelPassword.Dock = System.Windows.Forms.DockStyle.Top;
            labelPassword.Location = new System.Drawing.Point(0, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new System.Drawing.Size(261, 24);
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
            panelCell4.Location = new System.Drawing.Point(290, 3);
            panelCell4.Name = "panelCell4";
            panelCell4.Size = new System.Drawing.Size(261, 66);
            panelCell4.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell4.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell4.TabIndex = 3;
            // 
            // textboxTenDangNhap
            // 
            this.textboxTenDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxTenDangNhap.Location = new System.Drawing.Point(0, 24);
            this.textboxTenDangNhap.Name = "textboxTenDangNhap";
            this.textboxTenDangNhap.Size = new System.Drawing.Size(261, 33);
            this.textboxTenDangNhap.StateCommon.Border.Rounding = 8F;
            this.textboxTenDangNhap.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            labelUsername.Location = new System.Drawing.Point(0, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(261, 24);
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
            panelCell3.Size = new System.Drawing.Size(261, 94);
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
            this.cbVaiTro.Size = new System.Drawing.Size(261, 32);
            this.cbVaiTro.StateCommon.ComboBox.Border.Rounding = 8F;
            this.cbVaiTro.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbVaiTro.TabIndex = 1;
            // 
            // labelRole
            // 
            labelRole.Dock = System.Windows.Forms.DockStyle.Top;
            labelRole.Location = new System.Drawing.Point(0, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new System.Drawing.Size(261, 24);
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
            panelCell2.Size = new System.Drawing.Size(261, 66);
            panelCell2.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell2.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell2.TabIndex = 1;
            // 
            // textboxTen
            // 
            this.textboxTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxTen.Location = new System.Drawing.Point(0, 24);
            this.textboxTen.Name = "textboxTen";
            this.textboxTen.Size = new System.Drawing.Size(261, 33);
            this.textboxTen.StateCommon.Border.Rounding = 8F;
            this.textboxTen.TabIndex = 1;
            // 
            // labelName
            // 
            labelName.Dock = System.Windows.Forms.DockStyle.Top;
            labelName.Location = new System.Drawing.Point(0, 0);
            labelName.Name = "labelName";
            labelName.Size = new System.Drawing.Size(261, 24);
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
            panelCell1.Size = new System.Drawing.Size(261, 66);
            panelCell1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell1.TabIndex = 0;
            // 
            // textboxID
            // 
            this.textboxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxID.Location = new System.Drawing.Point(0, 24);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(261, 33);
            this.textboxID.StateCommon.Border.Rounding = 8F;
            this.textboxID.TabIndex = 1;
            // 
            // labelID
            // 
            labelID.Dock = System.Windows.Forms.DockStyle.Top;
            labelID.Location = new System.Drawing.Point(0, 0);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(261, 24);
            labelID.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelID.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelID.TabIndex = 0;
            labelID.Values.Text = "Mã người dùng";
            // 
            // panelFooter
            // 
            panelFooter.ColumnCount = 3;
            panelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            panelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            panelFooter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            panelFooter.Controls.Add(this.kryptonTableLayoutPanel1, 0, 0);
            panelFooter.Controls.Add(this.kryptonTableLayoutPanel2, 2, 0);
            panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelFooter.Location = new System.Drawing.Point(0, 370);
            panelFooter.Name = "panelFooter";
            panelFooter.RowCount = 1;
            panelFooter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            panelFooter.Size = new System.Drawing.Size(584, 94);
            panelFooter.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            panelFooter.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            panelFooter.TabIndex = 0;
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.ColumnCount = 1;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.btnSave, 0, 1);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 3;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(227, 88);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonTableLayoutPanel1.TabIndex = 4;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(44, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.Size = new System.Drawing.Size(180, 42);
            this.btnSave.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.StateCommon.Border.Rounding = 16F;
            this.btnSave.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.StateTracking.Back.Color1 = System.Drawing.Color.Lime;
            this.btnSave.StateTracking.Back.Color2 = System.Drawing.Color.Lime;
            this.btnSave.TabIndex = 2;
            this.btnSave.TabStop = false;
            this.btnSave.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnSave.Values.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kryptonTableLayoutPanel2
            // 
            this.kryptonTableLayoutPanel2.ColumnCount = 1;
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel2.Controls.Add(this.btnExit, 0, 1);
            this.kryptonTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel2.Location = new System.Drawing.Point(352, 3);
            this.kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            this.kryptonTableLayoutPanel2.RowCount = 3;
            this.kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.kryptonTableLayoutPanel2.Size = new System.Drawing.Size(229, 88);
            this.kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonTableLayoutPanel2.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonTableLayoutPanel2.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExit.Location = new System.Drawing.Point(3, 23);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(180, 42);
            this.btnExit.StateCommon.Border.Rounding = 16F;
            this.btnExit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExit.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.StateTracking.Back.Color1 = System.Drawing.Color.Red;
            this.btnExit.StateTracking.Back.Color2 = System.Drawing.Color.Red;
            this.btnExit.TabIndex = 1;
            this.btnExit.TabStop = false;
            this.btnExit.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnExit.Values.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // FormNguoiDungAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 464);
            this.Controls.Add(panelBody);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "FormNguoiDungAdd";
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
            panelFooter.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        private Krypton.Toolkit.KryptonComboBox cbVaiTro;
        private Krypton.Toolkit.KryptonTextBox textboxTenDangNhap;
        private Krypton.Toolkit.KryptonLabel labelTitle;
        private Krypton.Toolkit.KryptonTextBox textboxMatKhau;
        private Krypton.Toolkit.KryptonTextBox textboxTen;
        private Krypton.Toolkit.KryptonLabel labelID;
        private Krypton.Toolkit.KryptonTextBox textboxID;
        private Krypton.Toolkit.KryptonButton btnSave;
        private Krypton.Toolkit.KryptonButton btnExit;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;

        #endregion
    }
}