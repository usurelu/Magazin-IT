using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagazinIT.GUI;
//using System.MagazinITMainWindow.Form;

//using System.MagazinIT.GUI

namespace Magazin_IT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MagazinITMainWindow());
        }
    }
}
