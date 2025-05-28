using CHTL.BUS;
using CHTL.DAL;
using CHTL.GUI.Controls;
using CHTL.Models;
using CHTL.Models.Auth;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CHTL.GUI.BanHang {
    public partial class FormBanHangView : KryptonForm {
        private readonly TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();
        private readonly List<ChiTietHoaDon> chiTietHoaDonList = new List<ChiTietHoaDon>();
        private readonly TruyCapSanPham truyCapSanPham = new TruyCapSanPham();
        private readonly XuLyHoaDon xuLyHoaDon = new XuLyHoaDon();
        private readonly XuLySanPham xuLySanPham = new XuLySanPham();
        private decimal grandTotal;

        private bool productsMode = false;
        private DanhMucSanPham selectedCategory;

        public FormBanHangView() {
            InitializeComponent();
            ConfigureDataGridView();
            LoadDanhMuc(truyCapDanhMuc.LayDanhSachDanhMuc());
            dtpNgayBan.Value = DateTime.Now;
        }

        private void ConfigureDataGridView() {
            dgvChiTietHoaDon.ScrollBars = ScrollBars.Both;
            dgvChiTietHoaDon.AutoGenerateColumns = false;
            dgvChiTietHoaDon.BackgroundColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            dgvChiTietHoaDon.BorderStyle = BorderStyle.None;
            dgvChiTietHoaDon.EnableHeadersVisualStyles = false;

            // Header
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvChiTietHoaDon.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvChiTietHoaDon.ColumnHeadersHeight = 40;

            // Hàng
            dgvChiTietHoaDon.RowsDefaultCellStyle.BackColor = Color.White;
            dgvChiTietHoaDon.RowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            dgvChiTietHoaDon.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvChiTietHoaDon.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dgvChiTietHoaDon.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Hàng xen kẽ
            dgvChiTietHoaDon.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 250); // Xám rất nhạt

            // Lưới
            dgvChiTietHoaDon.GridColor = Color.FromArgb(189, 195, 199); // Xám nhạt
            dgvChiTietHoaDon.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Cột
            foreach (DataGridViewColumn column in dgvChiTietHoaDon.Columns) {
                if (column.Name == "colTenSanPhamCT") {
                    column.Width = 150;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                } else if (column.Name == "colReduce" || column.Name == "colDelete") {
                    column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                } else {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void LoadDanhMuc(IReadOnlyList<DanhMucSanPham> danhSach) {
            productsMode = false;
            selectedCategory = null;

            panelContentLeft.Controls.Clear();

            PanelDanhSachDanhMuc panel = new PanelDanhSachDanhMuc {
                DanhSachDanhMuc = danhSach,
                Dock = DockStyle.Fill,
            };
            panel.DanhMucClick += ButtonDanhMucClick;

            panelContentLeft.Controls.Add(panel);
        }

        private void ButtonDanhMucClick(object sender, EventArgs e) {
            DanhMucSanPham danhMuc = ((Control)sender).Parent.Tag as DanhMucSanPham;

            if (danhMuc == null) {
                LoadSanPham("Tất cả", xuLySanPham.LayDanhSachSanPham());
            } else {
                LoadSanPham($"{danhMuc.TenDanhMuc} ({danhMuc.MaDanhMuc})", xuLySanPham.LayDanhSachSanPham(danhMuc.MaDanhMuc));
            }

            selectedCategory = danhMuc;

            txtSearch.Clear();
        }

        private void LoadSanPham(string displayCategoryName, IReadOnlyCollection<Models.SanPham> products) {
            productsMode = true;
            panelContentLeft.Controls.Clear();

            PanelSanPhamBanHang panel;

            panel = new PanelSanPhamBanHang {
                DanhSachSanPham = products,
                TenDanhMuc = displayCategoryName,
                Dock = DockStyle.Fill,
            };

            panel.ThemSanPhamClick += BtnThem_Click;
            panel.ButtonQuayLai.Click += (_, __) => {
                txtSearch.Clear();
                LoadDanhMuc(truyCapDanhMuc.LayDanhSachDanhMuc());
            };

            panelContentLeft.Controls.Add(panel);
        }

        private void BtnThem_Click(object sender, EventArgs e) {
            // SanPhamBanHang
            // ╚═══ KryptonTableLayoutPanel
            //      ╚═══ KryptonButton (= sender)

            if (!(((sender as KryptonButton)?.Parent as KryptonTableLayoutPanel)?.Parent is SanPhamBanHang spbh)) return;

            Models.SanPham sanPham = spbh.SanPham;

            if (sanPham.SoLuongTon <= 0) {
                KryptonMessageBox.Show($"Sản phẩm {sanPham.TenSanPham} đã hết hàng!", "Thông báo",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            ChiTietHoaDon existingItem = chiTietHoaDonList.FirstOrDefault(x => x.MaSanPham == sanPham.MaSanPham);

            if (existingItem != null) {
                existingItem.SoLuong++;

                if (existingItem.SoLuong > sanPham.SoLuongTon) {
                    KryptonMessageBox.Show($"Sản phẩm {sanPham.TenSanPham} không đủ số lượng tồn (còn {sanPham.SoLuongTon})!",
                        "Thông báo", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                    existingItem.SoLuong--;
                    return;
                }
                //existingItem.DonGia = sanPham.GiaBan * existingItem.SoLuong;
            } else {
                var cthd = new ChiTietHoaDon {
                    MaChiTiet = Guid.NewGuid().ToString(),
                    MaHoaDon = "",
                    MaSanPham = sanPham.MaSanPham,
                    SoLuong = 1,
                    DonGia = sanPham.GiaBan,
                };
                chiTietHoaDonList.Add(cthd);
            }

            UpdateChiTietHoaDon();
        }

        private void UpdateChiTietHoaDon() {
            var displayList = chiTietHoaDonList.Select(cthd => {
                Models.SanPham sp = truyCapSanPham.LaySanPhamTheoMa(cthd.MaSanPham);
                return new {
                    sp?.TenSanPham,
                    cthd.SoLuong,
                    sp?.GiaBan,
                    ThanhTien = cthd.DonGia * cthd.SoLuong,
                };
            }).ToList();
            dgvChiTietHoaDon.DataSource = displayList;

            grandTotal = chiTietHoaDonList.Sum(x => x.DonGia * x.SoLuong);
            lblGrandTotal.Text = grandTotal.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e) {
            if (chiTietHoaDonList.Count == 0) {
                KryptonMessageBox.Show("Hóa đơn trống! Vui lòng thêm sản phẩm.", "Thông báo",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            try {

                string maHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                var hoaDon = new HoaDon {
                    MaHoaDon = maHoaDon,
                    MaNguoiDung = Session.MaNguoiDung,
                    NgayBan = dtpNgayBan.Value,
                    TongTien = grandTotal,
                };

                foreach (ChiTietHoaDon cthd in chiTietHoaDonList) {
                    cthd.MaHoaDon = maHoaDon;
                }

                var form = new FormPhuongThucThanhToan(maHoaDon, grandTotal);
                DialogResult result = form.ShowDialog();

                if (result == DialogResult.OK) {
                    if (form.PaymentForm.ShowDialog() == DialogResult.OK) {
                        xuLyHoaDon.LuuHoaDon(hoaDon, chiTietHoaDonList);

                        KryptonMessageBox.Show("Lưu hóa đơn thành công!", "Thành công",
                            KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                        chiTietHoaDonList.Clear();
                        UpdateChiTietHoaDon();
                        // LoadSanPham();
                    }
                }
            } catch (Exception ex) {
                KryptonMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e) {
            chiTietHoaDonList.Clear();
            UpdateChiTietHoaDon();
        }

        private void btnLamMoi_Click(object sender, EventArgs e) {
            chiTietHoaDonList.Clear();
            UpdateChiTietHoaDon();
            txtSearch.Clear();
            txtSearch.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
            dtpNgayBan.Value = DateTime.Now;
            // LoadSanPham();
        }

        private void dgvChiTietHoaDon_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colReduce") {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(230, 126, 34); // Cam đậm
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            } else if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colDelete") {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(192, 57, 43); // Đỏ đậm
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgvChiTietHoaDon_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colReduce") {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(243, 156, 18); // Cam nhạt
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            } else if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colDelete") {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                if (e.ColumnIndex == dgvChiTietHoaDon.Columns["colDelete"].Index) {
                    string tenSanPham = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["colTenSanPhamCT"].Value.ToString();
                    DialogResult result = KryptonMessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {tenSanPham} khỏi hóa đơn?",
                        "Xác nhận", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question);

                    if (result == DialogResult.Yes) {
                        ChiTietHoaDon cthd = chiTietHoaDonList[e.RowIndex];
                        chiTietHoaDonList.Remove(cthd);
                        UpdateChiTietHoaDon();
                    }
                } else if (e.ColumnIndex == dgvChiTietHoaDon.Columns["colReduce"].Index) {
                    ChiTietHoaDon cthd = chiTietHoaDonList[e.RowIndex];
                    Models.SanPham sanPham = truyCapSanPham.LaySanPhamTheoMa(cthd.MaSanPham);

                    if (cthd.SoLuong > 1) {
                        cthd.SoLuong--;
                        //cthd.DonGia = sanPham.GiaBan * cthd.SoLuong;
                        UpdateChiTietHoaDon();
                    } else {
                        KryptonMessageBox.Show($"Số lượng đã là 1. Vui lòng sử dụng nút 'Xóa' để xóa sản phẩm {sanPham.TenSanPham}.",
                            "Thông báo", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (productsMode) {
                // Tìm kiếm sản phẩm
                if (selectedCategory == null) {
                    LoadSanPham("Tất cả", xuLySanPham.LayDanhSachSanPham());
                } else {
                    LoadSanPham($"{selectedCategory.TenDanhMuc} ({selectedCategory.MaDanhMuc})", xuLySanPham.LayDanhSachSanPham(selectedCategory.MaDanhMuc));
                }
            } else {
                // Tìm kiếm danh mục
                LoadDanhMuc(truyCapDanhMuc.TimKiemDanhMuc(txtSearch.Text));
            }
        }
    }
}