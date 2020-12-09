using Backup.APP.Library;
using System.IO;

namespace Backup.APP.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }
        public FileInfo FileSettings  => new FileInfo(Path.Combine(Properties.DirectorySettings.FullName, UserName?.ToLower()));
    }
}
