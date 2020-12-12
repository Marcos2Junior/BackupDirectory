using Backup.APP.Library;
using Backup.APP.Views.Forms;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Backup.APP.Classes.Themes
{
    public class DarkTheme
    {
        public void ChooseTheme()
        {
            FrmBackup frmBackup = (FrmBackup)Application.OpenForms[nameof(FrmBackup)];
            //var sdfs = System.Environment.GetFolderPath()
            //frmBackup.BTN_theme.Image = Image.FromFile()
            frmBackup.BackColor = SystemColors.Desktop;
        }
    }
}
