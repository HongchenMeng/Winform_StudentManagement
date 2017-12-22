using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interface
{
    static class Program
    { 
        [STAThreadAttribute]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }
}