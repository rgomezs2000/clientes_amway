using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace clientes_amway
{
    static class Principal
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private extern static int ShowWindow(System.IntPtr hWnd, int nCmdShow);
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ShowWindow(Process.GetCurrentProcess().MainWindowHandle, 0);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
