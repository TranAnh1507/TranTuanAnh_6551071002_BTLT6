using System;
using System.Windows.Forms;

namespace FormDangKy
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDangKy());
        }
    }
}