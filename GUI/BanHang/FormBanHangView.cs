using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;
using CHTL.BUS;
using CHTL.Models;
using System.Drawing;
using System.Linq;
using CHTL.DAL;
using Krypton.Toolkit;

namespace CHTL.GUI.BanHang
{
    public partial class FormBanHangView : KryptonForm
    {
        private XuLySanPham xuLySanPham = new XuLySanPham();
        private XuLyHoaDon xuLyHoaDon = new XuLyHoaDon();
        private TruyCapSanPham truyCapSanPham = new TruyCapSanPham();
        private List<ChiTietHoaDon> chiTietHoaDonList = new List<ChiTietHoaDon>();
        private decimal grandTotal = 0;

        public FormBanHangView()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadSanPham();
            dtpNgayBan.Value = DateTime.Now;
        }

        private void ConfigureDataGridView()
        {
            // Cấu hình dgvChiTietHoaDon
            dgvChiTietHoaDon.ScrollBars = ScrollBars.Both; // Thêm thanh cuộn
            dgvChiTietHoaDon.AutoGenerateColumns = false; // Tắt tự động tạo cột
            dgvChiTietHoaDon.ForeColor = Color.Black;
            dgvChiTietHoaDon.BackColor = Color.White;
            dgvChiTietHoaDon.BackgroundColor = Color.White;
            dgvChiTietHoaDon.GridColor = Color.FromArgb(128, 128, 255);
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64);
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTietHoaDon.EnableHeadersVisualStyles = false;
            dgvChiTietHoaDon.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvChiTietHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 255);
            dgvChiTietHoaDon.DefaultCellStyle.BackColor = Color.White;
            dgvChiTietHoaDon.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dgvChiTietHoaDon.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvChiTietHoaDon.CellFormatting += dgvChiTietHoaDon_CellFormatting;
        }

        private void LoadSanPham()
        {
            flpSanPham.Controls.Clear();
            var danhSach = xuLySanPham.LayDanhSachSanPham();
            foreach (var sp in danhSach)
            {
                var panel = new Panel
                {
                    Size = new Size(150, 120),
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White
                };

                var lblTen = new Label
                {
                    Text = sp.TenSanPham,
                    Location = new Point(5, 5),
                    Size = new Size(140, 30),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.Navy
                };

                var lblGia = new Label
                {
                    Text = $"Giá: {sp.GiaBan:N2}",
                    Location = new Point(5, 40),
                    Size = new Size(140, 20),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.Black
                };

                var lblTon = new Label
                {
                    Text = $"Tồn: {sp.SoLuongTon}",
                    Location = new Point(5, 60),
                    Size = new Size(140, 20),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.Black
                };

                var btnThem = new Button
                {
                    Text = "Thêm",
                    Location = new Point(5, 85),
                    Size = new Size(140, 30),
                    BackColor = Color.FromArgb(0, 0, 64),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Tag = sp
                };
                btnThem.Click += BtnThem_Click;

                panel.Controls.Add(lblTen);
                panel.Controls.Add(lblGia);
                panel.Controls.Add(lblTon);
                panel.Controls.Add(btnThem);
                flpSanPham.Controls.Add(panel);
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var sanPham = btn.Tag as CHTL.Models.SanPham;
            if (sanPham != null)
            {
                // Kiểm tra số lượng tồn
                if (sanPham.SoLuongTon <= 0)
                {
                    MessageBox.Show($"Sản phẩm {sanPham.TenSanPham} đã hết hàng!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem sản phẩm đã có trong hóa đơn chưa
                var existingItem = chiTietHoaDonList.FirstOrDefault(x => x.MaSanPham == sanPham.MaSanPham);
                if (existingItem != null)
                {
                    // Tăng số lượng nếu sản phẩm đã có
                    existingItem.SoLuong++;
                    if (existingItem.SoLuong > sanPham.SoLuongTon)
                    {
                        MessageBox.Show($"Sản phẩm {sanPham.TenSanPham} không đủ số lượng tồn (còn {sanPham.SoLuongTon})!",
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existingItem.SoLuong--;
                        return;
                    }
                    existingItem.DonGia = sanPham.GiaBan * existingItem.SoLuong;
                }
                else
                {
                    // Thêm sản phẩm mới vào hóa đơn
                    var cthd = new ChiTietHoaDon
                    {
                        MaChiTiet = Guid.NewGuid().ToString(),
                        MaHoaDon = "", // Sẽ cập nhật sau khi lưu hóa đơn
                        MaSanPham = sanPham.MaSanPham,
                        SoLuong = 1,
                        DonGia = sanPham.GiaBan
                    };
                    chiTietHoaDonList.Add(cthd);
                }

                // Cập nhật danh sách chi tiết hóa đơn và tổng tiền
                UpdateChiTietHoaDon();
            }
        }

        private void UpdateChiTietHoaDon()
        {
            // Cập nhật DataGridView chi tiết hóa đơn
            var displayList = chiTietHoaDonList.Select(cthd =>
            {
                var sp = truyCapSanPham.LaySanPhamTheoMa(cthd.MaSanPham);
                return new
                {
                    TenSanPham = sp?.TenSanPham,
                    SoLuong = cthd.SoLuong,
                    GiaBan = sp?.GiaBan,
                    ThanhTien = cthd.DonGia
                };
            }).ToList();
            //dgvChiTietHoaDon.DataSource = null;
            dgvChiTietHoaDon.DataSource = displayList;

            // Đảm bảo cột "Xóa" ở vị trí cuối
            if (!dgvChiTietHoaDon.Columns.Contains("colDelete"))
            {
                var colDelete = new DataGridViewButtonColumn
                {
                    Name = "colDelete",
                    HeaderText = "",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    Width = 50
                };
                dgvChiTietHoaDon.Columns.Add(colDelete);
            }

            // Đảm bảo cột "Giảm" ở vị trí trước cột "Xóa"
            if (!dgvChiTietHoaDon.Columns.Contains("colReduce"))
            {
                var colReduce = new DataGridViewButtonColumn
                {
                    Name = "colReduce",
                    HeaderText = "",
                    Text = "Giảm",
                    UseColumnTextForButtonValue = true,
                    Width = 50
                };
                dgvChiTietHoaDon.Columns.Add(colReduce);
            }

            // Tính tổng tiền
            grandTotal = chiTietHoaDonList.Sum(x => x.DonGia);
            lblGrandTotal.Text = grandTotal.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chiTietHoaDonList.Count == 0)
            {
                MessageBox.Show("Hóa đơn trống! Vui lòng thêm sản phẩm.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tạo mã hóa đơn (ví dụ: HD + timestamp)
                string maHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                // Tạo hóa đơn
                var hoaDon = new HoaDon
                {
                    MaHoaDon = maHoaDon,
                    MaNguoiDung = CHTL.Models.Auth.Session.MaNguoiDung, // Lấy từ phiên đăng nhập
                    NgayBan = dtpNgayBan.Value,
                    TongTien = grandTotal
                };

                // Cập nhật MaHoaDon cho chi tiết hóa đơn
                foreach (var cthd in chiTietHoaDonList)
                {
                    cthd.MaHoaDon = maHoaDon;
                }

                bool saveReceipt = false;
                
                // Hiển thị form QR để thanh toán
                using (var formQR = new FormQRPayment(maHoaDon, grandTotal))
                {
                    saveReceipt = formQR.ShowDialog() == DialogResult.OK; // Hiển thị form QR dưới dạng modal
                }

                if (saveReceipt) {
                    // Lưu hóa đơn và cập nhật số lượng tồn
                    xuLyHoaDon.LuuHoaDon(hoaDon, chiTietHoaDonList);

                    // Thông báo thành công
                    MessageBox.Show("Lưu hóa đơn thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    UpdateChiTietHoaDon();
                }
                

                // Reset giao diện
                chiTietHoaDonList.Clear();
                LoadSanPham();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chiTietHoaDonList.Clear();
            UpdateChiTietHoaDon();
        }

        private void dgvChiTietHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvChiTietHoaDon.Columns["colDelete"].Index)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 99, 71); // Màu đỏ nhạt
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvChiTietHoaDon.Columns["colDelete"].Index)
            {
                var tenSanPham = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["colTenSanPhamCT"].Value.ToString();
                var result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {tenSanPham} khỏi hóa đơn?",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var cthd = chiTietHoaDonList[e.RowIndex];
                    chiTietHoaDonList.Remove(cthd);
                    UpdateChiTietHoaDon();
                }
            }
            else if (e.ColumnIndex == dgvChiTietHoaDon.Columns["colReduce"].Index)
            {
                var cthd = chiTietHoaDonList[e.RowIndex];
                var sanPham = truyCapSanPham.LaySanPhamTheoMa(cthd.MaSanPham);
                if (cthd.SoLuong > 1)
                {
                    cthd.SoLuong--;
                    cthd.DonGia = sanPham.GiaBan * cthd.SoLuong;
                    UpdateChiTietHoaDon();
                }
                else
                {
                    MessageBox.Show($"Số lượng đã là 1. Vui lòng sử dụng nút 'Xóa' để xóa sản phẩm {sanPham.TenSanPham}.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}