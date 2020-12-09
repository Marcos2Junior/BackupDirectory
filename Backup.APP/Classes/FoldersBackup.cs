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
        }

        public FoldersBackup()
        {

        }

        public void WriteSettings()
        {
            File.WriteAllText(Properties.FileSettings.FullName, Encript.Encrypt(JsonSerializer.Serialize(SettingsModel)));
        }

        public void ReadSettings()
        {
            //checking for file existence is done the moment the application is started
            string result = File.ReadAllText(Properties.FileSettings.FullName);

            try
            {
                result = Encript.Decrypt(result);
            }
            catch (Exception)
            {
                throw new Exception($"The settings file located at {Properties.FileSettings.FullName} " +
                    "is not a correct format. make sure there is a copy of this file to replace " +
                    "or remove it to generate new settings.");
            }

            SettingsModel = JsonSerializer.Deserialize<SettingsModel>(result);
        }
    }
}
