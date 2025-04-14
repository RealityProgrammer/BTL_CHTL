namespace CHTL.GUI.Sample_Form
{
    partial class SampleView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SampleView));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.txt_search = new Krypton.Toolkit.KryptonTextBox();
            this.btn_add = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonSeparator1 = new Krypton.Toolkit.KryptonSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(706, 29);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(113, 36);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Tìm kiếm";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(706, 71);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(269, 42);
            this.txt_search.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) | Krypton.Toolkit.PaletteDrawBorders.Left) | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_search.StateCommon.Border.Rounding = 12F;
            this.txt_search.StateCommon.Content.Color1 = System.Drawing.Color.Navy;
            this.txt_search.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.TabIndex = 1;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_add
            // 
            this.btn_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_add.Image")));
            this.btn_add.Location = new System.Drawing.Point(49, 59);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(64, 64);
            this.btn_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_add.TabIndex = 2;
            this.btn_add.TabStop = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(39, 17);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(175, 42);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 3;
            this.kryptonLabel2.Values.Text = "Header Text";
            // 
            // kryptonSeparator1
            // 
            this.kryptonSeparator1.Location = new System.Drawing.Point(39, 140);
            this.kryptonSeparator1.Name = "kryptonSeparator1";
            this.kryptonSeparator1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.kryptonSeparator1.Size = new System.Drawing.Size(936, 10);
            this.kryptonSeparator1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.kryptonSeparator1.StateCommon.Back.Color2 = System.Drawing.Color.Navy;
            this.kryptonSeparator1.StateCommon.Separator.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonSeparator1.StateCommon.Separator.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.kryptonSeparator1.TabIndex = 4;
            // 
            // SampleView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(998, 653);
            this.Controls.Add(this.kryptonSeparator1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SampleView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btn_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSeparator1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        public Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public Krypton.Toolkit.KryptonTextBox txt_search;
        public Krypton.Toolkit.KryptonLabel kryptonLabel2;
        public Krypton.Toolkit.KryptonSeparator kryptonSeparator1;
        public System.Windows.Forms.PictureBox btn_add;
    }
}