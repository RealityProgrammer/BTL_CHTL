namespace CHTL.GUI.Controls {
    partial class ButtonDanhMucBanHang {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button = new Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.AutoSize = true;
            this.button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Margin = new System.Windows.Forms.Padding(0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(54, 41);
            this.button.StateCommon.Border.Color1 = System.Drawing.Color.Transparent;
            this.button.StateCommon.Border.Color2 = System.Drawing.Color.Transparent;
            this.button.StateCommon.Border.Rounding = 16F;
            this.button.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.button.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.button.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.button.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button.StateCommon.Content.ShortText.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.button.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button.StateNormal.Border.Rounding = 16F;
            this.button.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.button.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(111)))), ((int)(((byte)(158)))));
            this.button.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.button.TabIndex = 1;
            this.button.TabStop = false;
            this.button.Values.DropDownArrowColor = System.Drawing.Color.Empty;
            this.button.Values.Text = "???";
            // 
            // ButtonDanhMucBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.button);
            this.DoubleBuffered = true;
            this.Name = "ButtonDanhMucBanHang";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.Size = new System.Drawing.Size(54, 49);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonButton button;
    }
}
