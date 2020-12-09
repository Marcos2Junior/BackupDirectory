using System;
using System.IO;

namespace Backup.APP.Models
{
    public class FoldersBackupModel
    {
        public DirectoryInfo Source { get; private set; }
        public DirectoryInfo Target { get; private set; }
        public DateTime? LastBackup { get; set; }

        public FoldersBackupModel(DirectoryInfo source, DirectoryInfo target, DateTime? lastBackup)
        {
            Source = source;
            Target = target;
            LastBackup = lastBackup;

            CreateDirectorys();
        }

        private void CreateDirectorys()
        { 
            Directory.CreateDirectory(Source.FullName);
            Directory.CreateDirectory(Target.FullName);
        }
    }
}
