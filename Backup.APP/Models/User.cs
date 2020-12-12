using Backup.APP.Library;
using System.IO;
using System.Text.Json.Serialization;

namespace Backup.APP.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }

        [JsonIgnore]
        public SettingsModel SettingsModel { get; set; }

        public RememberUser RememberUser { get; set; } = new RememberUser();

        private string fileSettings;
        public string FileSettings
        {
            get { return fileSettings; }
            set
            {
                fileSettings = new FileInfo(Path.Combine(Properties.DirectorySettings.FullName, UserName?.ToLower())).FullName;
            }
        }
    }
}
