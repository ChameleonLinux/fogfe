using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fog_Editor
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
            try
            {
                Application.Run(new MainWindow());
            } catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Fog File Editor");
                StreamWriter crashlog = new StreamWriter("crash.log");
                crashlog.Write(e.ToString());
                crashlog.Close();
            }
        }
    }
}
