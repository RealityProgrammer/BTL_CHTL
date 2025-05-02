using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            SetupSearchBox();
            SetupButtonHover();
        }

        private void ConfigureDataGridView()
        {
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
            foreach (DataGridViewColumn column in dgvChiTietHoaDon.Columns)
            {
                if (column.Name == "colTenSanPhamCT")
                {
                    column.Width = 150;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else if (column.Name == "colReduce" || column.Name == "colDelete")
                {
                    column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }
        }

        private void LoadSanPham()
        {
            flpSanPham.Controls.Clear();
            var danhSach = xuLySanPham.LayDanhSachSanPham();
            foreach (var sp in danhSach)
            {
                var panel = new Panel
                {
                    Size = new Size(180, 140),
                    BackColor = Color.White,
                    Margin = new Padding(10)
                };
                panel.MouseEnter += (s, e) => panel.BackColor = Color.FromArgb(234, 242, 251); // Xanh nhạt  
                panel.MouseLeave += (s, e) => panel.BackColor = Color.White;

                var lblTen = new Label
                {
                    Text = sp.TenSanPham,
                    Location = new Point(10, 10),
                    Size = new Size(160, 40),
                    Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                    ForeColor = Color.FromArgb(44, 62, 80) // Xám đậm  
                };

                var lblGia = new Label
                {
                    Text = $"Giá: {sp.GiaBan:N2}",
                    Location = new Point(10, 50),
                    Size = new Size(160, 20),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(127, 140, 141) // Xám trung  
                };

                var lblTon = new Label
                {
                    Text = $"Tồn: {sp.SoLuongTon}",
                    Location = new Point(10, 70),
                    Size = new Size(160, 20),
                    Font = new Font("Segoe UI", 9F),
                    ForeColor = Color.FromArgb(127, 140, 141)
                };

                var btnThem = new KryptonButton
                {
                    Text = "Thêm",
                    Location = new Point(10, 95),
                    Size = new Size(160, 35)
                };
                btnThem.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương  
                btnThem.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
                btnThem.StateCommon.Content.ShortText.Color1 = Color.White;
                btnThem.StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                btnThem.Tag = sp;
                btnThem.MouseEnter += (s, e) =>
                {
                    btnThem.StateCommon.Back.Color1 = Color.FromArgb(41, 128, 185); // Xanh đậm  
                    btnThem.StateCommon.Back.Color2 = Color.FromArgb(41, 128, 185);
                };
                btnThem.MouseLeave += (s, e) =>
                {
                    btnThem.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
                    btnThem.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
                };
                btnThem.Click += BtnThem_Click;

                panel.Controls.Add(lblTen);
                panel.Controls.Add(lblGia);
                panel.Controls.Add(lblTon);
                panel.Controls.Add(btnThem);
                flpSanPham.Controls.Add(panel);
            }
        }

        private void SetupSearchBox()
        {
            txtSearch.Text = "Tìm kiếm sản phẩm...";
            txtSearch.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166); // Xám nhạt
            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.Text == "Tìm kiếm sản phẩm...")
                {
                    txtSearch.Text = "";
                    txtSearch.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                    txtSearch.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219); // Viền xanh dương
                }
            };
            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = "Tìm kiếm sản phẩm...";
                    txtSearch.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
                    txtSearch.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Viền xám nhạt
                }
            };
            txtSearch.TextChanged += (s, e) =>
            {
                string tuKhoa = txtSearch.Text.Trim();
                if (tuKhoa == "Tìm kiếm sản phẩm...") tuKhoa = "";
                var danhSach = xuLySanPham.TimKiemSanPham(tuKhoa);
                flpSanPham.Controls.Clear();
                foreach (var sp in danhSach)
                {
                    var panel = new Panel
                    {
                        Size = new Size(180, 140),
                        BackColor = Color.White,
                        Margin = new Padding(10)
                    };
                    panel.MouseEnter += (s2, e2) => panel.BackColor = Color.FromArgb(234, 242, 251);
                    panel.MouseLeave += (s2, e2) => panel.BackColor = Color.White;

                    var lblTen = new Label
                    {
                        Text = sp.TenSanPham,
                        Location = new Point(10, 10),
                        Size = new Size(160, 40),
                        Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                        ForeColor = Color.FromArgb(44, 62, 80)
                    };

                    var lblGia = new Label
                    {
                        Text = $"Giá: {sp.GiaBan:N2}",
                        Location = new Point(10, 50),
                        Size = new Size(160, 20),
                        Font = new Font("Segoe UI", 9F),
                        ForeColor = Color.FromArgb(127, 140, 141)
                    };

                    var lblTon = new Label
                    {
                        Text = $"Tồn: {sp.SoLuongTon}",
                        Location = new Point(10, 70),
                        Size = new Size(160, 20),
                        Font = new Font("Segoe UI", 9F),
                        ForeColor = Color.FromArgb(127, 140, 141)
                    };

                    var btnThem = new KryptonButton
                    {
                        Text = "Thêm",
                        Location = new Point(10, 95),
                        Size = new Size(160, 35),
                        //StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219),
                        //StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219),
                        //StateCommon.Content.ShortText.Color1 = Color.White,
                        //StateCommon.Content.ShortText.Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        Tag = sp
                    };
                    btnThem.MouseEnter += (s2, e2) =>
                    {
                        btnThem.StateCommon.Back.Color1 = Color.FromArgb(41, 128, 185);
                        btnThem.StateCommon.Back.Color2 = Color.FromArgb(41, 128, 185);
                    };
                    btnThem.MouseLeave += (s2, e2) =>
                    {
                        btnThem.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219);
                        btnThem.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
                    };
                    btnThem.Click += BtnThem_Click;

                    panel.Controls.Add(lblTen);
                    panel.Controls.Add(lblGia);
                    panel.Controls.Add(lblTon);
                    panel.Controls.Add(btnThem);
                    flpSanPham.Controls.Add(panel);
                }
            };
        }

        private void SetupButtonHover()
        {
            btnSave.MouseEnter += (s, e) =>
            {
                btnSave.StateCommon.Back.Color1 = Color.FromArgb(41, 128, 185); // Xanh đậm
                btnSave.StateCommon.Back.Color2 = Color.FromArgb(41, 128, 185);
            };
            btnSave.MouseLeave += (s, e) =>
            {
                btnSave.StateCommon.Back.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
                btnSave.StateCommon.Back.Color2 = Color.FromArgb(52, 152, 219);
            };

            btnClear.MouseEnter += (s, e) =>
            {
                btnClear.StateCommon.Back.Color1 = Color.FromArgb(192, 57, 43); // Đỏ đậm
                btnClear.StateCommon.Back.Color2 = Color.FromArgb(192, 57, 43);
            };
            btnClear.MouseLeave += (s, e) =>
            {
                btnClear.StateCommon.Back.Color1 = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                btnClear.StateCommon.Back.Color2 = Color.FromArgb(231, 76, 60);
            };

            btnAddNew.MouseEnter += (s, e) =>
            {
                btnAddNew.StateCommon.Back.Color1 = Color.FromArgb(149, 165, 166); // Xám đậm
                btnAddNew.StateCommon.Back.Color2 = Color.FromArgb(149, 165, 166);
            };
            btnAddNew.MouseLeave += (s, e) =>
            {
                btnAddNew.StateCommon.Back.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
                btnAddNew.StateCommon.Back.Color2 = Color.FromArgb(189, 195, 199);
            };
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            var btn = sender as KryptonButton;
            var sanPham = btn.Tag as CHTL.Models.SanPham;
            if (sanPham != null)
            {
                if (sanPham.SoLuongTon <= 0)
                {
                    KryptonMessageBox.Show($"Sản phẩm {sanPham.TenSanPham} đã hết hàng!", "Thông báo",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                    return;
                }

                var existingItem = chiTietHoaDonList.FirstOrDefault(x => x.MaSanPham == sanPham.MaSanPham);
                if (existingItem != null)
                {
                    existingItem.SoLuong++;
                    if (existingItem.SoLuong > sanPham.SoLuongTon)
                    {
                        KryptonMessageBox.Show($"Sản phẩm {sanPham.TenSanPham} không đủ số lượng tồn (còn {sanPham.SoLuongTon})!",
                            "Thông báo", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                        existingItem.SoLuong--;
                        return;
                    }
                    existingItem.DonGia = sanPham.GiaBan * existingItem.SoLuong;
                }
                else
                {
                    var cthd = new ChiTietHoaDon
                    {
                        MaChiTiet = Guid.NewGuid().ToString(),
                        MaHoaDon = "",
                        MaSanPham = sanPham.MaSanPham,
                        SoLuong = 1,
                        DonGia = sanPham.GiaBan
                    };
                    chiTietHoaDonList.Add(cthd);
                }

                UpdateChiTietHoaDon();
            }
        }

        private void UpdateChiTietHoaDon()
        {
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
            dgvChiTietHoaDon.DataSource = displayList;

            if (!dgvChiTietHoaDon.Columns.Contains("colReduce"))
            {
                var colReduce = new DataGridViewButtonColumn
                {
                    Name = "colReduce",
                    HeaderText = "",
                    Text = "Giảm",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dgvChiTietHoaDon.Columns.Add(colReduce);
            }

            if (!dgvChiTietHoaDon.Columns.Contains("colDelete"))
            {
                var colDelete = new DataGridViewButtonColumn
                {
                    Name = "colDelete",
                    HeaderText = "",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                    Width = 80
                };
                dgvChiTietHoaDon.Columns.Add(colDelete);
            }

            grandTotal = chiTietHoaDonList.Sum(x => x.DonGia);
            lblGrandTotal.Text = grandTotal.ToString("N2");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chiTietHoaDonList.Count == 0)
            {
                KryptonMessageBox.Show("Hóa đơn trống! Vui lòng thêm sản phẩm.", "Thông báo",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Warning);
                return;
            }

            try
            {
                string maHoaDon = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");

                var hoaDon = new HoaDon
                {
                    MaHoaDon = maHoaDon,
                    MaNguoiDung = CHTL.Models.Auth.Session.MaNguoiDung,
                    NgayBan = dtpNgayBan.Value,
                    TongTien = grandTotal
                };

                foreach (var cthd in chiTietHoaDonList)
                {
                    cthd.MaHoaDon = maHoaDon;
                }

                if (new FormThanhToanQR(maHoaDon, grandTotal).ShowDialog() == DialogResult.OK)
                {
                    xuLyHoaDon.LuuHoaDon(hoaDon, chiTietHoaDonList);

                    KryptonMessageBox.Show("Lưu hóa đơn thành công!", "Thành công",
                        KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);

                    chiTietHoaDonList.Clear();
                    UpdateChiTietHoaDon();
                    LoadSanPham();
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chiTietHoaDonList.Clear();
            UpdateChiTietHoaDon();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            chiTietHoaDonList.Clear();
            UpdateChiTietHoaDon();
            txtSearch.Text = "Tìm kiếm sản phẩm...";
            txtSearch.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
            dtpNgayBan.Value = DateTime.Now;
            LoadSanPham();
        }

        private void dgvChiTietHoaDon_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colReduce")
            {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(230, 126, 34); // Cam đậm
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(192, 57, 43); // Đỏ đậm
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgvChiTietHoaDon_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colReduce")
            {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(243, 156, 18); // Cam nhạt
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else if (dgvChiTietHoaDon.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgvChiTietHoaDon.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgvChiTietHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == dgvChiTietHoaDon.Columns["colDelete"].Index)
                {
                    var tenSanPham = dgvChiTietHoaDon.Rows[e.RowIndex].Cells["colTenSanPhamCT"].Value.ToString();
                    var result = KryptonMessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {tenSanPham} khỏi hóa đơn?",
                        "Xác nhận", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question);

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
                        KryptonMessageBox.Show($"Số lượng đã là 1. Vui lòng sử dụng nút 'Xóa' để xóa sản phẩm {sanPham.TenSanPham}.",
                            "Thông báo", KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}