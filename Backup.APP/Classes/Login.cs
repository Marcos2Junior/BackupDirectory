using Backup.APP.Library;
using Backup.APP.Models;
using System.IO;

namespace Backup.APP.Classes
{
    public class Login
    {
        private readonly User User;

        public Login(User user)
        {
            User = user;
        }

        public Response CheckLogin()
        {
            SettingsModel settingsModel = new SettingsModel
            {
                User = User
            };

            FoldersBackup foldersBackup = new FoldersBackup(settingsModel);

            if(foldersBackup.ReadSettings())
            {
                Properties.ActiveUser = foldersBackup.SettingsModel.User;
                Properties.SettingsModel = foldersBackup.SettingsModel;
                return new Response { Mensagem = "Login efetuado com sucesso!", Success = true };
            }

            return new Response { Mensagem = "Usuário ou senha incorreto", Success = false };
        }
    }
}
