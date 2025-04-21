using CHTL.BUS;
using CHTL.DAL;
using System.Windows.Forms;
using CHTL.Models;
using Krypton.Toolkit;
using System;
using System.Globalization;

namespace CHTL.GUI.SanPham {
    public partial class FormSanPhamEdit : KryptonForm {
        private XuLySanPham xuLy = new XuLySanPham();
        private TruyCapDanhMuc truyCapDanhMuc = new TruyCapDanhMuc();
        
        private Models.SanPham edittingProduct;
        
        public Models.SanPham SanPhamEdit {
            get => edittingProduct;
            set {
                edittingProduct = value;
                LoadControlsData();
            }
        }
        
        public FormSanPhamEdit() {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
            LoadCategories();
        }
        
        private void LoadCategories() {
            var danhMucList = truyCapDanhMuc.LayDanhSachDanhMuc();
            cbCategoryId.DataSource = danhMucList;
            cbCategoryId.DisplayMember = "MaDanhMuc";
            cbCategoryId.ValueMember = "MaDanhMuc";
            cbCategoryId.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void LoadControlsData() {
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
        
        private void btn_save_Click(object sender, EventArgs e) {
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
                
                if (!decimal.TryParse(textboxSale.Text, out decimal giamGia) || giaBan < 0 || giamGia > giaBan)
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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btn_close_Click(object sender, EventArgs e) {
            Close();
        }
    }
}