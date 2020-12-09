using Backup.APP.Library;
using Backup.APP.Views.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Backup.APP
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Directory.CreateDirectory(Properties.DirectorySettings.FullName);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmBackup());
        }
    }
}
