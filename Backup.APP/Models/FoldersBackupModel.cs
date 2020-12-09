using System;
using System.Collections.Generic;
using System.IO;

namespace Backup.APP.Models
{
    public class FoldersBackupModel
    {
        public DirectoryInfo Source { get; private set; }
        public DirectoryInfo Target { get; private set; }
        public List<FileInfo> FilesIgnore { get; set; }
        public DateTime? LastBackup { get; set; }

        public FoldersBackupModel(DirectoryInfo source, DirectoryInfo target, List<FileInfo> filesIgnore, DateTime? lastBackup)
        {
            Source = source;
            Target = target;
            LastBackup = lastBackup;
            FilesIgnore = filesIgnore;

            CreateDirectorys();
        }

        private void CreateDirectorys()
        { 
            Directory.CreateDirectory(Source.FullName);
            Directory.CreateDirectory(Target.FullName);
        }
    }
}
