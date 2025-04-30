using CHTL.BUS;
using CHTL.DAL;
using CHTL.GUI.Abstracts;
using System.Windows.Forms;
using CHTL.Models;
using Krypton.Toolkit;
using System;
using System.Drawing;
using System.Globalization;

namespace CHTL.GUI.SanPham
{
    public partial class SanPhamFormEdit : FormEdit
    {
        private XuLySanPham xuLy = new XuLySanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();
        private Models.SanPham edittingProduct;
        private bool isClosing = false; // Biến kiểm soát trạng thái đóng form

        public Models.SanPham SanPhamEdit
        {
            get => edittingProduct;
            set
            {
                edittingProduct = value;
                LoadControlsData();
            }
        }

        public SanPhamFormEdit()
        {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
            LoadCategories();
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

            //// Tùy chỉnh kryptonLabel1
            //kryptonLabel1.StateCommon.ShortText.Color1 = Color.White;
            //kryptonLabel1.StateCommon.ShortText.Font = new Font("Segoe UI", 14F, FontStyle.Bold);

            //// Tùy chỉnh kryptonPanel2
            //kryptonPanel2.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            //kryptonPanel2.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;

            // Tùy chỉnh kryptonPanel3
            kryptonPanel3.StateCommon.Color1 = Color.FromArgb(236, 240, 241); // Xám nhạt
            //kryptonPanel3.StateCommon.Border.DrawBorders = PaletteDrawBorders.None;

            //// Tùy chỉnh các nhãn
            //foreach (var label in new[] { labelMaSanPham, labelTenSanPham, labelGiaBan, labelGiamGia, labelMaDanhMuc, labelSoLuongTon, labelNgayHetHan })
            //{
            //    label.StateCommon.ShortText.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
            //    label.StateCommon.ShortText.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            //}

            // Tùy chỉnh các ô nhập liệu
            foreach (var textBox in new[] { textboxID, textboxName, textboxPrice, textboxSale, textboxInventoryAmount })
            {
                textBox.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Xám nhạt
                textBox.StateCommon.Border.DrawBorders = PaletteDrawBorders.All;
                textBox.StateCommon.Border.Rounding = 5F;
                textBox.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                textBox.StateCommon.Content.Font = new Font("Segoe UI", 11F);
            }

            // Tùy chỉnh combobox
            //cbCategoryId.FlatStyle = FlatStyle.Flat;
            cbCategoryId.BackColor = Color.White;
            cbCategoryId.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            cbCategoryId.Font = new Font("Segoe UI", 11F);

            // Tùy chỉnh DateTimePicker
            dtpExpiration.Format = DateTimePickerFormat.Short;
            dtpExpiration.Font = new Font("Segoe UI", 11F);
        }

        private void LoadCategories()
        {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbCategoryId.DataSource = danhMucList;
            cbCategoryId.DisplayMember = "MaDanhMuc";
            cbCategoryId.ValueMember = "MaDanhMuc";
            cbCategoryId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadControlsData()
        {
            textboxID.Text = edittingProduct.MaSanPham;
            textboxName.Text = edittingProduct.TenSanPham;
            textboxPrice.Text = edittingProduct.GiaBan.ToString(CultureInfo.CurrentCulture);
            cbCategoryId.SelectedValue = edittingProduct.MaDanhMuc;
            textboxInventoryAmount.Text = edittingProduct.SoLuongTon.ToString();
            textboxSale.Text = edittingProduct.GiamGia.ToString(CultureInfo.CurrentCulture);

            if (edittingProduct.NgayHetHan.HasValue)
            {
                dtpExpiration.Value = edittingProduct.NgayHetHan.Value;
                dtpExpiration.Checked = true;
            }
            else
            {
                dtpExpiration.Checked = false;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (isClosing) return; // Tránh gọi lại nếu đang đóng

            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(textboxName.Text))
                {
                    MessageBox.Show("Tên sản phẩm không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textboxPrice.Text, out decimal giaBan) || giaBan < 0)
                {
                    MessageBox.Show("Giá bán không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(textboxSale.Text, out decimal giamGia) || giamGia < 0 || giamGia > giaBan)
                {
                    MessageBox.Show("Giảm giá không hợp lệ! Vui lòng nhập số không âm và không lớn hơn giá bán.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbCategoryId.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn mã danh mục!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(textboxInventoryAmount.Text, out int soLuongTon) || soLuongTon < 0)
                {
                    MessageBox.Show("Số lượng tồn không hợp lệ! Vui lòng nhập số không âm.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DateTime? ngayHetHan = dtpExpiration.Checked ? (DateTime?)dtpExpiration.Value : null;

                // Cập nhật thông tin sản phẩm
                edittingProduct.TenSanPham = textboxName.Text.Trim();
                edittingProduct.GiaBan = giaBan;
                edittingProduct.MaDanhMuc = cbCategoryId.SelectedValue.ToString();
                edittingProduct.SoLuongTon = soLuongTon;
                edittingProduct.NgayHetHan = ngayHetHan;
                edittingProduct.GiamGia = giamGia;

                // Gọi phương thức sửa sản phẩm
                xuLy.SuaSanPham(edittingProduct);

                // Thông báo thành công
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form
                isClosing = true;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (isClosing) return; // Tránh gọi lại nếu đang đóng
            isClosing = true;
            Close();
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