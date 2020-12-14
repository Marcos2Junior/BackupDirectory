using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Backup.APP.Models
{
    public class FoldersBackupModel
    {
        public string NameDescription { get; set; }
        public string Source { get; private set; }
        public string Target { get; private set; }
        public List<string> FilesIgnore { get; set; }
        public DateTime? LastBackup { get; set; }

        public FoldersBackupModel(string nameDescription, DirectoryInfo source, DirectoryInfo target, List<FileInfo> filesIgnore, DateTime? lastBackup)
        {
            NameDescription = nameDescription;
            Source = source.FullName;
            Target = target.FullName;
            LastBackup = lastBackup;
            FilesIgnore = filesIgnore.Select(x => x.FullName).ToList();

            CreateDirectorys();
        }

        private void CreateDirectorys()
        { 
            Directory.CreateDirectory(Source);
            Directory.CreateDirectory(Target);
        }
    }
}
