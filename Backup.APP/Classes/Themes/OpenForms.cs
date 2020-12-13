using Backup.APP.Views.Forms;
using System.Windows.Forms;

namespace Backup.APP.Classes.Themes
{
    public class OpenForms
    {
        public FrmBackup FrmBackup { get; private set; }
        public FrmLogin FrmLogin { get; private set; }

        public OpenForms()
        {
            FrmBackup = (FrmBackup)Application.OpenForms[nameof(FrmBackup)];
            FrmLogin = (FrmLogin)Application.OpenForms[nameof(FrmLogin)];
        }
    }
}
