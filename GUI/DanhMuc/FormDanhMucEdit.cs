using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using CHTL.BUS;
using CHTL.GUI.Sample_Form;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucEdit : SampleEdit
    {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        private CHTL.Models.DanhMucSanPham danhMucEdit;
        public CHTL.Models.DanhMucSanPham DanhMucEdit
        {
            get { return danhMucEdit; }
            set
            {
                danhMucEdit = value;
                LoadDataToForm(); // Hiển thị dữ liệu lên form khi nhận được đối tượng
            }
        }
        public FormDanhMucEdit()
        {
            InitializeComponent();
        }
        private void LoadDataToForm()
        {
            if (danhMucEdit != null)
            {
                txt_ma_danh_muc.Text = danhMucEdit.MaDanhMuc;
                txt_ten_danh_muc.Text = danhMucEdit.TenDanhMuc;
               
            }
        }
        public override void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_ma_danh_muc.Text))
                {
                    MessageBox.Show("Mã danh mục không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ten_danh_muc.Text))
                {
                    MessageBox.Show("Tên danh mục không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               

                // Cập nhật thông tin danh muc
                danhMucEdit.MaDanhMuc = txt_ma_danh_muc.Text.Trim();
                danhMucEdit.TenDanhMuc = txt_ten_danh_muc.Text.Trim();
            
               

                // Gọi phương thức sửa danh muc
                xuLy.SuaDanhMuc(danhMucEdit);

                // Thông báo thành công
                MessageBox.Show("Cập nhật danh muc thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
