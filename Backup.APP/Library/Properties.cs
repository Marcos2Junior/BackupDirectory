using Backup.APP.Models;
using System.IO;

namespace Backup.APP.Library
{
    public static class Properties
    {
        public static FileInfo FileSettings = new FileInfo(Path.Combine(Directory.GetCurrentDirectory(), $"appSettings"));
        public static User ActiveUser;
    }
}
