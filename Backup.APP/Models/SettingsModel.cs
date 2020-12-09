using System;
using System.Collections.Generic;
using System.IO;

namespace Backup.APP.Models
{
    public class SettingsModel
    {
        public List<FoldersBackupModel> FoldersBackupModels { get; set; }
        public DateTime DateBackup { get; set; }
        public User User { get; set; }
    }
}
