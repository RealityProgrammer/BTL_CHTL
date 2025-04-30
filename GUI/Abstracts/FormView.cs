using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.Abstracts {
    public partial class FormView : KryptonForm {
        public FormView() {
            InitializeComponent();
        }

        public virtual void btn_add_Click(object sender, EventArgs e) {
        }

        public virtual void txt_search_TextChanged(object sender, EventArgs e) {
        }
    }
}