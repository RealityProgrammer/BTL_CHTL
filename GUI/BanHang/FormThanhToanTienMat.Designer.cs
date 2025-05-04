namespace CHTL.GUI.BanHang {
    partial class FormThanhToanTienMat {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            CHTL.GUI.Controls.SaveOrCancelPanel panelFooter;
            System.Windows.Forms.Label label1;
            this.labelTotal = new System.Windows.Forms.Label();
            panelFooter = new CHTL.GUI.Controls.SaveOrCancelPanel();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelFooter
            // 
            panelFooter.BackColor = System.Drawing.Color.Transparent;
            panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelFooter.Location = new System.Drawing.Point(0, 181);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new System.Drawing.Size(434, 90);
            panelFooter.TabIndex = 0;
            panelFooter.SaveButtonClick += new System.EventHandler(this.panelFooter_SaveButtonClick);
            panelFooter.CancelButtonClick += new System.EventHandler(this.panelFooter_CancelButtonClick);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(75, 64);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Tổng số tiền:";
            // 
            // labelTotal
            // 
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.Color.Black;
            this.labelTotal.Location = new System.Drawing.Point(0, 89);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(434, 46);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "???.??? VNĐ";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormThanhToanTienMat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 271);
            this.Controls.Add(label1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(panelFooter);
            this.MaximumSize = new System.Drawing.Size(450, 325);
            this.MinimumSize = new System.Drawing.Size(450, 325);
            this.Name = "FormThanhToanTienMat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thanh toán tiền mặt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotal;
    }
}