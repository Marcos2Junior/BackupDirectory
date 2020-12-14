using Backup.APP.Library;
using System.Drawing;

namespace Backup.APP.Classes.Themes
{
    public class DarkTheme
    {
        public void ChooseTheme(OpenForms openForms)
        {
            Properties.ActiveUser.RememberUser.Theme = nameof(DarkTheme);
            #region frmbackup
            #region backcolor
            openForms.FrmBackup.BackColor = SystemColors.Desktop;
            openForms.FrmBackup.P_top.BackColor = SystemColors.Desktop;
            openForms.FrmBackup.Tv_backups.BackColor = SystemColors.WindowFrame;
            #endregion
            #region forecolor
            openForms.FrmBackup.ForeColor = SystemColors.Control;
            openForms.FrmBackup.BTN_addnewbackup.ForeColor = SystemColors.Control;
            openForms.FrmBackup.Tv_backups.ForeColor = SystemColors.Control;
            #endregion
            #region ucNewBackup1
            openForms.FrmBackup.ucNewBackup1.BackColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.ForeColor = SystemColors.Control;

            openForms.FrmBackup.ucNewBackup1.TXT_source.BackColor = SystemColors.WindowFrame;
            openForms.FrmBackup.ucNewBackup1.TXT_source.ForeColor = SystemColors.Control;

            openForms.FrmBackup.ucNewBackup1.TXT_target.ForeColor = SystemColors.Control;
            openForms.FrmBackup.ucNewBackup1.TXT_target.BackColor = SystemColors.WindowFrame;

            openForms.FrmBackup.ucNewBackup1.TXT_namedescription.ForeColor = SystemColors.Control;
            openForms.FrmBackup.ucNewBackup1.TXT_namedescription.BackColor = SystemColors.WindowFrame;

            openForms.FrmBackup.ucNewBackup1.NUP_days.ForeColor = SystemColors.Control;
            openForms.FrmBackup.ucNewBackup1.NUP_days.BackColor = SystemColors.WindowFrame;

            openForms.FrmBackup.ucNewBackup1.NUP_hours.ForeColor = SystemColors.Control;
            openForms.FrmBackup.ucNewBackup1.NUP_hours.BackColor = SystemColors.WindowFrame;

            openForms.FrmBackup.ucNewBackup1.NUP_minutes.ForeColor = SystemColors.Control;
            openForms.FrmBackup.ucNewBackup1.NUP_minutes.BackColor = SystemColors.WindowFrame;

            openForms.FrmBackup.ucNewBackup1.CLB_ignoreFiles.ForeColor = SystemColors.Control;
            openForms.FrmBackup.ucNewBackup1.CLB_ignoreFiles.BackColor = SystemColors.WindowFrame;

            openForms.FrmBackup.ucNewBackup1.BTN_newsource.Image = Resources.newfolder;
            openForms.FrmBackup.ucNewBackup1.BTN_newtarget.Image = Resources.newfolder;
            //openForms.FrmBackup.ucNewBackup1.BTN_save.Image = Resources.save;
            #endregion
            #region images
            openForms.FrmBackup.BTN_close.Image = Resources.close;
            openForms.FrmBackup.BTN_usermenu.Image = Resources.usermenu;
            openForms.FrmBackup.BTN_settings.Image = Resources.settings;
            openForms.FrmBackup.BTN_minimize.Image = Resources.minimize;
            openForms.FrmBackup.PB_logo.Image = Resources.logo;
            openForms.FrmBackup.BTN_theme.Image = Resources.darktheme;
            openForms.FrmBackup.BTN_addnewbackup.Image = Resources.newfolder;
            #endregion
            #endregion
        }
    }
}
