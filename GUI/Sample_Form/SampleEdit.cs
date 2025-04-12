using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CHTL.GUI.Sample_Form
{
    public partial class SampleEdit : KryptonForm
    {
        public SampleEdit()
        {
            InitializeComponent();
            LocalCustomPalette = GlobalPalette.Palette;
            PaletteMode = PaletteMode.Custom;
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
