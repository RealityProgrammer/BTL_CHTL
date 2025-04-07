using System;
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
           
        }
        

        private void LoadData()
        {
            var danhSach = xuLy.LayDanhSachNguoiDung();
            dgv_nguoi_dung.DataSource = danhSach;
            dgv_nguoi_dung.Columns["MatKhau"].Visible = false;
          
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

                //Xử lý khi click vào cột "Sửa"
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
