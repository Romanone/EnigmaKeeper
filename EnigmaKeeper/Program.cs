using System;
using System.Windows.Forms;
using EnigmaKeeper.BL;

namespace EnigmaKeeper
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

            MainForm mainForm = new MainForm();
            Model model = new Model();

            Application.Run(new MainForm());


        }
    }
}
