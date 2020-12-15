using Backup.APP.Classes.Themes;
using Backup.APP.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace Backup.APP.Classes
{
    public class LanguageView
    {
        public void ChooseLanguage(OpenForms openForms)
        {
            var lang = Properties.Language;

            if(openForms.FrmLogin != null)
            {
                openForms.FrmLogin.lbl_username.Text = lang.FrmLogin.UserName;
            }

        }
    }
}
