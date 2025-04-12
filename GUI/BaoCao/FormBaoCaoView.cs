using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using CHTL.BUS;
using CHTL.Models;
using System.Drawing.Printing;
using ComponentFactory.Krypton.Toolkit;

namespace CHTL.GUI.BaoCao
{
    public partial class FormBaoCaoView : KryptonForm
    {
        private XuLyBaoCao xuLy = new XuLyBaoCao();
        private CHTL.Models.BaoCao baoCao;
        private PrintDocument printDocument = new PrintDocument();
        private int currentHoaDonIndex = 0; // Theo dõi chỉ số hóa đơn hiện tại khi in
        private int currentSanPhamIndex = 0; // Theo dõi chỉ số sản phẩm hiện tại trong hóa đơn
        private ChiTietHoaDon selectedHoaDon; // Lưu hóa đơn được chọn để in chi tiết
        public FormBaoCaoView()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);

            CustomizeForm();
        }

        private void CustomizeForm()
        {
            // Đặt FormBorderStyle thành None
            this.FormBorderStyle = FormBorderStyle.None;

            // Đặt màu nền tím nhạt cho form
            this.BackColor = Color.FromArgb(230, 220, 255); // Màu tím nhạt

            // Tùy chỉnh nút Xem Báo Cáo
            btnXemBaoCao.FlatAppearance.BorderSize = 0;
            btnXemBaoCao.BackColor = Color.Red; // Màu tím trung bình
            btnXemBaoCao.ForeColor = Color.White;
            btnXemBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Tùy chỉnh nút In Báo Cáo
            btnInBaoCao.FlatAppearance.BorderSize = 0;
            btnInBaoCao.BackColor = Color.Green; // Màu tím đậm
            btnInBaoCao.ForeColor = Color.White;
            btnInBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Tùy chỉnh TabControl
            tabControl.BackColor = Color.FromArgb(245, 240, 255); // Màu nền tab tím nhạt hơn
            tabControl.Font = new Font("Segoe UI", 12F, FontStyle.Underline);

            // Tùy chỉnh các label trong tab Thống Kê
            label1.ForeColor = Color.Black;// Màu tím đậm cho chữ
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;

            lblTongDoanhThu.ForeColor = Color.FromArgb(106, 90, 205); // Màu tím nhạt hơn cho giá trị
            lblTongHoaDon.ForeColor = Color.FromArgb(106, 90, 205);
            lblSanPhamBanChay.ForeColor = Color.FromArgb(106, 90, 205);
            lblSoLuongBanChay.ForeColor = Color.FromArgb(106, 90, 205);
        }

        private void FormBaoCaoView_Load(object sender, EventArgs e)
        {
            dtpNgayBatDau.Value = DateTime.Now.AddDays(-30);
            dtpNgayKetThuc.Value = DateTime.Now;
            LoadBaoCao();
        }

        private void LoadBaoCao()
        {
            baoCao = xuLy.LayBaoCao(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);

            // Hiển thị thống kê
            lblTongDoanhThu.Text = baoCao.TongDoanhThu.ToString("N0") + " VNĐ";
            lblTongHoaDon.Text = baoCao.TongSoHoaDon.ToString();
            lblSanPhamBanChay.Text = baoCao.SanPhamBanChay ?? "Không có";
            lblSoLuongBanChay.Text = baoCao.SoLuongBanChay.ToString();

            // Hiển thị chi tiết hóa đơn
            dgvChiTiet.DataSource = baoCao.ChiTietHoaDon;
            CustomizeDataGridView();

            // Vẽ biểu đồ doanh thu theo danh mục
            chartDoanhThu.Series.Clear();
            Series series = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Pie
            };
            foreach (var item in baoCao.DoanhThuTheoDanhMuc)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            chartDoanhThu.Series.Add(series);

            // Ensure there is at least one ChartArea
            if (chartDoanhThu.ChartAreas.Count == 0)
            {
                chartDoanhThu.ChartAreas.Add(new ChartArea());
            }

            chartDoanhThu.ChartAreas[0].Area3DStyle.Enable3D = true;
            chartDoanhThu.BackColor = Color.FromArgb(245, 240, 255); // Màu nền biểu đồ tím nhạt
        }

        private void CustomizeDataGridView()
        {
            //dgvChiTiet.BackgroundColor = Color.FromArgb(245, 240, 255); // Màu nền tím nhạt
            dgvChiTiet.BackgroundColor = Color.White; // Màu nền tím nhạt
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dgvChiTiet.EnableHeadersVisualStyles = false;

            // Tùy chỉnh header
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chỉnh hàng
            dgvChiTiet.RowsDefaultCellStyle.BackColor = Color.White;
            dgvChiTiet.RowsDefaultCellStyle.ForeColor = Color.FromArgb(75, 0, 130); // Màu tím đậm
            dgvChiTiet.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dgvChiTiet.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(186, 85, 211); // Màu tím nhạt khi chọn
            dgvChiTiet.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Hàng xen kẽ
            dgvChiTiet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 235, 255); // Màu tím nhạt hơn

            // Tùy chỉnh cột
            for (int i = 0; i < dgvChiTiet.Columns.Count; i++)
            {
                DataGridViewColumn column = dgvChiTiet.Columns[i];
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            }

            dgvChiTiet.GridColor = Color.FromArgb(200, 200, 200);
            dgvChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            // Reset các chỉ số trước khi in
            currentHoaDonIndex = 0;
            currentSanPhamIndex = 0;
            PrintPreviewDialog previewDialog = new PrintPreviewDialog
            {
                Document = printDocument
            };
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
            Font fontHeader = new Font("Segoe UI", 12, FontStyle.Bold);
            Font fontBody = new Font("Segoe UI", 10);
            int y = 50;
            int pageHeight = e.PageBounds.Height - 50; // Chừa lề dưới

            // Tiêu đề báo cáo
            g.DrawString("BÁO CÁO DOANH THU", fontTitle, Brushes.Black, new PointF(300, y));
            y += 40;
            g.DrawString($"Từ ngày: {baoCao.NgayBatDau:dd/MM/yyyy} - Đến ngày: {baoCao.NgayKetThuc:dd/MM/yyyy}", fontBody, Brushes.Black, new PointF(50, y));
            y += 30;

            // Thống kê
            g.DrawString("THỐNG KÊ CHUNG", fontHeader, Brushes.Black, new PointF(50, y));
            y += 30;
            g.DrawString($"Tổng doanh thu: {baoCao.TongDoanhThu:N0} VNĐ", fontBody, Brushes.Black, new PointF(50, y));
            y += 20;
            g.DrawString($"Tổng số hóa đơn: {baoCao.TongSoHoaDon}", fontBody, Brushes.Black, new PointF(50, y));
            y += 20;
            g.DrawString($"Sản phẩm bán chạy: {baoCao.SanPhamBanChay} ({baoCao.SoLuongBanChay} sản phẩm)", fontBody, Brushes.Black, new PointF(50, y));
            y += 40;

            // Kiểm tra nếu vượt quá chiều cao trang
            if (y > pageHeight)
            {
                e.HasMorePages = true;
                return;
            }

            // Chi tiết hóa đơn
            g.DrawString("CHI TIẾT HÓA ĐƠN", fontHeader, Brushes.Black, new PointF(50, y));
            y += 30;

            // In các hóa đơn từ chỉ số hiện tại
            for (int i = currentHoaDonIndex; i < baoCao.ChiTietHoaDon.Count; i++)
            {
                var chiTiet = baoCao.ChiTietHoaDon[i];

                // In thông tin hóa đơn
                g.DrawString($"Hóa đơn: {chiTiet.MaHoaDon} - Ngày: {chiTiet.NgayBan:dd/MM/yyyy HH:mm} - Nhân viên: {chiTiet.TenNguoiDung}", fontBody, Brushes.Black, new PointF(50, y));
                y += 20;
                g.DrawString($"Tổng tiền: {chiTiet.TongTien:N0} VNĐ", fontBody, Brushes.Black, new PointF(70, y));
                y += 20;

                // Kiểm tra nếu vượt quá chiều cao trang
                if (y > pageHeight)
                {
                    currentHoaDonIndex = i; // Lưu lại chỉ số hóa đơn hiện tại
                    currentSanPhamIndex = 0; // Reset chỉ số sản phẩm
                    e.HasMorePages = true;
                    return;
                }

                // In danh sách sản phẩm
                for (int j = currentSanPhamIndex; j < chiTiet.SanPham.Count; j++)
                {
                    var sp = chiTiet.SanPham[j];
                    g.DrawString($"- {sp.TenSanPham}: {sp.SoLuong} x {sp.DonGia:N0} = {sp.ThanhTien:N0} VNĐ", fontBody, Brushes.Black, new PointF(90, y));
                    y += 20;

                    // Kiểm tra nếu vượt quá chiều cao trang
                    if (y > pageHeight)
                    {
                        currentHoaDonIndex = i; // Lưu lại chỉ số hóa đơn hiện tại
                        currentSanPhamIndex = j + 1; // Lưu lại chỉ số sản phẩm tiếp theo
                        e.HasMorePages = true;
                        return;
                    }
                }

                // Reset chỉ số sản phẩm sau khi in hết sản phẩm của hóa đơn
                currentSanPhamIndex = 0;
                y += 10;

                // Kiểm tra nếu vượt quá chiều cao trang
                if (y > pageHeight)
                {
                    currentHoaDonIndex = i + 1; // Chuyển sang hóa đơn tiếp theo
                    currentSanPhamIndex = 0;
                    e.HasMorePages = true;
                    return;
                }
            }

            // Nếu đã in hết dữ liệu, không cần trang mới
            currentHoaDonIndex = 0; // Reset chỉ số hóa đơn
            currentSanPhamIndex = 0; // Reset chỉ số sản phẩm
            e.HasMorePages = false;
        }
        

        // Hiệu ứng hover cho nút Xem Báo Cáo
        private void btnXemBaoCao_MouseEnter(object sender, EventArgs e)
        {
            btnXemBaoCao.BackColor = Color.FromArgb(138, 43, 226); // Màu tím đậm hơn khi hover
        }

        private void btnXemBaoCao_MouseLeave(object sender, EventArgs e)
        {
            btnXemBaoCao.BackColor = Color.FromArgb(147, 112, 219); // Màu gốc
        }

        // Hiệu ứng hover cho nút In Báo Cáo
        private void btnInBaoCao_MouseEnter(object sender, EventArgs e)
        {
            btnInBaoCao.BackColor = Color.FromArgb(147, 112, 219); // Màu tím nhạt hơn khi hover
        }

        private void btnInBaoCao_MouseLeave(object sender, EventArgs e)
        {
            btnInBaoCao.BackColor = Color.FromArgb(138, 43, 226); // Màu gốc
        }
    }
}