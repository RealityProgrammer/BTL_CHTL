namespace CHTL.GUI.BaoCao
{
    partial class FormBaoCaoView
    {
        private System.ComponentModel.IContainer components = null;

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabThongKe = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTongDoanhThu = new System.Windows.Forms.Label();
            this.lblTongHoaDon = new System.Windows.Forms.Label();
            this.lblSanPhamBanChay = new System.Windows.Forms.Label();
            this.lblSoLuongBanChay = new System.Windows.Forms.Label();
            this.tabChiTiet = new System.Windows.Forms.TabPage();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.tabBieuDo = new System.Windows.Forms.TabPage();
            this.chartDoanhThu = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            this.btnInBaoCao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabThongKe.SuspendLayout();
            this.tabChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.tabBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabThongKe);
            this.tabControl.Controls.Add(this.tabChiTiet);
            this.tabControl.Controls.Add(this.tabBieuDo);
            this.tabControl.Location = new System.Drawing.Point(30, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1093, 552);
            this.tabControl.TabIndex = 0;
            // 
            // tabThongKe
            // 
            this.tabThongKe.Controls.Add(this.label3);
            this.tabThongKe.Controls.Add(this.label4);
            this.tabThongKe.Controls.Add(this.label5);
            this.tabThongKe.Controls.Add(this.label6);
            this.tabThongKe.Controls.Add(this.lblTongDoanhThu);
            this.tabThongKe.Controls.Add(this.lblTongHoaDon);
            this.tabThongKe.Controls.Add(this.lblSanPhamBanChay);
            this.tabThongKe.Controls.Add(this.lblSoLuongBanChay);
            this.tabThongKe.Location = new System.Drawing.Point(4, 25);
            this.tabThongKe.Name = "tabThongKe";
            this.tabThongKe.Padding = new System.Windows.Forms.Padding(3);
            this.tabThongKe.Size = new System.Drawing.Size(1085, 523);
            this.tabThongKe.TabIndex = 0;
            this.tabThongKe.Text = "Thống Kê";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Tổng doanh thu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 28);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tổng số hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Sản phẩm bán chạy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 28);
            this.label6.TabIndex = 16;
            this.label6.Text = "Số lượng bán chạy:";
            // 
            // lblTongDoanhThu
            // 
            this.lblTongDoanhThu.AutoSize = true;
            this.lblTongDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDoanhThu.Location = new System.Drawing.Point(250, 40);
            this.lblTongDoanhThu.Name = "lblTongDoanhThu";
            this.lblTongDoanhThu.Size = new System.Drawing.Size(0, 28);
            this.lblTongDoanhThu.TabIndex = 5;
            // 
            // lblTongHoaDon
            // 
            this.lblTongHoaDon.AutoSize = true;
            this.lblTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongHoaDon.Location = new System.Drawing.Point(250, 80);
            this.lblTongHoaDon.Name = "lblTongHoaDon";
            this.lblTongHoaDon.Size = new System.Drawing.Size(0, 28);
            this.lblTongHoaDon.TabIndex = 6;
            // 
            // lblSanPhamBanChay
            // 
            this.lblSanPhamBanChay.AutoSize = true;
            this.lblSanPhamBanChay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSanPhamBanChay.Location = new System.Drawing.Point(250, 120);
            this.lblSanPhamBanChay.Name = "lblSanPhamBanChay";
            this.lblSanPhamBanChay.Size = new System.Drawing.Size(0, 28);
            this.lblSanPhamBanChay.TabIndex = 7;
            // 
            // lblSoLuongBanChay
            // 
            this.lblSoLuongBanChay.AutoSize = true;
            this.lblSoLuongBanChay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongBanChay.Location = new System.Drawing.Point(250, 160);
            this.lblSoLuongBanChay.Name = "lblSoLuongBanChay";
            this.lblSoLuongBanChay.Size = new System.Drawing.Size(0, 28);
            this.lblSoLuongBanChay.TabIndex = 8;
            // 
            // tabChiTiet
            // 
            this.tabChiTiet.Controls.Add(this.dgvChiTiet);
            this.tabChiTiet.Location = new System.Drawing.Point(4, 25);
            this.tabChiTiet.Name = "tabChiTiet";
            this.tabChiTiet.Padding = new System.Windows.Forms.Padding(3);
            this.tabChiTiet.Size = new System.Drawing.Size(1085, 523);
            this.tabChiTiet.TabIndex = 1;
            this.tabChiTiet.Text = "Chi Tiết Hóa Đơn";
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Location = new System.Drawing.Point(20, 20);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.Size = new System.Drawing.Size(1047, 483);
            this.dgvChiTiet.TabIndex = 9;
            // 
            // tabBieuDo
            // 
            this.tabBieuDo.Controls.Add(this.chartDoanhThu);
            this.tabBieuDo.Location = new System.Drawing.Point(4, 25);
            this.tabBieuDo.Name = "tabBieuDo";
            this.tabBieuDo.Size = new System.Drawing.Size(1085, 523);
            this.tabBieuDo.TabIndex = 2;
            this.tabBieuDo.Text = "Biểu Đồ";
            // 
            // chartDoanhThu
            // 
            this.chartDoanhThu.Location = new System.Drawing.Point(20, 20);
            this.chartDoanhThu.Name = "chartDoanhThu";
            this.chartDoanhThu.Size = new System.Drawing.Size(1045, 482);
            this.chartDoanhThu.TabIndex = 10;
            this.chartDoanhThu.Text = "chartDoanhThu";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpNgayBatDau.Location = new System.Drawing.Point(204, 47);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(180, 32);
            this.dtpNgayBatDau.TabIndex = 1;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(501, 50);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(180, 32);
            this.dtpNgayKetThuc.TabIndex = 2;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnXemBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemBaoCao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXemBaoCao.Location = new System.Drawing.Point(765, 47);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(120, 35);
            this.btnXemBaoCao.TabIndex = 3;
            this.btnXemBaoCao.Text = "Xem Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = false;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            this.btnXemBaoCao.MouseEnter += new System.EventHandler(this.btnXemBaoCao_MouseEnter);
            this.btnXemBaoCao.MouseLeave += new System.EventHandler(this.btnXemBaoCao_MouseLeave);
            // 
            // btnInBaoCao
            // 
            this.btnInBaoCao.BackColor = System.Drawing.Color.Red;
            this.btnInBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBaoCao.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInBaoCao.Location = new System.Drawing.Point(934, 47);
            this.btnInBaoCao.Name = "btnInBaoCao";
            this.btnInBaoCao.Size = new System.Drawing.Size(120, 35);
            this.btnInBaoCao.TabIndex = 4;
            this.btnInBaoCao.Text = "In Báo Cáo";
            this.btnInBaoCao.UseVisualStyleBackColor = false;
            this.btnInBaoCao.Click += new System.EventHandler(this.btnInBaoCao_Click);
            this.btnInBaoCao.MouseEnter += new System.EventHandler(this.btnInBaoCao_MouseEnter);
            this.btnInBaoCao.MouseLeave += new System.EventHandler(this.btnInBaoCao_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(414, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 28);
            this.label2.TabIndex = 12;
            this.label2.Text = "Đến";
            // 
            // FormBaoCaoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInBaoCao);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBaoCaoView";
            this.Load += new System.EventHandler(this.FormBaoCaoView_Load);
            this.tabControl.ResumeLayout(false);
            this.tabThongKe.ResumeLayout(false);
            this.tabThongKe.PerformLayout();
            this.tabChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.tabBieuDo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDoanhThu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabThongKe;
        private System.Windows.Forms.TabPage tabChiTiet;
        private System.Windows.Forms.TabPage tabBieuDo;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnXemBaoCao;
        private System.Windows.Forms.Button btnInBaoCao;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private System.Windows.Forms.Label lblTongHoaDon;
        private System.Windows.Forms.Label lblSanPhamBanChay;
        private System.Windows.Forms.Label lblSoLuongBanChay;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDoanhThu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}