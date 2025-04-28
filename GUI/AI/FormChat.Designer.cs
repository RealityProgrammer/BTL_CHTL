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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGui = new Krypton.Toolkit.KryptonButton();
            this.containerConversation = new Krypton.Toolkit.KryptonPanel();
            this.btnClose = new Krypton.Toolkit.KryptonButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerConversation)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxTinNhan
            // 
            this.textboxTinNhan.Location = new System.Drawing.Point(10, 15);
            this.textboxTinNhan.Name = "textboxTinNhan";
            this.textboxTinNhan.Size = new System.Drawing.Size(650, 40);
            this.textboxTinNhan.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            this.textboxTinNhan.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.textboxTinNhan.StateCommon.Border.Rounding = 10F;
            this.textboxTinNhan.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(44, 62, 80);
            this.textboxTinNhan.StateCommon.Content.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.textboxTinNhan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.panel1.Controls.Add(this.btnGui);
            this.panel1.Controls.Add(this.textboxTinNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 520);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(780, 70);
            this.panel1.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.Location = new System.Drawing.Point(670, 15);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(100, 40);
            this.btnGui.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGui.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnGui.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            this.btnGui.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnGui.StateCommon.Border.Rounding = 10F;
            this.btnGui.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnGui.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnGui.TabIndex = 2;
            this.btnGui.Values.Text = "Gửi";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            this.btnGui.MouseEnter += new System.EventHandler((s, e) =>
            {
                btnGui.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(41, 128, 185);
                btnGui.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(41, 128, 185);
            });
            this.btnGui.MouseLeave += new System.EventHandler((s, e) =>
            {
                btnGui.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(52, 152, 219);
                btnGui.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(52, 152, 219);
            });
            // 
            // containerConversation
            // 
            this.containerConversation.AutoScroll = true;
            this.containerConversation.AutoScrollMinSize = new System.Drawing.Size(0, 1);
            this.containerConversation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerConversation.Location = new System.Drawing.Point(10, 10);
            this.containerConversation.Name = "containerConversation";
            this.containerConversation.Padding = new System.Windows.Forms.Padding(10);
            this.containerConversation.Size = new System.Drawing.Size(780, 510);
            this.containerConversation.StateCommon.Color1 = System.Drawing.Color.FromArgb(236, 240, 241);
            //this.containerConversation.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.None;
            this.containerConversation.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(670, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 40);
            this.btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(243, 156, 18);
            this.btnClose.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(189, 195, 199);
            this.btnClose.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom)
                | Krypton.Toolkit.PaletteDrawBorders.Left)
                | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClose.StateCommon.Border.Rounding = 10F;
            this.btnClose.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnClose.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.TabIndex = 5;
            this.btnClose.Values.Text = "Đóng";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler((s, e) =>
            {
                btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(230, 126, 34);
                btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(230, 126, 34);
            });
            this.btnClose.MouseLeave += new System.EventHandler((s, e) =>
            {
                btnClose.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(243, 156, 18);
                btnClose.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(243, 156, 18);
            });
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(236, 240, 241);
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.containerConversation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChat";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Chat Với AI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerConversation)).EndInit();
            this.ResumeLayout(false);
        }

        private Krypton.Toolkit.KryptonPanel containerConversation;
        private Krypton.Toolkit.KryptonButton btnGui;
        private System.Windows.Forms.Panel panel1;
        private Krypton.Toolkit.KryptonTextBox textboxTinNhan;
        private Krypton.Toolkit.KryptonButton btnClose;

        #endregion
    }
}