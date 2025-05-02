using CHTL.BUS;
using CHTL.Models;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CHTL.GUI.BaoCao {
    public partial class FormBaoCaoView : KryptonForm {
        private XuLyBaoCao xuLy = new XuLyBaoCao();
        private CHTL.Models.BaoCao baoCao;
        private PrintDocument printDocument = new PrintDocument();
        private int currentHoaDonIndex = 0; // Theo dõi chỉ số hóa đơn hiện tại khi in
        private int currentSanPhamIndex = 0; // Theo dõi chỉ số sản phẩm hiện tại trong hóa đơn
        //private ChiTietHoaDon selectedHoaDon; // Lưu hóa đơn được chọn để in chi tiết
        
        public FormBaoCaoView()
        {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;

            CustomizeForm();
        }

        private void CustomizeForm()
        {
            // Tùy chỉnh nút Xem Báo Cáo
            // btnXemBaoCao.FlatAppearance.BorderSize = 0;
            // btnXemBaoCao.BackColor = Color.Red; // Màu tím trung bình
            // btnXemBaoCao.ForeColor = Color.White;
            // btnXemBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            //
            // // Tùy chỉnh nút In Báo Cáo
            // btnInBaoCao.FlatAppearance.BorderSize = 0;
            // btnInBaoCao.BackColor = Color.Green; // Màu tím đậm
            // btnInBaoCao.ForeColor = Color.White;
            // btnInBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            // Tùy chỉnh TabControl
            tabControl1.BackColor = Color.FromArgb(245, 240, 255); // Màu nền tab tím nhạt hơn
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Underline);
        }

        private void FormBaoCaoView_Load(object sender, EventArgs e)
        {
            dtpLocTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpLocDenNgay.Value = DateTime.Now;
            LoadBaoCao();
        }
        
        private void LoadBaoCao()
        {
            baoCao = xuLy.LayBaoCao(dtpLocTuNgay.Value, dtpLocDenNgay.Value);

            // Hiển thị thống kê
            labelTongDoanhThu.Text = baoCao.TongDoanhThu.ToString("N0") + " VNĐ";
            labelSoHoaDon.Text = baoCao.TongSoHoaDon.ToString();
            labelSanPhamBanChay.Text = string.IsNullOrEmpty(baoCao.SanPhamBanChay) ? "Không có" : $"{baoCao.SanPhamBanChay} (x{baoCao.SoLuongBanChay})";
            
            // Hiển thị chi tiết hóa đơn
            dgvChiTiet.DataSource = baoCao.ChiTietHoaDon;
            
            CustomizeDataGridView();

            // Vẽ biểu đồ doanh thu theo danh mục
            chart1.Series.Clear();
            Series series = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Pie
            };
            foreach (var item in baoCao.DoanhThuTheoDanhMuc)
            {
                series.Points.AddXY(item.Key, item.Value);
            }
            chart1.Series.Add(series);

            // Ensure there is at least one ChartArea
            if (chart1.ChartAreas.Count == 0)
            {
                chart1.ChartAreas.Add(new ChartArea());
            }

            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.BackColor = Color.FromArgb(245, 240, 255); // Màu nền biểu đồ tím nhạt
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

        private void dtpLocTuNgay_ValueChanged(object sender, EventArgs e) {
            LoadBaoCao();
        }
        
        private void dtpLocDenNgay_ValueChanged(object sender, EventArgs e) {
            LoadBaoCao();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvChiTiet.Columns["colDetails"].Index) {
                ChiTietBaoCao report = dgvChiTiet.Rows[e.RowIndex].DataBoundItem as ChiTietBaoCao;
                var products = report.SanPham;
                
                FormChiTietHoaDonView frmEdit = new FormChiTietHoaDonView();
                frmEdit.SoldProducts = report.SanPham;
                frmEdit.ReceiptId = report.MaHoaDon;
                
                frmEdit.ShowDialog();
            }
        }
    }
}