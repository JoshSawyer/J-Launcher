using System;
using System.Windows.Forms;

namespace Launchpad
{
    static class Program
    {
        [STAThread]()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main_2());
        }
    }
}
