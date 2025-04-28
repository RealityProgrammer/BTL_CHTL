using System;
using System.Drawing;
using System.Windows.Forms;
using CHTL.BUS;
using CHTL.GUI.Sample_Form;
using Krypton.Toolkit;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucAdd : SampleAdd
    {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        private bool isClosing = false; // Biến kiểm soát trạng thái đóng form

        public FormDanhMucAdd()
        {
            InitializeComponent();
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
            //foreach (var label in new[] { kryptonLabel1_1, kryptonLabel2 })
            //{
            //    label.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            //    label.StateCommon.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            //}

            // Tùy chỉnh các ô nhập liệu
            foreach (var textBox in new[] { txt_ma_danh_muc, txt_ten_danh_muc })
            {
                textBox.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
                textBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                textBox.StateCommon.Border.Rounding = 5F;
                textBox.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                textBox.StateCommon.Content.Font = new Font("Segoe UI", 11F);
            }
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            if (isClosing) return; // Tránh gọi lại nếu đang đóng

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

                // Tạo đối tượng DanhMucSanPham từ dữ liệu nhập
                CHTL.Models.DanhMucSanPham dm = new CHTL.Models.DanhMucSanPham()
                {
                    MaDanhMuc = txt_ma_danh_muc.Text.Trim(),
                    TenDanhMuc = txt_ten_danh_muc.Text.Trim()
                };

                // Gọi phương thức thêm danh mục
                xuLy.ThemDanhMuc(dm);

                // Thông báo thành công
                MessageBox.Show("Thêm danh mục thành công!", "Thành công",
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
            if (!isClosing)
            {
                // Nếu đóng form bằng nút X, đảm bảo không mở lại
                isClosing = true;
            }
            base.OnFormClosing(e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            // Đảm bảo không có logic nào mở lại form sau khi đóng
            base.OnFormClosed(e);
        }
    }
}