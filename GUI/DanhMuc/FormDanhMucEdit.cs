using System;
using System.Drawing;
using System.Windows.Forms;
using CHTL.BUS;
using CHTL.GUI.Abstracts;
using Krypton.Toolkit;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucEdit : KryptonForm
    {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        private Models.DanhMucSanPham danhMucEdit;
        private bool isClosing = false; // Biến kiểm soát trạng thái đóng form

        public Models.DanhMucSanPham DanhMucEdit {
            get => danhMucEdit;
            set
            {
                danhMucEdit = value;
                LoadDataToForm();
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
                textboxID.Text = danhMucEdit.MaDanhMuc;
                textboxTen.Text = danhMucEdit.TenDanhMuc;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isClosing) return; // Tránh gọi lại nếu đang đóng

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

                // Cập nhật thông tin danh mục
                danhMucEdit.TenDanhMuc = textboxTen.Text.Trim();

                // Gọi phương thức sửa danh mục
                xuLy.SuaDanhMuc(danhMucEdit);

                // Thông báo thành công
                MessageBox.Show("Cập nhật danh mục thành công!", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}