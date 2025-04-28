using System;
using System.Drawing;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;
using CHTL.BUS;
using CHTL.Models;
using CHTL.DAL;
using Krypton.Toolkit;

namespace CHTL.GUI.SanPham
{
    public partial class FormSanPhamAdd : SampleAdd
    {
        private XuLySanPham xuLy = new XuLySanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();
        private bool isClosing = false; // Biến kiểm soát trạng thái đóng form

        public FormSanPhamAdd()
        {
            InitializeComponent();
            LoadDanhMuc();
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

            //// Tùy chỉnh các nhãn
            //foreach (var label in new[] { labelMaSanPham, labelTenSanPham, labelGiaBan, labelMaDanhMuc, labelSoLuongTon, labelNgayHetHan })
            //{
            //    label.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            //    label.StateCommon.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            //}

            // Tùy chỉnh các ô nhập liệu
            foreach (var textBox in new[] { txt_ma_san_pham, txt_ten_san_pham, txt_gia_ban, txt_so_luong_ton })
            {
                textBox.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
                textBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                textBox.StateCommon.Border.Rounding = 5F;
                textBox.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                textBox.StateCommon.Content.Font = new Font("Segoe UI", 11F);
            }

            // Tùy chỉnh combobox
            //cbMaDanhMuc.FlatStyle = FlatStyle.Flat;
            cbMaDanhMuc.BackColor = Color.White;
            cbMaDanhMuc.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            cbMaDanhMuc.Font = new Font("Segoe UI", 11F);

            // Tùy chỉnh DateTimePicker
            dtp_ngay_het_han.Format = DateTimePickerFormat.Short;
            dtp_ngay_het_han.Font = new Font("Segoe UI", 11F);
        }

        private void LoadDanhMuc()
        {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbMaDanhMuc.DataSource = danhMucList;
            cbMaDanhMuc.DisplayMember = "MaDanhMuc";
            cbMaDanhMuc.ValueMember = "MaDanhMuc";
            cbMaDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            if (isClosing) return; // Tránh gọi lại nếu đang đóng

            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(txt_ma_san_pham.Text))
                {
                    MessageBox.Show("Mã sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_ten_san_pham.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(txt_gia_ban.Text, out decimal giaBan) || giaBan < 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbMaDanhMuc.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mã danh mục!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txt_so_luong_ton.Text, out int soLuongTon) || soLuongTon < 0)
                {
                    MessageBox.Show("Số lượng tồn không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime? ngayHetHan = dtp_ngay_het_han.Checked ? (DateTime?)dtp_ngay_het_han.Value : null;

                // Tạo đối tượng SanPham
                CHTL.Models.SanPham sp = new CHTL.Models.SanPham
                {
                    MaSanPham = txt_ma_san_pham.Text.Trim(),
                    TenSanPham = txt_ten_san_pham.Text.Trim(),
                    GiaBan = giaBan,
                    MaDanhMuc = cbMaDanhMuc.SelectedValue.ToString(),
                    SoLuongTon = soLuongTon,
                    NgayHetHan = ngayHetHan,
                    GiamGia = 0 // Giá trị mặc định nếu không có trường nhập liệu cho GiamGia
                };

                // Gọi phương thức thêm sản phẩm
                xuLy.ThemSanPham(sp);

                // Thông báo thành công
                MessageBox.Show("Thêm sản phẩm thành công!", "Thành công",
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
                isClosing = true;
            }
            base.OnFormClosing(e);
        }
    }
}