using Microsoft.Win32;
using System.Linq;
using System.Windows.Forms;

namespace Backup.APP.Classes
{
    public class StartupApp
    {
        private readonly string registryKeyName = "BackupDirectory";
        private readonly RegistryKey RegistryKey;
        public StartupApp()
        {
            RegistryKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
        }
        /// <summary>
        /// Define app to start with windows
        /// </summary>
        public void SetStartup() => RegistryKey.SetValue(registryKeyName, Application.ExecutablePath);

        /// <summary>
        /// verify if app start with windows, return true if true
        /// </summary>
        public bool StartWithWindows => RegistryKey.GetValueNames().Any(x => x == registryKeyName);

        /// <summary>
        /// remove app of start with windows
        /// </summary>
        public void RemoveStartWithWindows() => RegistryKey.DeleteValue(registryKeyName);

        /// <summary>
        /// close the keys and flushes
        /// </summary>
        public void CloseRegistry() => RegistryKey.Close();
    }
}
