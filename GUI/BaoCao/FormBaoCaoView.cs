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
        private readonly PrintDocument printDocument = new PrintDocument();
        private readonly XuLyBaoCao xuLy = new XuLyBaoCao();
        private Models.BaoCao baoCao;
        private int currentHoaDonIndex; // Theo dõi chỉ số hóa đơn hiện tại khi in

        private int currentSanPhamIndex; // Theo dõi chỉ số sản phẩm hiện tại trong hóa đơn
        //private ChiTietHoaDon selectedHoaDon; // Lưu hóa đơn được chọn để in chi tiết

        public FormBaoCaoView() {
            InitializeComponent();
            printDocument.PrintPage += PrintDocument_PrintPage;

            CustomizeForm();
        }

        private void CustomizeForm() {
            // Tùy chỉnh TabControl
            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.ItemSize = new Size(150, 30);
            tabControl1.DrawItem += (s, e) => {
                TabPage tabPage = tabControl1.TabPages[e.Index];
                Graphics g = e.Graphics;
                SizeF textSize = g.MeasureString(tabPage.Text, tabPage.Font);
                Rectangle rect = e.Bounds;
                bool isSelected = e.Index == tabControl1.SelectedIndex;

                // Nền tab
                using (var brush = new SolidBrush(isSelected ? Color.FromArgb(52, 152, 219) : Color.FromArgb(189, 195, 199))) {
                    g.FillRectangle(brush, rect);
                }

                // Viền tab
                using (var pen = new Pen(Color.FromArgb(189, 195, 199), 1)) {
                    g.DrawRectangle(pen, rect);
                }

                // Văn bản
                using (var brush = new SolidBrush(isSelected ? Color.White : Color.FromArgb(44, 62, 80))) {
                    g.DrawString(tabPage.Text, tabPage.Font, brush,
                        rect.X + (rect.Width - textSize.Width) / 2,
                        rect.Y + (rect.Height - textSize.Height) / 2);
                }
            };
        }

        private void FormBaoCaoView_Load(object sender, EventArgs e) {
            dtpLocTuNgay.Value = DateTime.Now.AddDays(-30);
            dtpLocDenNgay.Value = DateTime.Now;
            LoadBaoCao();
        }

        private void LoadBaoCao() {
            baoCao = xuLy.LayBaoCao(dtpLocTuNgay.Value, dtpLocDenNgay.Value);

            // Hiển thị thống kê
            labelTongDoanhThu.Text = baoCao.TongDoanhThu.ToString("N0") + " VNĐ";
            labelSoHoaDon.Text = baoCao.TongSoHoaDon.ToString();
            labelSanPhamBanChay.Text = string.IsNullOrEmpty(baoCao.SanPhamBanChay) ? "Không có" : $"{baoCao.SanPhamBanChay} (x{baoCao.SoLuongBanChay})";

            // Hiển thị chi tiết hóa đơn
            dgvChiTiet.DataSource = baoCao.ChiTietHoaDon;

            CustomizeDataGridView();

            // Vẽ biểu đồ doanh thu theo danh mục
            chartDoanhThu.Series.Clear();
            var series = new Series("DoanhThu") {
                ChartType = SeriesChartType.Pie,
            };

            foreach (var item in baoCao.DoanhThuTheoDanhMuc) {
                series.Points.AddXY(item.Key, item.Value);
            }

            chartDoanhThu.Series.Add(series);

            // Ensure there is at least one ChartArea
            if (chartDoanhThu.ChartAreas.Count == 0) {
                chartDoanhThu.ChartAreas.Add(new ChartArea());
            }

            chartDoanhThu.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void CustomizeDataGridView() {
            dgvChiTiet.BackgroundColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            dgvChiTiet.BorderStyle = BorderStyle.None;
            dgvChiTiet.EnableHeadersVisualStyles = false;

            // Tùy chỉnh header
            dgvChiTiet.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            dgvChiTiet.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvChiTiet.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTiet.ColumnHeadersHeight = 40;

            // Tùy chỉnh hàng
            dgvChiTiet.RowsDefaultCellStyle.BackColor = Color.White;
            dgvChiTiet.RowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            dgvChiTiet.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvChiTiet.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            dgvChiTiet.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Hàng xen kẽ
            dgvChiTiet.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 250); // Xám rất nhạt

            dgvChiTiet.GridColor = Color.FromArgb(189, 195, 199); // Xám nhạt
            dgvChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e) {
            LoadBaoCao();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e) {
            // Reset các chỉ số trước khi in
            currentHoaDonIndex = 0;
            currentSanPhamIndex = 0;
            var previewDialog = new PrintPreviewDialog {
                Document = printDocument,
            };
            previewDialog.ShowDialog();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e) {
            Graphics g = e.Graphics;
            var fontTitle = new Font("Segoe UI", 16, FontStyle.Bold);
            var fontHeader = new Font("Segoe UI", 12, FontStyle.Bold);
            var fontBody = new Font("Segoe UI", 10);
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
            if (y > pageHeight) {
                e.HasMorePages = true;
                return;
            }

            // Chi tiết hóa đơn
            g.DrawString("CHI TIẾT HÓA ĐƠN", fontHeader, Brushes.Black, new PointF(50, y));
            y += 30;

            // In các hóa đơn từ chỉ số hiện tại
            for (int i = currentHoaDonIndex; i < baoCao.ChiTietHoaDon.Count; i++) {
                ChiTietBaoCao chiTiet = baoCao.ChiTietHoaDon[i];

                // In thông tin hóa đơn
                g.DrawString($"Hóa đơn: {chiTiet.MaHoaDon} - Ngày: {chiTiet.NgayBan:dd/MM/yyyy HH:mm} - Nhân viên: {chiTiet.TenNguoiDung}", fontBody, Brushes.Black, new PointF(50, y));
                y += 20;
                g.DrawString($"Tổng tiền: {chiTiet.TongTien:N0} VNĐ", fontBody, Brushes.Black, new PointF(70, y));
                y += 20;

                // Kiểm tra nếu vượt quá chiều cao trang
                if (y > pageHeight) {
                    currentHoaDonIndex = i; // Lưu lại chỉ số hóa đơn hiện tại
                    currentSanPhamIndex = 0; // Reset chỉ số sản phẩm
                    e.HasMorePages = true;
                    return;
                }

                // In danh sách sản phẩm
                for (int j = currentSanPhamIndex; j < chiTiet.SanPham.Count; j++) {
                    SanPhamBan sp = chiTiet.SanPham[j];
                    g.DrawString($"- {sp.TenSanPham}: {sp.SoLuong} x {sp.DonGia:N0} = {sp.ThanhTien:N0} VNĐ", fontBody, Brushes.Black, new PointF(90, y));
                    y += 20;

                    // Kiểm tra nếu vượt quá chiều cao trang
                    if (y > pageHeight) {
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
                if (y > pageHeight) {
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
                var report = dgvChiTiet.Rows[e.RowIndex].DataBoundItem as ChiTietBaoCao;
                var products = report.SanPham;

                var frmEdit = new FormChiTietHoaDonView();
                frmEdit.SoldProducts = report.SanPham;
                frmEdit.ReceiptId = report.MaHoaDon;

                frmEdit.ShowDialog();
            }
        }
    }
}