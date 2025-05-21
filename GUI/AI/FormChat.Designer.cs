using System.ComponentModel;

namespace CHTL.GUI.AI
{
    partial class FormChat
    {
        private IContainer components = null;

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
            this.textboxTinNhan = new Krypton.Toolkit.KryptonTextBox();
            this.btnGui = new Krypton.Toolkit.KryptonButton();
            this.containerConversation = new Krypton.Toolkit.KryptonPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kryptonTableLayoutPanel1 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.kryptonTableLayoutPanel2 = new Krypton.Toolkit.KryptonTableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.kryptonPictureBox1 = new Krypton.Toolkit.KryptonPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.containerConversation)).BeginInit();
            this.panel1.SuspendLayout();
            this.kryptonTableLayoutPanel1.SuspendLayout();
            this.kryptonTableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxTinNhan
            // 
            this.textboxTinNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxTinNhan.Location = new System.Drawing.Point(3, 3);
            this.textboxTinNhan.Name = "textboxTinNhan";
            this.textboxTinNhan.Size = new System.Drawing.Size(608, 38);
            this.textboxTinNhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.textboxTinNhan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textboxTinNhan.StateCommon.Border.Rounding = 10F;
            this.textboxTinNhan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.textboxTinNhan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textboxTinNhan.TabIndex = 0;
            // 
            // btnGui
            // 
            this.btnGui.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGui.Location = new System.Drawing.Point(632, 3);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(74, 38);
            this.btnGui.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGui.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnGui.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.btnGui.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGui.StateCommon.Border.Rounding = 10F;
            this.btnGui.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGui.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGui.TabIndex = 2;
            this.btnGui.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.btnGui.Values.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // containerConversation
            // 
            this.containerConversation.AutoScroll = true;
            this.containerConversation.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.containerConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerConversation.Location = new System.Drawing.Point(10, 70);
            this.containerConversation.Name = "containerConversation";
            this.containerConversation.Padding = new System.Windows.Forms.Padding(5);
            this.containerConversation.Size = new System.Drawing.Size(729, 287);
            this.containerConversation.StateCommon.Color1 = System.Drawing.Color.White;
            this.containerConversation.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.kryptonTableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 357);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(729, 64);
            this.panel1.TabIndex = 1;
            // 
            // kryptonTableLayoutPanel1
            // 
            this.kryptonTableLayoutPanel1.ColumnCount = 3;
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.kryptonTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.kryptonTableLayoutPanel1.Controls.Add(this.btnGui, 2, 0);
            this.kryptonTableLayoutPanel1.Controls.Add(this.textboxTinNhan, 0, 0);
            this.kryptonTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.kryptonTableLayoutPanel1.Name = "kryptonTableLayoutPanel1";
            this.kryptonTableLayoutPanel1.RowCount = 1;
            this.kryptonTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel1.Size = new System.Drawing.Size(709, 44);
            this.kryptonTableLayoutPanel1.StateCommon.Color1 = System.Drawing.Color.Transparent;
            this.kryptonTableLayoutPanel1.StateCommon.Color2 = System.Drawing.Color.Transparent;
            this.kryptonTableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonTableLayoutPanel2
            // 
            this.kryptonTableLayoutPanel2.ColumnCount = 2;
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.kryptonTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.kryptonTableLayoutPanel2.Controls.Add(this.kryptonPictureBox1, 0, 0);
            this.kryptonTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonTableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.kryptonTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonTableLayoutPanel2.Name = "kryptonTableLayoutPanel2";
            this.kryptonTableLayoutPanel2.RowCount = 1;
            this.kryptonTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.kryptonTableLayoutPanel2.Size = new System.Drawing.Size(729, 60);
            this.kryptonTableLayoutPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.kryptonTableLayoutPanel2.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.kryptonTableLayoutPanel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trợ lý AI Cửa Hàng Tiện Lợi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // kryptonPictureBox1
            // 
            this.kryptonPictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPictureBox1.Location = new System.Drawing.Point(5, 5);
            this.kryptonPictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.kryptonPictureBox1.Name = "kryptonPictureBox1";
            this.kryptonPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.kryptonPictureBox1.TabIndex = 2;
            this.kryptonPictureBox1.TabStop = false;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 431);
            this.Controls.Add(this.containerConversation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.kryptonTableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChat";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.Load += new System.EventHandler(this.FormChat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.containerConversation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.ResumeLayout(false);
            this.kryptonTableLayoutPanel1.PerformLayout();
            this.kryptonTableLayoutPanel2.ResumeLayout(false);
            this.kryptonTableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private Krypton.Toolkit.KryptonPanel containerConversation;
        private Krypton.Toolkit.KryptonButton btnGui;
        private Krypton.Toolkit.KryptonTextBox textboxTinNhan;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel1;
        private Krypton.Toolkit.KryptonTableLayoutPanel kryptonTableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonPictureBox kryptonPictureBox1;
    }
}