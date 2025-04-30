using CHTL.BUS;
using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.DanhMuc {
    public partial class FormDanhMucAdd : KryptonForm {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        
        public FormDanhMucAdd() {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e) {
            try
            {
                // Kiểm tra dữ liệu đầu vào
                if (string.IsNullOrWhiteSpace(textboxID.Text))
                {
                    MessageBox.Show("Mã danh mục không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(textboxTen.Text))
                {
                    MessageBox.Show("Tên danh mục không được để trống!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo đối tượng DanhMucSanPham từ dữ liệu nhập
                Models.DanhMucSanPham dm = new Models.DanhMucSanPham()
                {
                    MaDanhMuc = textboxID.Text.Trim(),
                    TenDanhMuc = textboxTen.Text.Trim()
                };

                // Gọi phương thức thêm danh mục
                xuLy.ThemDanhMuc(dm);

                // Thông báo thành công
                MessageBox.Show("Thêm danh mục thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}