using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CHTL.BUS;
using CHTL.DAL;
using CHTL.GUI.Sample_Form;
using CHTL.Models;
using Krypton.Toolkit;
using Microsoft.Data.SqlClient;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucView : SampleView
    {
        private XuLyDanhMuc xuLy = new XuLyDanhMuc();
        public FormDanhMucView()
        {
            InitializeComponent();
            LoadData();
            CustomizeDataGridView();
            SetupSearchBox();
            SetupButtonHover();
        }

        private void LoadData()
        {
            var danhSach = xuLy.LayDanhSachDanhMuc();
            dgvDanhMuc.DataSource = danhSach;
        }

        private void CustomizeDataGridView()
        {
            // Tùy chỉnh màu nền và viền
            dgvDanhMuc.BackgroundColor = Color.FromArgb(236, 240, 241); // Xám nhạt
            dgvDanhMuc.BorderStyle = BorderStyle.None;
            dgvDanhMuc.EnableHeadersVisualStyles = false;

            // Tùy chỉnh header
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDanhMuc.ColumnHeadersHeight = 40;

            // Tùy chỉnh hàng
            dgvDanhMuc.RowsDefaultCellStyle.BackColor = Color.White;
            dgvDanhMuc.RowsDefaultCellStyle.ForeColor = Color.FromArgb(44, 62, 80); // Xám đậm
            dgvDanhMuc.RowsDefaultCellStyle.Font = new Font("Segoe UI", 11F);
            dgvDanhMuc.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113); 
            dgvDanhMuc.RowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Tùy chỉnh hàng xen kẽ
            dgvDanhMuc.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(247, 249, 250); // Xám rất nhạt

            // Tùy chỉnh cột "Sửa" và "Xóa"
            foreach (DataGridViewColumn column in dgvDanhMuc.Columns.Cast<DataGridViewColumn>().ToList())
            {
                if (column.Name == "colEdit")
                {
                    column.DefaultCellStyle.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
                    column.DefaultCellStyle.ForeColor = Color.White;
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else if (column.Name == "colDelete")
                {
                    column.DefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60); // Đỏ nhạt
                    column.DefaultCellStyle.ForeColor = Color.White;
                    column.DefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    column.Width = 80;
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                }
                else
                {
                    column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                }
            }

            // Tùy chỉnh đường lưới
            dgvDanhMuc.GridColor = Color.FromArgb(189, 195, 199); // Xám nhạt
            dgvDanhMuc.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void SetupSearchBox()
        {
            txt_search.Text = "Nhập mã hoặc tên danh mục...";
            txt_search.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166); // Xám nhạt
            txt_search.Enter += (s, e) =>
            {
                if (txt_search.Text == "Nhập mã hoặc tên danh mục...")
                {
                    txt_search.Text = "";
                    txt_search.StateCommon.Content.Color1 = Color.FromArgb(44, 62, 80); // Xám đậm
                    txt_search.StateCommon.Border.Color1 = Color.FromArgb(52, 152, 219); // Viền xanh dương
                }
            };
            txt_search.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt_search.Text))
                {
                    txt_search.Text = "Nhập mã hoặc tên danh mục...";
                    txt_search.StateCommon.Content.Color1 = Color.FromArgb(149, 165, 166);
                    txt_search.StateCommon.Border.Color1 = Color.FromArgb(189, 195, 199); // Viền xám nhạt
                }
            };
        }

        private void SetupButtonHover()
        {
            // Ensure btn_add is a PictureBox, not a KryptonButton  
            if (btn_add is PictureBox pictureBox)
            {
                pictureBox.MouseEnter += (s, e) =>
                {
                    pictureBox.BackColor = Color.FromArgb(41, 128, 185); // Xanh đậm  
                    
                };
                pictureBox.MouseLeave += (s, e) =>
                {
                    pictureBox.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương  
                };
            }
            else
            {
                throw new InvalidOperationException("btn_add must be of type PictureBox to use BackColor properties.");
            }
        }

        private void dgv_danh_muc_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvDanhMuc.Columns[e.ColumnIndex].Name == "colEdit")
            {
                dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(41, 128, 185); // Xanh đậm
            }
            else if (dgvDanhMuc.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(192, 57, 43); // Đỏ đậm
            }
        }

        private void dgv_danh_muc_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvDanhMuc.Columns[e.ColumnIndex].Name == "colEdit")
            {
                dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(52, 152, 219); // Xanh dương
            }
            else if (dgvDanhMuc.Columns[e.ColumnIndex].Name == "colDelete")
            {
                dgvDanhMuc.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(231, 76, 60); // Đỏ nhạt
            }
        }

        public override void txt_search_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txt_search.Text.Trim();
            if (tuKhoa == "Nhập mã hoặc tên danh mục...") tuKhoa = "";
            var danhSach = xuLy.TimKiemDanhMuc(tuKhoa);
            dgvDanhMuc.DataSource = danhSach;
        }

        public override void btn_add_Click(object sender, EventArgs e)
        {
            FormDanhMucAdd frmAdd = new FormDanhMucAdd();
            frmAdd.ShowDialog();
            LoadData();
        }

        private void dgv_danh_muc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var danhMuc = dgvDanhMuc.Rows[e.RowIndex].DataBoundItem as DanhMucSanPham;

                if (e.ColumnIndex == dgvDanhMuc.Columns["colEdit"].Index)
                {
                    FormDanhMucEdit frmEdit = new FormDanhMucEdit();
                    frmEdit.DanhMucEdit = danhMuc;
                    frmEdit.ShowDialog();
                    LoadData();
                }

                if (e.ColumnIndex == dgvDanhMuc.Columns["colDelete"].Index)
                {
                    var result = KryptonMessageBox.Show($"Bạn có chắc muốn xóa danh mục {danhMuc.TenDanhMuc}?",
                        "Xác nhận", KryptonMessageBoxButtons.YesNo, KryptonMessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            xuLy.XoaDanhMuc(danhMuc.MaDanhMuc);
                            KryptonMessageBox.Show("Xóa danh mục thành công!", "Thành công",
                                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Information);
                            LoadData();
                        }
                        catch (Exception ex)
                        {
                            KryptonMessageBox.Show($"Lỗi: {ex.Message}", "Lỗi",
                                KryptonMessageBoxButtons.OK, KryptonMessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}