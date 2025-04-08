using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHTL.GUI.Sample_Form;

namespace CHTL.GUI.DanhMuc
{
    public partial class FormDanhMucAdd : SampleAdd
    {
        public FormDanhMucAdd()
        {
            InitializeComponent();
        }

        public override void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void btn_close_Click(object sender, EventArgs e)
        {

        }
    }
}
