using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creepy_Calc
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
            MessageBox.Show("This program is meant for entertainment purposes only!! \nThis program is not intended to provide any leagal council \nThis program will not diagnose, cure, or prevent any disease.");
            Application.Run(new Form1());
        }
    }
}
