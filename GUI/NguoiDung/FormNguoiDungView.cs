﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;
using CHTL.BUS;

namespace CHTL.GUI.NguoiDung
{
    public partial class FormNguoiDungView : SampleView
    {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();
        public FormNguoiDungView()
        {
            
            
            InitializeComponent();
            LoadData();
            CustomizeDataGridView(); // Gọi phương thức tùy chỉnh giao diện
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
            dgv_nguoi_dung.BackgroundColor = Color.FromArgb(245, 245, 245); // Màu nền sáng
            dgv_nguoi_dung.BorderStyle = BorderStyle.Fixed3D; // Bỏ viền mặc định
            dgv_nguoi_dung.EnableHeadersVisualStyles = false; // Tắt kiểu mặc định của header

            // Tùy chỉnh header
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64); // Navy
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Chữ trắng
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgv_nguoi_dung.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chỉnh hàng
            dgv_nguoi_dung.RowsDefaultCellStyle.BackColor = Color.White; // Màu nền hàng
            dgv_nguoi_dung.RowsDefaultCellStyle.ForeColor = Color.FromArgb(0, 0, 64); // Màu chữ xanh navy
            dgv_nguoi_dung.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);
            dgv_nguoi_dung.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219); // Màu chọn xanh dương
            dgv_nguoi_dung.RowsDefaultCellStyle.SelectionForeColor = Color.White; // Chữ trắng khi chọn

            // Tùy chỉnh hàng xen kẽ
            dgv_nguoi_dung.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(230, 230, 250); // Màu nền xen kẽ

            // Tùy chỉnh cột "Sửa" và "Xóa"
            foreach (DataGridViewColumn column in dgv_nguoi_dung.Columns)
            {
                if (column.Name == "colEdit" || column.Name == "colDelete")
                {
                    column.DefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Màu nền nút xanh dương
                    column.DefaultCellStyle.ForeColor = Color.White; // Chữ trắng
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                }
            }

            // Tắt đường lưới
            dgv_nguoi_dung.GridColor = Color.FromArgb(200, 200, 200); // Màu lưới nhạt
            dgv_nguoi_dung.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Chỉ hiển thị đường ngang
        }

        public override void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_search.Text.Trim();
            var danhSach = xuLy.TimKiemNguoiDung(tuKhoa);
            dgv_nguoi_dung.DataSource = danhSach;
            dgv_nguoi_dung.Columns["MatKhau"].Visible = false;
        }

        public override void btn_add_Click(object sender, EventArgs e)
        {
            FormNguoiDungAdd frmNguoiDungAdd = new FormNguoiDungAdd();
            frmNguoiDungAdd.ShowDialog();
            LoadData(); // Refresh danh sách sau khi thêm
        }

        private void dgv_nguoi_dung_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    frmEdit.ShowDialog();
                    LoadData(); // Refresh danh sách sau khi sửa
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

        private void FormNguoiDungView_Load(object sender, EventArgs e)
        {
        }
    }
}