using Backup.APP.Library;
using Backup.APP.Models;
using Backup.APP.Models.Languages;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows.Forms;

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

            GetLanguageDefault(globalUser.LanguageDefault);

            return globalUser;
        }

        public static void GetLanguageDefault(string languageDefault)
        {
            switch (languageDefault)
            {
                case nameof(Resources.pt_br):
                    Properties.Language = JsonSerializer.Deserialize<Language>(System.Text.Encoding.UTF8.GetString(Resources.pt_br));
                    break;
                default:
                    Properties.Language = JsonSerializer.Deserialize<Language>(System.Text.Encoding.UTF8.GetString(Resources.pt_br));
                    break;
            }
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
