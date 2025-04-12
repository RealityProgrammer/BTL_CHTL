namespace CHTL.GUI.DanhMuc
{
    partial class FormDanhMucEdit
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
            this.lbl_ma_danh_muc = new Krypton.Toolkit.KryptonLabel();
            this.lbl_ten_danh_muc = new Krypton.Toolkit.KryptonLabel();
            this.txt_ma_danh_muc = new Krypton.Toolkit.KryptonTextBox();
            this.txt_ten_danh_muc = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Size = new System.Drawing.Size(502, 103);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.txt_ten_danh_muc);
            this.kryptonPanel2.Controls.Add(this.txt_ma_danh_muc);
            this.kryptonPanel2.Controls.Add(this.lbl_ten_danh_muc);
            this.kryptonPanel2.Controls.Add(this.lbl_ma_danh_muc);
            this.kryptonPanel2.Size = new System.Drawing.Size(502, 347);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.White;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Location = new System.Drawing.Point(0, 343);
            this.kryptonPanel3.Size = new System.Drawing.Size(502, 107);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Size = new System.Drawing.Size(195, 42);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.White;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.Values.Text = "Sửa danh mục";
            // 
            // lbl_ma_danh_muc
            // 
            this.lbl_ma_danh_muc.Location = new System.Drawing.Point(69, 44);
            this.lbl_ma_danh_muc.Name = "lbl_ma_danh_muc";
            this.lbl_ma_danh_muc.Size = new System.Drawing.Size(105, 24);
            this.lbl_ma_danh_muc.TabIndex = 0;
            this.lbl_ma_danh_muc.Values.Text = "Mã danh mục";
            // 
            // lbl_ten_danh_muc
            // 
            this.lbl_ten_danh_muc.Location = new System.Drawing.Point(69, 122);
            this.lbl_ten_danh_muc.Name = "lbl_ten_danh_muc";
            this.lbl_ten_danh_muc.Size = new System.Drawing.Size(109, 24);
            this.lbl_ten_danh_muc.TabIndex = 1;
            this.lbl_ten_danh_muc.Values.Text = "Tên danh mục";
            // 
            // txt_ma_danh_muc
            // 
            this.txt_ma_danh_muc.Location = new System.Drawing.Point(233, 41);
            this.txt_ma_danh_muc.Name = "txt_ma_danh_muc";
            this.txt_ma_danh_muc.Size = new System.Drawing.Size(184, 27);
            this.txt_ma_danh_muc.TabIndex = 2;
            // 
            // txt_ten_danh_muc
            // 
            this.txt_ten_danh_muc.Location = new System.Drawing.Point(233, 119);
            this.txt_ten_danh_muc.Name = "txt_ten_danh_muc";
            this.txt_ten_danh_muc.Size = new System.Drawing.Size(184, 27);
            this.txt_ten_danh_muc.TabIndex = 3;
            // 
            // FormDanhMucEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Name = "FormDanhMucEdit";
            this.Text = "FormDanhMucEdit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lbl_ten_danh_muc;
        private Krypton.Toolkit.KryptonLabel lbl_ma_danh_muc;
        private Krypton.Toolkit.KryptonTextBox txt_ten_danh_muc;
        private Krypton.Toolkit.KryptonTextBox txt_ma_danh_muc;
    }
}