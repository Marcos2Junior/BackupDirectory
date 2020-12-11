﻿using Backup.APP.Library;
using System.IO;

namespace Backup.APP.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordHint { get; set; }

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
