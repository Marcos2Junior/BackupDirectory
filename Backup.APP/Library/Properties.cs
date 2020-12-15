using Backup.APP.Models;
using Backup.APP.Models.Languages;
using System.IO;

namespace Backup.APP.Library
{
    public static class Properties
    {
        public static DirectoryInfo DirectorySettings = new DirectoryInfo(Path.Combine(Directory.GetCurrentDirectory(), $"appSettings"));
        public static User ActiveUser;
        public static SettingsModel SettingsModel;
        public static Language Language;
    }
}
