namespace CHTL.GUI.DanhMuc
{
    partial class FormDanhMucAdd
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
        private void InitializeComponent() {
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.txt_ma_danh_muc = new Krypton.Toolkit.KryptonTextBox();
            this.txt_ten_danh_muc = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).BeginInit();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            this.panelFooter.Location = new System.Drawing.Point(0, 333);
            this.panelFooter.Size = new System.Drawing.Size(725, 107);
            this.panelFooter.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // panelHeader
            // 
            this.panelHeader.Size = new System.Drawing.Size(725, 103);
            this.panelHeader.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.txt_ten_danh_muc);
            this.panelBody.Controls.Add(this.txt_ma_danh_muc);
            this.panelBody.Controls.Add(this.kryptonLabel3);
            this.panelBody.Controls.Add(this.kryptonLabel2);
            this.panelBody.Size = new System.Drawing.Size(725, 337);
            this.panelBody.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Size = new System.Drawing.Size(219, 42);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = "Thêm danh mục";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(65, 41);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(105, 24);
            this.kryptonLabel2.TabIndex = 0;
            this.kryptonLabel2.Values.Text = "Mã danh mục";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(65, 130);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(109, 24);
            this.kryptonLabel3.TabIndex = 1;
            this.kryptonLabel3.Values.Text = "Tên danh mục";
            // 
            // txt_ma_danh_muc
            // 
            this.txt_ma_danh_muc.Location = new System.Drawing.Point(233, 41);
            this.txt_ma_danh_muc.Name = "txt_ma_danh_muc";
            this.txt_ma_danh_muc.Size = new System.Drawing.Size(192, 27);
            this.txt_ma_danh_muc.TabIndex = 2;
            // 
            // txt_ten_danh_muc
            // 
            this.txt_ten_danh_muc.Location = new System.Drawing.Point(233, 130);
            this.txt_ten_danh_muc.Name = "txt_ten_danh_muc";
            this.txt_ten_danh_muc.Size = new System.Drawing.Size(192, 27);
            this.txt_ten_danh_muc.TabIndex = 3;
            // 
            // FormDanhMucAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 440);
            this.Name = "FormDanhMucAdd";
            this.Text = "FormDanhMucAdd";
            ((System.ComponentModel.ISupportInitialize)(this.panelFooter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeader)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBody)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        public Krypton.Toolkit.KryptonPanel panelHeader;
        protected Krypton.Toolkit.KryptonPanel panelBody;
        protected Krypton.Toolkit.KryptonPanel panelFooter;

        #endregion

        private Krypton.Toolkit.KryptonTextBox txt_ten_danh_muc;
        private Krypton.Toolkit.KryptonTextBox txt_ma_danh_muc;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
    }
}