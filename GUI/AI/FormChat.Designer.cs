using System.ComponentModel;

namespace CHTL.GUI.AI {
    partial class FormChat {
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
            this.textboxTinNhan = new Krypton.Toolkit.KryptonTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGui = new Krypton.Toolkit.KryptonButton();
            this.containerConversation = new Krypton.Toolkit.KryptonPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerConversation)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxTinNhan
            // 
            this.textboxTinNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxTinNhan.Location = new System.Drawing.Point(3, 7);
            this.textboxTinNhan.Name = "textboxTinNhan";
            this.textboxTinNhan.Size = new System.Drawing.Size(896, 27);
            this.textboxTinNhan.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnGui);
            this.panel1.Controls.Add(this.textboxTinNhan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 392);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(4);
            this.panel1.Size = new System.Drawing.Size(980, 43);
            this.panel1.TabIndex = 1;
            // 
            // btnGui
            // 
            this.btnGui.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGui.Location = new System.Drawing.Point(906, 4);
            this.btnGui.Name = "btnGui";
            this.btnGui.Size = new System.Drawing.Size(70, 35);
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
            this.containerConversation.Location = new System.Drawing.Point(10, 10);
            this.containerConversation.Name = "containerConversation";
            this.containerConversation.Size = new System.Drawing.Size(980, 382);
            this.containerConversation.TabIndex = 4;
            // 
            // FormChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 445);
            this.Controls.Add(this.containerConversation);
            this.Controls.Add(this.panel1);
            this.Name = "FormChat";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FormChat";
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

        #endregion
    }
}