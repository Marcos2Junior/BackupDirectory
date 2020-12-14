using Backup.APP.Library;
using System.Drawing;

namespace Backup.APP.Classes.Themes
{
    public class LightTheme
    {
        public void ChooseTheme(OpenForms openForms)
        {
            Properties.ActiveUser.RememberUser.Theme = nameof(LightTheme);
            #region frmbackup
            #region ucnewbackup1
            openForms.FrmBackup.ucNewBackup1.BackColor = SystemColors.Window;
            openForms.FrmBackup.ucNewBackup1.ForeColor = SystemColors.Desktop;

            openForms.FrmBackup.ucNewBackup1.TXT_source.BackColor = SystemColors.InactiveBorder;
            openForms.FrmBackup.ucNewBackup1.TXT_source.ForeColor = SystemColors.Desktop;

            openForms.FrmBackup.ucNewBackup1.TXT_target.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.TXT_target.BackColor = SystemColors.InactiveBorder;

            openForms.FrmBackup.ucNewBackup1.TXT_namedescription.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.TXT_namedescription.BackColor = SystemColors.InactiveBorder;

            openForms.FrmBackup.ucNewBackup1.NUP_days.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.NUP_days.BackColor = SystemColors.InactiveBorder;

            openForms.FrmBackup.ucNewBackup1.NUP_hours.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.NUP_hours.BackColor = SystemColors.InactiveBorder;

            openForms.FrmBackup.ucNewBackup1.NUP_minutes.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.NUP_minutes.BackColor = SystemColors.InactiveBorder;

            openForms.FrmBackup.ucNewBackup1.CLB_ignoreFiles.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.ucNewBackup1.CLB_ignoreFiles.BackColor = SystemColors.InactiveBorder;

            openForms.FrmBackup.ucNewBackup1.BTN_newsource.Image = Resources.newfolderdark;
            openForms.FrmBackup.ucNewBackup1.BTN_newtarget.Image = Resources.newfolderdark;
            //openForms.FrmBackup.ucNewBackup1.BTN_save.Image = Resources.savedark;
            #endregion
            #region images
            openForms.FrmBackup.BTN_close.Image = Resources.closedark;
            openForms.FrmBackup.BTN_usermenu.Image = Resources.usermenudark;
            openForms.FrmBackup.BTN_settings.Image = Resources.settingsdark;
            openForms.FrmBackup.BTN_minimize.Image = Resources.minimizedark;
            openForms.FrmBackup.PB_logo.Image = Resources.logodark;
            openForms.FrmBackup.BTN_theme.Image = Resources.lighttheme;
            openForms.FrmBackup.BTN_addnewbackup.Image = Resources.newfolderdark;
            #endregion
            #region backcolor
            openForms.FrmBackup.BackColor = SystemColors.Window;
            openForms.FrmBackup.P_top.BackColor = SystemColors.Menu;
            openForms.FrmBackup.Tv_backups.BackColor = SystemColors.InactiveBorder;
            #endregion
            #region forecolor
            openForms.FrmBackup.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.BTN_addnewbackup.ForeColor = SystemColors.Desktop;
            openForms.FrmBackup.Tv_backups.ForeColor = SystemColors.Desktop;
            #endregion
            #endregion
        }
    }
}
