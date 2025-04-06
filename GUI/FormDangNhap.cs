using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace CHTL.GUI {
    public partial class FormDangNhap : KryptonForm {
        public FormDangNhap() {
            InitializeComponent();
        }

        private void btn_dang_nhap_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            FormMain formMain = new FormMain();
            formMain.Show();
        }
    }
}