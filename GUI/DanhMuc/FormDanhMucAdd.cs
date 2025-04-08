using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using CHTL.BUS;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucAdd : SampleAdd
    {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        public FormDanhMucAdd()
        {
            InitializeComponent();
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_ma_danh_muc.Text))
                {
                    MessageBox.Show("Mã người dùng không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ten_danh_muc.Text))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Tạo đối tượng NguoiDung từ dữ liệu nhập
                CHTL.Models.DanhMucSanPham dm = new CHTL.Models.DanhMucSanPham()
                {
                    MaDanhMuc = txt_ma_danh_muc.Text.Trim(),
                    TenDanhMuc = txt_ten_danh_muc.Text.Trim()  
                };

                // Gọi phương thức thêm người dùng
                xuLy.ThemDanhMuc(dm);

                // Thông báo thành công
                MessageBox.Show("Thêm danh mục thành công!", "Thành công",
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
