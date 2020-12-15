using System.Collections.Generic;

namespace Backup.APP.Models
{
    public class GlobalUser
    {
        public string LastUserLogin { get; set; }
        public string LanguageDefault { get; set; }
        public List<ConfigGlobalUser> ConfigGlobalUser { get; set; } = new List<ConfigGlobalUser>();
    }
}
