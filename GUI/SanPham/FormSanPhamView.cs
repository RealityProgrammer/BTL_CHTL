using CHTL.BUS;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CHTL.GUI.SanPham {
    public partial class FormSanPhamView : KryptonForm {
        private readonly XuLySanPham xuLy = new XuLySanPham();

        public FormSanPhamView() {
            InitializeComponent();
            ConfigureDataGridView();
            LoadData();
        }

        private void ConfigureDataGridView() {
            dgv_san_pham.ScrollBars = ScrollBars.Both;
            dgv_san_pham.BackgroundColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            dgv_san_pham.BorderStyle = BorderStyle.None;
            dgv_san_pham.EnableHeadersVisualStyles = false;

            // Header
            dgv_san_pham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            dgv_san_pham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_san_pham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv_san_pham.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_san_pham.ColumnHeadersHeight = 40;

            // Hàng
            dgv_san_pham.RowsDefaultCellStyle.BackColor = Color.White;
            dgv_san_pham.RowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            dgv_san_pham.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgv_san_pham.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dgv_san_pham.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Hàng xen kẽ
            dgv_san_pham.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 250); // Xám rất nhạt

            // Lưới
            dgv_san_pham.GridColor = Color.FromArgb(189, 195, 199); // Xám nhạt
            dgv_san_pham.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // Cột
            foreach (DataGridViewColumn column in dgv_san_pham.Columns) {
                if (column.Name == "colMaSanPham") {
                    column.Width = 120;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                } else if (column.Name == "colEdit" || column.Name == "colDelete") {
                    column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                } else {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }

            dgv_san_pham.AutoGenerateColumns = false;

            // Sự kiện hover
            dgv_san_pham.CellMouseEnter += dgv_san_pham_CellMouseEnter;
            dgv_san_pham.CellMouseLeave += dgv_san_pham_CellMouseLeave;
        }

        private void dgv_san_pham_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgv_san_pham.Columns[e.ColumnIndex].Name == "colEdit") {
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(41, 128, 185); // Xanh đậm
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            } else if (dgv_san_pham.Columns[e.ColumnIndex].Name == "colDelete") {
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(192, 57, 43); // Đỏ đậm
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void dgv_san_pham_CellMouseLeave(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dgv_san_pham.Columns[e.ColumnIndex].Name == "colEdit") {
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            } else if (dgv_san_pham.Columns[e.ColumnIndex].Name == "colDelete") {
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.White;
                dgv_san_pham.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }

        private void LoadData() {
            var danhSach = xuLy.LayDanhSachSanPham();
            dgv_san_pham.DataSource = danhSach;
        }

        public void txt_search_TextChanged(object sender, EventArgs e) {
            dgv_san_pham.DataSource = xuLy.TimKiemSanPham(txt_search.Text.Trim());
        }

        public void btn_add_Click(object sender, EventArgs e) {
            var frmAdd = new FormSanPhamAdd();
            frmAdd.ShowDialog();
            LoadData();
        }

        private void dgv_san_pham_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                var sanPham = dgv_san_pham.Rows[e.RowIndex].DataBoundItem as Models.SanPham;

                if (e.ColumnIndex == dgv_san_pham.Columns["colEdit"].Index) {
                    var frmEdit = new FormSanPhamEdit();
                    frmEdit.SanPhamEdit = sanPham;

                    if (frmEdit.ShowDialog() == DialogResult.OK) {
                        LoadData();
                    }
                }

                if (e.ColumnIndex == dgv_san_pham.Columns["colDelete"].Index) {
                    DialogResult result = KryptonMessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {sanPham.TenSanPham}?",
                        "Xác nhận", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question);

                    if (result == DialogResult.Yes) {
                        try {
                            xuLy.XoaSanPham(sanPham.MaSanPham);
                            KryptonMessageBox.Show("Xóa sản phẩm thành công!", "Thành công",
                                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                            LoadData();
                        } catch (Exception ex) {
                            KryptonMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}