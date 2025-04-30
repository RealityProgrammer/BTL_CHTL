using Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace CHTL.GUI.Abstracts {
    public partial class FormEdit : KryptonForm {
        public FormEdit() {
            InitializeComponent();
        }
        
        public virtual void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btn_close_Click(object sender, EventArgs e)
        {

        }
    }
}