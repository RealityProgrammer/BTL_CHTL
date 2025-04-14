using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CHTL.BUS;
using CHTL.DAL;
using CHTL.GUI.Sample_Form;
using CHTL.Models;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucView : SampleView
    {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        public FormDanhMucView()
        {
            InitializeComponent();
            LoadData();
            CustomizeDataGridView(); // Gọi phương thức tùy chỉnh giao diện
        }

        private void LoadData()
        {
            var danhSach = xuLy.LayDanhSachDanhMuc();
            dgvDanhMuc.DataSource = danhSach;
        }

        // Phương thức tùy chỉnh giao diện DataGridView
        private void CustomizeDataGridView()
        {
            // Tùy chỉnh màu nền và viền
            dgvDanhMuc.BackgroundColor = Color.FromArgb(245, 245, 245); // Màu nền sáng
            dgvDanhMuc.BorderStyle = BorderStyle.None; // Bỏ viền mặc định
            dgvDanhMuc.EnableHeadersVisualStyles = false; // Tắt kiểu mặc định của header

            // Tùy chỉnh header
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(46, 204, 113); // Màu xanh lá
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Chữ trắng
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chỉnh hàng
            dgvDanhMuc.RowsDefaultCellStyle.BackColor = Color.White; // Màu nền hàng
            dgvDanhMuc.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64); // Màu chữ xanh navy
            dgvDanhMuc.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dgvDanhMuc.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Màu chọn xanh dương
            dgvDanhMuc.RowsDefaultCellStyle.SelectionForeColor = Color.White; // Chữ trắng khi chọn

            // Tùy chỉnh hàng xen kẽ
            dgvDanhMuc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250); // Màu nền xen kẽ
            var columnsCopy = dgvDanhMuc.Columns.Cast<DataGridViewColumn>().ToList();
            // Tùy chỉnh cột "Sửa" và "Xóa"
            foreach (DataGridViewColumn column in columnsCopy)
            {
                if (column.Name == "colEdit" || column.Name == "colDelete")
                {
                    column.DefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Màu nền nút xanh dương
                    column.DefaultCellStyle.ForeColor = Color.White; // Chữ trắng
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    column.Width = 50; // Đặt chiều rộng cố định cho cột nút
                }
            }

            // Tùy chỉnh cột dữ liệu
            foreach (DataGridViewColumn column in columnsCopy)
            {
                if (column.Name != "colEdit" && column.Name != "colDelete")
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft; // Căn trái cho dữ liệu
                }
            }

            // Tùy chỉnh đường lưới
            dgvDanhMuc.GridColor = Color.FromArgb(200, 200, 200); // Màu lưới nhạt
            dgvDanhMuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Chỉ hiển thị đường ngang
        }

        // Hiệu ứng hover cho nút "Sửa" và "Xóa"
        private void dgv_danh_muc_CellMouseEnter(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDanhMuc.Rows.Count) return;
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvDanhMuc.Columns.Count) return;
            
            if (dgvDanhMuc.Columns[e.ColumnIndex].Name == "colEdit" || dgvDanhMuc.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(41, 128, 185); // Màu xanh đậm hơn khi hover
            }
        }

        private void dgv_danh_muc_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvDanhMuc.Rows.Count) return;
            if (e.ColumnIndex < 0 || e.ColumnIndex >= dgvDanhMuc.Columns.Count) return;
            
            if (dgvDanhMuc.Columns[e.ColumnIndex].Name == "colEdit" || dgvDanhMuc.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(52, 152, 219); // Màu gốc
            }
        }

        public override void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_search.Text.Trim();
            var danhSach = xuLy.TimKiemDanhMuc(tuKhoa);
            dgvDanhMuc.DataSource = danhSach;
        }

        public override void btn_add_Click(object sender, EventArgs e)
        {
            FormDanhMucAdd frmAdd = new FormDanhMucAdd();
            frmAdd.ShowDialog();
            LoadData();
        }

        private void dgv_danh_muc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var danhMuc = dgvDanhMuc.Rows[e.RowIndex].DataBoundItem as DanhMucSanPham;

                // Xử lý khi click vào cột "Sửa"
                if (e.ColumnIndex == dgvDanhMuc.Columns["colEdit"].Index)
                {
                    FormDanhMucEdit frmEdit = new FormDanhMucEdit();
                    frmEdit.DanhMucEdit = danhMuc;
                    frmEdit.ShowDialog();
                    LoadData();
                }

                // Xử lý khi click vào cột "Xóa"
                if (e.ColumnIndex == dgvDanhMuc.Columns["colDelete"].Index)
                {
                    var result = MessageBox.Show($"Bạn có chắc muốn xóa danh mục {danhMuc.TenDanhMuc}?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            xuLy.XoaDanhMuc(danhMuc.MaDanhMuc);
                            MessageBox.Show("Xóa danh mục thành công!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}