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

namespace CHTL.GUI.NguoiDung
{
    public partial class FormNguoiDungEdit : SampleEdit
    {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();

        // Thuộc tính để nhận đối tượng NguoiDung từ FormNguoiDungView
        private CHTL.Models.NguoiDung nguoiDungEdit;
        public CHTL.Models.NguoiDung NguoiDungEdit
        {
            get { return nguoiDungEdit; }
            set
            {
                nguoiDungEdit = value;
                LoadDataToForm(); // Hiển thị dữ liệu lên form khi nhận được đối tượng
            }
        }

        public FormNguoiDungEdit()
        {
            InitializeComponent();
            InitializeVaiTroComboBox();
            InitializeControls();
        }

        private void InitializeVaiTroComboBox()
        {
            cbVaiTro.Items.Clear();
            cbVaiTro.Items.Add("Admin");
            cbVaiTro.Items.Add("NhanVien");
            cbVaiTro.DropDownStyle = ComboBoxStyle.DropDownList; // Chỉ cho phép chọn
        }

        private void InitializeControls()
        {
            // Làm cho txt_mat_khau không chỉnh sửa được
            txt_mat_khau.ReadOnly = true;
        }

        private void LoadDataToForm()
        {
            if (nguoiDungEdit != null)
            {
                txt_ma_nguoi_dung.Text = nguoiDungEdit.MaNguoiDung;
                txt_ten_dang_nhap.Text = nguoiDungEdit.TenDangNhap;
                txt_mat_khau.Text = nguoiDungEdit.MatKhau; // Hiển thị mật khẩu nhưng không cho sửa
                cbVaiTro.SelectedItem = nguoiDungEdit.VaiTro; // Chọn vai trò tương ứng
                txt_ho_ten.Text = nguoiDungEdit.HoTen;
            }
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

                // Cập nhật thông tin người dùng
                nguoiDungEdit.MaNguoiDung = txt_ma_nguoi_dung.Text.Trim();
                nguoiDungEdit.TenDangNhap = txt_ten_dang_nhap.Text.Trim();
                nguoiDungEdit.VaiTro = cbVaiTro.SelectedItem.ToString();
                nguoiDungEdit.HoTen = txt_ho_ten.Text.Trim();
                // Không cập nhật MatKhau vì không cho phép sửa

                // Gọi phương thức sửa người dùng
                xuLy.SuaNguoiDung(nguoiDungEdit);

                // Thông báo thành công
                MessageBox.Show("Cập nhật người dùng thành công!", "Thành công",
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
