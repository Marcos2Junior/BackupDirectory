using Backup.APP.Library;
using Backup.APP.Views.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Backup.APP.Classes.Themes
{
    public class LightTheme
    {
        public void ChooseTheme()
        {
            FrmBackup frmBackup = (FrmBackup)Application.OpenForms[nameof(FrmBackup)];

            //frmBackup.BTN_theme.Image = 
            frmBackup.BackColor = SystemColors.Desktop;
        }
    }
}
