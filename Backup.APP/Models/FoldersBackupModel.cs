using System;
using System.Collections.Generic;
using System.IO;

namespace Backup.APP.Models
{
    public class FoldersBackupModel
    {
        public string NameDescription { get; set; }
        public DirectoryInfo Source { get; private set; }
        public DirectoryInfo Target { get; private set; }
        public List<FileInfo> FilesIgnore { get; set; }
        public DateTime? LastBackup { get; set; }

        public FoldersBackupModel(string nameDescription, DirectoryInfo source, DirectoryInfo target, List<FileInfo> filesIgnore, DateTime? lastBackup)
        {
            NameDescription = nameDescription;
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
