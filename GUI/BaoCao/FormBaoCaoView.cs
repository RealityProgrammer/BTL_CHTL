using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using CHTL.BUS;
using CHTL.Models;
using System.Drawing.Printing;
using Krypton.Toolkit;

namespace CHTL.GUI.BaoCao
{
    public partial class FormBaoCaoView : KryptonForm
    {
        private XuLyBaoCao xuLy = new XuLyBaoCao();
        private CHTL.Models.BaoCao baoCao;
        private PrintDocument printDocument = new PrintDocument();
        private int currentHoaDonIndex = 0;
        private int currentSanPhamIndex = 0;

        public FormBaoCaoView()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Tùy chỉnh TabControl
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.ItemSize = new Size(150, 30);
            tabControl.DrawItem += (s, e) =>
            {
                var tab = tabControl.TabPages[e.Index];
                var g = e.Graphics;
                var textSize = g.MeasureString(tab.Text, new Font("Segoe UI", 12F, FontStyle.Bold));
                var rect = e.Bounds;
                var isSelected = e.Index == tabControl.SelectedIndex;

                // Nền tab
                using (var brush = new SolidBrush(isSelected ? Color.FromArgb(52, 152, 219) : Color.FromArgb(189, 195, 199)))
                {
                    g.FillRectangle(brush, rect);
                }

                // Viền tab
                using (var pen = new Pen(Color.FromArgb(189, 195, 199), 1))
                {
                    g.DrawRectangle(pen, rect);
                }

                // Văn bản
                using (var brush = new SolidBrush(isSelected ? Color.White : Color.FromArgb(44, 62, 80)))
                {
                    g.DrawString(tab.Text, new Font("Segoe UI", 12F, FontStyle.Bold), brush,
                        rect.X + (rect.Width - textSize.Width) / 2,
                        rect.Y + (rect.Height - textSize.Height) / 2);
                }
            };

            // Tùy chỉnh nhãn trong tab Thống Kê
            label3.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            label4.ForeColor = Color.FromArgb(44, 62, 80);
            label5.ForeColor = Color.FromArgb(44, 62, 80);
            label6.ForeColor = Color.FromArgb(44, 62, 80);
            lblTongDoanhThu.ForeColor = Color.FromArgb(52, 152, 219); // Xanh dương
            lblTongHoaDon.ForeColor = Color.FromArgb(52, 152, 219);
            lblSanPhamBanChay.ForeColor = Color.FromArgb(52, 152, 219);
            lblSoLuongBanChay.ForeColor = Color.FromArgb(52, 152, 219);

            // Tùy chỉnh DateTimePicker
            dtpNgayBatDau.Font = new Font("Segoe UI", 12F);
            dtpNgayKetThuc.Font = new Font("Segoe UI", 12F);
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
            chartDoanhThu.ChartAreas.Clear();
            chartDoanhThu.ChartAreas.Add(new ChartArea());
            chartDoanhThu.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            chartDoanhThu.ChartAreas[0].BackColor = Color.FromArgb(236, 240, 241);
            chartDoanhThu.Titles.Clear();
            chartDoanhThu.Titles.Add(new Title("Doanh Thu Theo Danh Mục", Docking.Top, new Font("Segoe UI", 14F, FontStyle.Bold), Color.FromArgb(44, 62, 80)));

            Series series = new Series("DoanhThu")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelForeColor = Color.FromArgb(44, 62, 80),
                Font = new Font("Segoe UI", 10F)
            };

            Color[] colors = new Color[]
            {
                Color.FromArgb(52, 152, 219), // Xanh dương
                Color.FromArgb(231, 76, 60),  // Đỏ nhạt
                Color.FromArgb(243, 156, 18), // Cam nhạt
                Color.FromArgb(149, 165, 166), // Xám đậm
                Color.FromArgb(46, 204, 113)  // Xanh lá nhạt
            };

            int colorIndex = 0;
            foreach (var item in baoCao.DoanhThuTheoDanhMuc)
            {
                var point = series.Points.AddXY(item.Key, item.Value);
                series.Points[point].Color = colors[colorIndex % colors.Length];
                colorIndex++;
            }

            chartDoanhThu.Series.Add(series);
            chartDoanhThu.ChartAreas[0].Area3DStyle.Enable3D = true;
        }

        private void CustomizeDataGridView()
        {
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

            // Tùy chỉnh cột
            foreach (DataGridViewColumn column in dgvChiTiet.Columns)
            {
                if (column.Name == "colMaHoaDon")
                {
                    column.Width = 150;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else if (column.Name == "colDetails")
                {
                    column.Width = 100;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }

            dgvChiTiet.GridColor = Color.FromArgb(189, 195, 199); // Xám nhạt
            dgvChiTiet.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
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
            int pageHeight = e.PageBounds.Height - 50;

            // Tiêu đề báo cáo
            g.DrawString("BÁO CÁO DOANH THU", fontTitle, new SolidBrush(Color.FromArgb(44, 62, 80)), new PointF(300, y));
            y += 40;
            g.DrawString($"Từ ngày: {baoCao.NgayBatDau:dd/MM/yyyy} - Đến ngày: {baoCao.NgayKetThuc:dd/MM/yyyy}", fontBody, new SolidBrush(Color.FromArgb(44, 62, 80)), new PointF(50, y));
            y += 30;

            // Thống kê
            g.DrawString("THỐNG KÊ CHUNG", fontHeader, new SolidBrush(Color.FromArgb(44, 62, 80)), new PointF(50, y));
            y += 30;
            g.DrawString($"Tổng doanh thu: {baoCao.TongDoanhThu:N0} VNĐ", fontBody, new SolidBrush(Color.FromArgb(52, 152, 219)), new PointF(50, y));
            y += 20;
            g.DrawString($"Tổng số hóa đơn: {baoCao.TongSoHoaDon}", fontBody, new SolidBrush(Color.FromArgb(52, 152, 219)), new PointF(50, y));
            y += 20;
            g.DrawString($"Sản phẩm bán chạy: {baoCao.SanPhamBanChay} ({baoCao.SoLuongBanChay} sản phẩm)", fontBody, new SolidBrush(Color.FromArgb(52, 152, 219)), new PointF(50, y));
            y += 40;

            if (y > pageHeight)
            {
                e.HasMorePages = true;
                return;
            }

            // Chi tiết hóa đơn
            g.DrawString("CHI TIẾT HÓA ĐƠN", fontHeader, new SolidBrush(Color.FromArgb(44, 62, 80)), new PointF(50, y));
            y += 30;

            for (int i = currentHoaDonIndex; i < baoCao.ChiTietHoaDon.Count; i++)
            {
                var chiTiet = baoCao.ChiTietHoaDon[i];
                g.DrawString($"Hóa đơn: {chiTiet.MaHoaDon} - Ngày: {chiTiet.NgayBan:dd/MM/yyyy HH:mm} - Nhân viên: {chiTiet.TenNguoiDung}", fontBody, new SolidBrush(Color.FromArgb(44, 62, 80)), new PointF(50, y));
                y += 20;
                g.DrawString($"Tổng tiền: {chiTiet.TongTien:N0} VNĐ", fontBody, new SolidBrush(Color.FromArgb(52, 152, 219)), new PointF(70, y));
                y += 20;

                if (y > pageHeight)
                {
                    currentHoaDonIndex = i;
                    currentSanPhamIndex = 0;
                    e.HasMorePages = true;
                    return;
                }

                for (int j = currentSanPhamIndex; j < chiTiet.SanPham.Count; j++)
                {
                    var sp = chiTiet.SanPham[j];
                    g.DrawString($"- {sp.TenSanPham}: {sp.SoLuong} x {sp.DonGia:N0} = {sp.ThanhTien:N0} VNĐ", fontBody, new SolidBrush(Color.FromArgb(44, 62, 80)), new PointF(90, y));
                    y += 20;

                    if (y > pageHeight)
                    {
                        currentHoaDonIndex = i;
                        currentSanPhamIndex = j + 1;
                        e.HasMorePages = true;
                        return;
                    }
                }

                currentSanPhamIndex = 0;
                y += 10;

                if (y > pageHeight)
                {
                    currentHoaDonIndex = i + 1;
                    currentSanPhamIndex = 0;
                    e.HasMorePages = true;
                    return;
                }
            }

            currentHoaDonIndex = 0;
            currentSanPhamIndex = 0;
            e.HasMorePages = false;
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {
            LoadBaoCao();
        }

        private void dgvChiTiet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvChiTiet.Columns["colDetails"].Index)
            {
                ChiTietBaoCao report = dgvChiTiet.Rows[e.RowIndex].DataBoundItem as ChiTietBaoCao;
                var products = report.SanPham;

                FormChiTietHoaDonView frmEdit = new FormChiTietHoaDonView();
                frmEdit.SoldProducts = report.SanPham;
                frmEdit.ReceiptId = report.MaHoaDon;

                frmEdit.ShowDialog();
            }
        }

        private void dgvChiTiet_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colDetails")
            {
                dgvChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(41, 128, 185); // Xanh đậm
                dgvChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgvChiTiet_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvChiTiet.Columns[e.ColumnIndex].Name == "colDetails")
            {
                dgvChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
                dgvChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTiet.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }
    }
}