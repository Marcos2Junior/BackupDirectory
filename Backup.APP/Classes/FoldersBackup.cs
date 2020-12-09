using Backup.APP.Library;
using Backup.APP.Models;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Backup.APP.Classes
{
    public class FoldersBackup
    {
        public SettingsModel SettingsModel { get; private set; }

        public FoldersBackup(SettingsModel settingsModel)
        {
            SettingsModel = settingsModel;
        }

        public void WriteSettings()
        {
            File.WriteAllText(Properties.ActiveUser.FileSettings.FullName, Encript.Encrypt(JsonSerializer.Serialize(SettingsModel)));
        }

        public void ReadSettings()
        {
            if (SettingsModel.User.FileSettings?.Exists != true)
            {
                return;
            }

            try
            {
                string result = File.ReadAllText(SettingsModel.User.FileSettings.FullName);
                SettingsModel = JsonSerializer.Deserialize<SettingsModel>(Encript.Decrypt(result));
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
