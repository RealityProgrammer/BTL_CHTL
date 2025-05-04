using System;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace CHTL.GUI {
    internal static class Program {
        public static FormDangNhap LoginForm { get; private set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(LoginForm = new FormDangNhap());
           
        }
    }
}