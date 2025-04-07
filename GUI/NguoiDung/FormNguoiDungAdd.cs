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

namespace CHTL.GUI.NguoiDung
{
    public partial class FormNguoiDungAdd : SampleAdd
    {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();

        public FormNguoiDungAdd()
        {
            InitializeComponent();
            InitializeVaiTroComboBox();
        }

        private void InitializeVaiTroComboBox()
        {
            cbVaiTro.Items.Clear();
            cbVaiTro.Items.Add("Admin");
            cbVaiTro.Items.Add("NhanVien");
            cbVaiTro.SelectedIndex = 0; // Mặc định chọn "Admin"
            cbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList; // Chỉ cho phép chọn, không cho nhập tay
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_ma_nguoi_dung.Text))
                {
                    MessageBox.Show("Mã người dùng không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ten_dang_nhap.Text))
                {
                    MessageBox.Show("Tên đăng nhập không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_mat_khau.Text))
                {
                    MessageBox.Show("Mật khẩu không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ho_ten.Text))
                {
                    MessageBox.Show("Họ tên không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbVaiTro.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn vai trò!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng NguoiDung từ dữ liệu nhập
                CHTL.Models.NguoiDung nd = new CHTL.Models.NguoiDung
                {
                    MaNguoiDung = txt_ma_nguoi_dung.Text.Trim(),
                    TenDangNhap = txt_ten_dang_nhap.Text.Trim(),
                    MatKhau = txt_mat_khau.Text.Trim(),
                    VaiTro = cbVaiTro.SelectedItem.ToString(), // Lấy giá trị từ ComboBox
                    HoTen = txt_ho_ten.Text.Trim()
                };

                // Gọi phương thức thêm người dùng
                xuLy.ThemNguoiDung(nd);

                // Thông báo thành công
                MessageBox.Show("Thêm người dùng thành công!", "Thành công",
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
