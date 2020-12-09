using Backup.APP.Models;

namespace Backup.APP.Classes
{
    public class FoldersBackup
    {
        public SettingsModel SettingsModel { get; private set; }

        public FoldersBackup(SettingsModel settingsModel)
        {
            SettingsModel = settingsModel;
        }

        public FoldersBackup()
        {

        }

        public void WriteSettings()
        {

        }
    }
}
