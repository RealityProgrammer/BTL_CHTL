using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.BUS;
using CHTL.GUI.Sample_Form;
using CHTL.Models;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucView : SampleView
    {
        private CHTL.BUS.XuLyDanhMuc xuLy = new XuLyDanhMuc();
        public FormDanhMucView()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            var danhSach = xuLy.LayDanhSachDanhMuc();
            dgv_danh_muc.DataSource = danhSach;
        }
        public override void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_search.Text.Trim();
            var danhSach = xuLy.TimKiemDanhMuc(tuKhoa);
            dgv_danh_muc.DataSource = danhSach;
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
                var danhMuc = dgv_danh_muc.Rows[e.RowIndex].DataBoundItem as DanhMucSanPham;

                // Xử lý khi click vào cột "Sửa"
                if (e.ColumnIndex == dgv_danh_muc.Columns["colEdit"].Index)
                {
                    //FormDanhMucEdit frmEdit = new FormDanhMucEdit();
                    //frmEdit.DanhMucEdit = danhMuc;
                    //frmEdit.ShowDialog();
                    //LoadData();
                }

                // Xử lý khi click vào cột "Xóa"
                if (e.ColumnIndex == dgv_danh_muc.Columns["colDelete"].Index)
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
