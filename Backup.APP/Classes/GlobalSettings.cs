using Backup.APP.Library;
using Backup.APP.Models;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace Backup.APP.Classes
{
    public class GlobalSettings
    {
        private static readonly FileInfo FileSettings = new FileInfo(Path.Combine(Properties.DirectorySettings.FullName, "settings"));
        public static GlobalUser GetGlobalUser()
        {
            GlobalUser globalUser = new GlobalUser();

            try
            {
                if (FileSettings.Exists)
                {
                    globalUser = JsonSerializer.Deserialize<GlobalUser>(File.ReadAllText(FileSettings.FullName));
                }
            }
            catch
            {
            }

            return globalUser;
        }

        public static void WriteConfig()
        {
            var models = GetGlobalUser();

            var configUser = models.ConfigGlobalUser?.FirstOrDefault(x => x.UserName == Properties.ActiveUser.UserName);

            ConfigGlobalUser configGlobalUser = new ConfigGlobalUser
            {
                PasswordHint = Properties.ActiveUser.PasswordHint,
                UserName = Properties.ActiveUser.UserName
            };

            if (configUser != null)
            {
                configUser = configGlobalUser;
            }
            else
            {
                models.ConfigGlobalUser.Add(configGlobalUser);
            }

            models.LastUserLogin = configGlobalUser.UserName;

            var sw = new StreamWriter(FileSettings.FullName);
            sw.Write(JsonSerializer.Serialize(models));
            sw.Close();
        }
    }
}
