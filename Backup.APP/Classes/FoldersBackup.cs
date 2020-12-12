using Backup.APP.Library;
using Backup.APP.Models;
using System;
using System.IO;
using System.Text.Json;

namespace Backup.APP.Classes
{
    public class FoldersBackup
    {
        public SettingsModel SettingsModel { get; private set; }

        public FoldersBackup(SettingsModel settingsModel)
        {
            SettingsModel = settingsModel;
            if (Properties.ActiveUser != null)
            {
                SettingsModel.User = Properties.ActiveUser;
            }
        }

        public void WriteSettings()
        {
            var sw = new StreamWriter(Properties.ActiveUser.FileSettings);
            sw.Write(Encript.Encrypt(JsonSerializer.Serialize(SettingsModel)));
            sw.Close();
        }

        /// <summary>
        /// read file settings of user
        /// </summary>
        /// <returns>true if user password is correct to decript file settings</returns>
        public bool ReadSettings()
        {
            if (!File.Exists(SettingsModel.User.FileSettings))
            {
                return false;
            }

            try
            {
                string result = File.ReadAllText(SettingsModel.User.FileSettings);
                SettingsModel = JsonSerializer.Deserialize<SettingsModel>(Encript.Decrypt(result, SettingsModel.User.Password));

                return SettingsModel != null;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
