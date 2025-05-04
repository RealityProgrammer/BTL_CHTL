using System.ComponentModel;

namespace CHTL.GUI.DanhMuc {
    partial class FormDanhMucAdd {
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
            Krypton.Toolkit.KryptonPanel panelCell4;
            Krypton.Toolkit.KryptonLabel labelUsername;
            Krypton.Toolkit.KryptonPanel panelCell1;
            Krypton.Toolkit.KryptonLabel labelID;
            CHTL.GUI.Controls.SaveOrCancelPanel panelFooter;
            this.labelTitle = new Krypton.Toolkit.KryptonLabel();
            this.textboxTen = new Krypton.Toolkit.KryptonTextBox();
            this.textboxID = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonTableLayoutPanel3 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            panelHeader = new Krypton.Toolkit.KryptonPanel();
            panelBody = new Krypton.Toolkit.KryptonPanel();
            tableFields = new Krypton.Toolkit.KryptonTableLayoutPanel();
            panelCell4 = new Krypton.Toolkit.KryptonPanel();
            labelUsername = new Krypton.Toolkit.KryptonLabel();
            panelCell1 = new Krypton.Toolkit.KryptonPanel();
            labelID = new Krypton.Toolkit.KryptonLabel();
            panelFooter = new CHTL.GUI.Controls.SaveOrCancelPanel();
            ((System.ComponentModel.ISupportInitialize)(panelHeader)).BeginInit();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelBody)).BeginInit();
            panelBody.SuspendLayout();
            tableFields.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell4)).BeginInit();
            panelCell4.SuspendLayout();
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
            panelHeader.Size = new System.Drawing.Size(586, 96);
            panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            panelHeader.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            panelHeader.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(12, 28);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(193, 36);
            this.labelTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.labelTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Values.Text = "Thêm danh mục";
            // 
            // panelBody
            // 
            panelBody.Controls.Add(tableFields);
            panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            panelBody.Location = new System.Drawing.Point(0, 96);
            panelBody.Name = "panelBody";
            panelBody.Padding = new System.Windows.Forms.Padding(15);
            panelBody.Size = new System.Drawing.Size(586, 361);
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
            tableFields.Controls.Add(panelCell4, 2, 0);
            tableFields.Controls.Add(panelCell1, 0, 0);
            tableFields.Dock = System.Windows.Forms.DockStyle.Fill;
            tableFields.Location = new System.Drawing.Point(15, 15);
            tableFields.Name = "tableFields";
            tableFields.RowCount = 1;
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            tableFields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 331F));
            tableFields.Size = new System.Drawing.Size(556, 331);
            tableFields.StateCommon.Color1 = System.Drawing.Color.Transparent;
            tableFields.StateCommon.Color2 = System.Drawing.Color.Transparent;
            tableFields.TabIndex = 1;
            // 
            // panelCell4
            // 
            panelCell4.Controls.Add(this.textboxTen);
            panelCell4.Controls.Add(labelUsername);
            panelCell4.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell4.Location = new System.Drawing.Point(291, 3);
            panelCell4.Name = "panelCell4";
            panelCell4.Size = new System.Drawing.Size(262, 325);
            panelCell4.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell4.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell4.TabIndex = 3;
            // 
            // textboxTen
            // 
            this.textboxTen.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxTen.Location = new System.Drawing.Point(0, 24);
            this.textboxTen.Name = "textboxTen";
            this.textboxTen.Size = new System.Drawing.Size(262, 33);
            this.textboxTen.StateCommon.Border.Rounding = 8F;
            this.textboxTen.TabIndex = 1;
            // 
            // labelUsername
            // 
            labelUsername.Dock = System.Windows.Forms.DockStyle.Top;
            labelUsername.Location = new System.Drawing.Point(0, 0);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new System.Drawing.Size(262, 24);
            labelUsername.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            labelUsername.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            labelUsername.TabIndex = 0;
            labelUsername.Values.Text = "Tên";
            // 
            // panelCell1
            // 
            panelCell1.Controls.Add(this.textboxID);
            panelCell1.Controls.Add(labelID);
            panelCell1.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCell1.Location = new System.Drawing.Point(3, 3);
            panelCell1.Name = "panelCell1";
            panelCell1.Size = new System.Drawing.Size(262, 325);
            panelCell1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            panelCell1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            panelCell1.TabIndex = 0;
            // 
            // textboxID
            // 
            this.textboxID.Dock = System.Windows.Forms.DockStyle.Top;
            this.textboxID.Location = new System.Drawing.Point(0, 24);
            this.textboxID.Name = "textboxID";
            this.textboxID.Size = new System.Drawing.Size(262, 33);
            this.textboxID.StateCommon.Border.Rounding = 8F;
            this.textboxID.TabIndex = 1;
            // 
            // labelID
            // 
            labelID.Dock = System.Windows.Forms.DockStyle.Top;
            labelID.Location = new System.Drawing.Point(0, 0);
            labelID.Name = "labelID";
            labelID.Size = new System.Drawing.Size(262, 24);
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
            // panelFooter
            // 
            panelFooter.BackColor = System.Drawing.Color.Transparent;
            panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelFooter.Location = new System.Drawing.Point(0, 365);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new System.Drawing.Size(586, 92);
            panelFooter.TabIndex = 2;
            panelFooter.SaveButtonClick += new System.EventHandler(this.btnSave_Click);
            panelFooter.CancelButtonClick += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormDanhMucAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(584, 464);
            this.Controls.Add(panelFooter);
            this.Controls.Add(panelBody);
            this.Controls.Add(panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(600, 480);
            this.Name = "FormDanhMucAdd";
            this.Text = "Thêm danh mục";
            ((System.ComponentModel.ISupportInitialize)(panelHeader)).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelBody)).EndInit();
            panelBody.ResumeLayout(false);
            tableFields.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(panelCell4)).EndInit();
            panelCell4.ResumeLayout(false);
            panelCell4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(panelCell1)).EndInit();
            panelCell1.ResumeLayout(false);
            panelCell1.PerformLayout();
            this.ResumeLayout(false);

        }
        private Krypton.Toolkit.KryptonTextBox textboxTen;
        private Krypton.Toolkit.KryptonLabel labelTitle;
        private Krypton.Toolkit.KryptonTextBox textboxID;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel3;

        #endregion
    }
}