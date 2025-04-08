using System;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;
using CHTL.BUS;
using CHTL.Models;
using System.Drawing;

namespace CHTL.GUI.SanPham
{
    public partial class FormSanPhamView : SampleView
    {
        private XuLySanPham xuLy = new XuLySanPham();

        public FormSanPhamView()
        {
            InitializeComponent();
            ConfigureDataGridView();
            LoadData();
        }

        private void ConfigureDataGridView()
        {
            //// Cấu hình kích thước và thanh cuộn
            //dgv_san_pham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Tắt AutoSize để tự điều chỉnh
            dgv_san_pham.ScrollBars = ScrollBars.Both; // Hiển thị cả thanh cuộn ngang và dọc

            // Cấu hình màu sắc cho DataGridView
            dgv_san_pham.ForeColor = Color.Black;
            dgv_san_pham.BackColor = Color.White;
            dgv_san_pham.BackgroundColor = Color.White;
            dgv_san_pham.GridColor = Color.FromArgb(128, 128, 255); // Màu đường lưới tím nhạt

            // Cấu hình màu sắc cho header
            dgv_san_pham.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 0, 64); // Xanh navy
            dgv_san_pham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_san_pham.EnableHeadersVisualStyles = false;

            // Cấu hình font chữ
            dgv_san_pham.DefaultCellStyle.Font = new Font("Segoe UI", 12F);
            dgv_san_pham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);

            // Cấu hình màu xen kẽ cho các hàng
            dgv_san_pham.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 255); // Màu tím rất nhạt cho hàng xen kẽ
            dgv_san_pham.DefaultCellStyle.BackColor = Color.White; // Màu trắng cho hàng chính

            // Cấu hình màu sắc khi chọn hàng
            dgv_san_pham.DefaultCellStyle.SelectionBackColor = Color.FromArgb(128, 128, 255); // Tím nhạt khi chọn
            dgv_san_pham.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cấu hình màu sắc cho các ô button
            dgv_san_pham.CellFormatting += dgv_san_pham_CellFormatting;
        }

        private void LoadData()
        {
            var danhSach = xuLy.LayDanhSachSanPham();
            dgv_san_pham.DataSource = danhSach;
        }

        public override void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_search.Text.Trim();
            var danhSach = xuLy.TimKiemSanPham(tuKhoa);
            dgv_san_pham.DataSource = danhSach;
        }

        public override void btn_add_Click(object sender, EventArgs e)
        {
            FormSanPhamAdd frmAdd = new FormSanPhamAdd();
            frmAdd.ShowDialog();
            LoadData();
        }

        private void dgv_san_pham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var sanPham = dgv_san_pham.Rows[e.RowIndex].DataBoundItem as CHTL.Models.SanPham;

                if (e.ColumnIndex == dgv_san_pham.Columns["colEdit"].Index)
                {
                    FormSanPhamEdit frmEdit = new FormSanPhamEdit();
                    frmEdit.SanPhamEdit = sanPham;
                    frmEdit.ShowDialog();
                    LoadData();
                }

                if (e.ColumnIndex == dgv_san_pham.Columns["colDelete"].Index)
                {
                    var result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {sanPham.TenSanPham}?",
                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            xuLy.XoaSanPham(sanPham.MaSanPham);
                            MessageBox.Show("Xóa sản phẩm thành công!", "Thành công",
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

        private void dgv_san_pham_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Cấu hình màu sắc cho các ô button
            if (e.ColumnIndex == dgv_san_pham.Columns["colEdit"].Index)
            {
                e.CellStyle.BackColor = Color.FromArgb(0, 0, 64); // Xanh navy
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
            else if (e.ColumnIndex == dgv_san_pham.Columns["colDelete"].Index)
            {
                e.CellStyle.BackColor = Color.FromArgb(255, 99, 71); // Màu đỏ nhạt (tomato)
                e.CellStyle.ForeColor = Color.White;
                e.CellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            }
        }
    }
}