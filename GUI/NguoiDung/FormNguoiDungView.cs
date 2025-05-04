using CHTL.BUS;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CHTL.GUI.NguoiDung {
    public partial class FormNguoiDungView : KryptonForm {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();
        public FormNguoiDungView()
        {
            InitializeComponent();
            LoadData();
            CustomizeDataGridView(); // Gọi phương thức tùy chỉnh giao diện

            // Thêm hiệu ứng hover cho btn_add
            btn_add.BackColor = Color.FromArgb(243, 156, 18); // Cam
            btn_add.MouseEnter += (s, e) => btn_add.BackColor = Color.FromArgb(230, 126, 34); // Cam đậm hơn
            btn_add.MouseLeave += (s, e) => btn_add.BackColor = Color.FromArgb(243, 156, 18); // Quay lại cam
        }

        private void LoadData()
        {
            var danhSach = xuLy.LayDanhSachNguoiDung();
            dgv_nguoi_dung.DataSource = danhSach;
            dgv_nguoi_dung.Columns["MatKhau"].Visible = false;
        }

        // Phương thức tùy chỉnh giao diện DataGridView
        private void CustomizeDataGridView()
        {
            // Tùy chỉnh màu nền và viền
            dgv_nguoi_dung.BackgroundColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            dgv_nguoi_dung.BorderStyle = BorderStyle.Fixed3D; // Bỏ viền mặc định
            dgv_nguoi_dung.EnableHeadersVisualStyles = false; // Tắt kiểu mặc định của header

            // Tùy chỉnh header
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Chữ trắng
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chỉnh hàng
            dgv_nguoi_dung.RowsDefaultCellStyle.BackColor = Color.White; // Màu nền hàng
            dgv_nguoi_dung.RowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            dgv_nguoi_dung.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dgv_nguoi_dung.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113);
            dgv_nguoi_dung.RowsDefaultCellStyle.SelectionForeColor = Color.White; // Chữ trắng khi chọn

            // Tùy chỉnh hàng xen kẽ
            dgv_nguoi_dung.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Màu nền xen kẽ

            // Tùy chỉnh cột "Sửa" và "Xóa"
            foreach (DataGridViewColumn column in dgv_nguoi_dung.Columns)
            {
                if (column.Name == "colEdit")
                {
                    column.DefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
                    column.DefaultCellStyle.ForeColor = Color.White;
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
                if (column.Name == "colDelete")
                {
                    column.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60); // Đỏ
                    column.DefaultCellStyle.ForeColor = Color.White;
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
            }

            // Tùy chỉnh lưới
            dgv_nguoi_dung.GridColor = Color.FromArgb(189, 195, 199); // Xám nhạt
            dgv_nguoi_dung.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        public void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_search.Text.Trim();
            var danhSach = xuLy.TimKiemNguoiDung(tuKhoa);
            dgv_nguoi_dung.DataSource = danhSach;
            dgv_nguoi_dung.Columns["MatKhau"].Visible = false;
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            NguoiDung.FormNguoiDungAdd frmNguoiDungAdd = new NguoiDung.FormNguoiDungAdd();

            if (frmNguoiDungAdd.ShowDialog() == DialogResult.OK) {
                LoadData(); // Refresh danh sách sau khi thêm
            }
        }

        private void kryptonDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu click vào hàng hợp lệ
            if (e.RowIndex >= 0)
            {
                var nguoiDung = dgv_nguoi_dung.Rows[e.RowIndex].DataBoundItem as CHTL.Models.NguoiDung;

                // Xử lý khi click vào cột "Sửa"
                if (e.ColumnIndex == dgv_nguoi_dung.Columns["colEdit"].Index)
                {
                    FormNguoiDungEdit frmEdit = new FormNguoiDungEdit();
                    frmEdit.NguoiDungEdit = nguoiDung; // Truyền đối tượng người dùng để chỉnh sửa

                    if (frmEdit.ShowDialog() == DialogResult.OK) {
                        LoadData(); // Refresh danh sách sau khi sửa
                    }
                }

                // Xử lý khi click vào cột "Xóa"
                if (e.ColumnIndex == dgv_nguoi_dung.Columns["colDelete"].Index)
                {
                    var result = MessageBox.Show($"Bạn có chắc muốn xóa người dùng {nguoiDung.HoTen}?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            xuLy.XoaNguoiDung(nguoiDung.MaNguoiDung);
                            MessageBox.Show("Xóa người dùng thành công!", "Thành công",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadData(); // Refresh danh sách sau khi xóa
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