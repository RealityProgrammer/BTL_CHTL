using System;
using System.Drawing;
using System.Windows.Forms;
using CHTL.BUS;
using CHTL.GUI.Sample_Form;
using CHTL.Models;
using Krypton.Toolkit;

namespace CHTL.GUI.NguoiDung
{
    public partial class FormNguoiDungAdd : SampleAdd
    {
        private XuLyNguoiDung xuLy = new XuLyNguoiDung();
        private bool isClosing = false; // Biến kiểm soát trạng thái đóng form

        public FormNguoiDungAdd()
        {
            InitializeComponent();
            InitializeVaiTroComboBox();
            CustomizeForm();
        }

        private void CustomizeForm()
        {
            this.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt

            // Tùy chỉnh kryptonPanel1
            kryptonPanel1.StateCommon.Color1 = Color.FromArgb(52, 152, 219); // Xanh dương
            //kryptonPanel1.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
            //kryptonPanel1.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
            //kryptonPanel1.StateCommon.Border.Rounding = 10F;

            // Tùy chỉnh pictureBox1
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.BackColor = Color.FromArgb(236, 240, 241); // Xám nhạt (tạm thời nếu không có hình)

            // Tùy chỉnh kryptonLabel1
            kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            // Tùy chỉnh kryptonPanel2
            kryptonPanel2.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            //kryptonPanel2.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;

            // Tùy chỉnh kryptonPanel3
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            //kryptonPanel3.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;

            // Tùy chỉnh các nhãn
            foreach (var label in new[] { kryptonLabel1_1, kryptonLabel2, kryptonLabel3, kryptonLabel4, kryptonLabel5 })
            {
                label.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                label.StateCommon.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            }

            // Tùy chỉnh các ô nhập liệu
            foreach (var textBox in new[] { txt_ma_nguoi_dung, txt_ten_dang_nhap, txt_mat_khau, txt_ho_ten })
            {
                textBox.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
                textBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                textBox.StateCommon.Border.Rounding = 5F;
                textBox.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                textBox.StateCommon.Content.Font = new Font("Segoe UI", 11F);
            }

            // Tùy chỉnh cbVaiTro
            cbVaiTro.StateCommon.ComboBox.Border.Color1 = Color.FromArgb(189, 195, 199);
            cbVaiTro.StateCommon.ComboBox.Border.DrawBorders = PaletteDrawBorders.All;
            cbVaiTro.StateCommon.ComboBox.Border.Rounding = 5F;
            cbVaiTro.StateCommon.ComboBox.Content.Color1 = Color.FromArgb(44, 62, 80);
            cbVaiTro.StateCommon.ComboBox.Content.Font = new Font("Segoe UI", 11F);
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
            if (isClosing) return; // Tránh gọi lại nếu đang đóng

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
                    VaiTro = cbVaiTro.SelectedItem.ToString(),
                    HoTen = txt_ho_ten.Text.Trim()
                };

                // Gọi phương thức thêm người dùng
                xuLy.ThemNguoiDung(nd);

                // Thông báo thành công
                MessageBox.Show("Thêm người dùng thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form
                isClosing = true;
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
            if (isClosing) return; // Tránh gọi lại nếu đang đóng
            isClosing = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isClosing)
            {
                base.OnFormClosing(e);
                return;
            }

            // Có thể thêm logic xác nhận trước khi đóng (nếu cần)
            base.OnFormClosing(e);
        }
    }
}