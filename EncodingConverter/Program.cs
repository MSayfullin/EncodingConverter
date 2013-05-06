using System;
using System.Windows.Forms;

namespace dokas.Encoder
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new MainForm());
        }
    }
}
