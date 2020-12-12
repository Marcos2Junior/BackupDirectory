using Backup.APP.Classes;
using Backup.APP.Library;
using Backup.APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Backup.APP.Views.Forms
{
    public partial class FrmLogin : MainForm
    {
        #region 1 - fields
        public bool Sucess { get; set; } = false;

        #endregion

        #region 2 - ctor
        public FrmLogin()
        {
            InitializeComponent();
            TransparencyKey = SystemColors.HotTrack;
        }
        #endregion

        #region 3 - methods
        /// <summary>
        /// create a new account
        /// </summary>
        private void NewAccount()
        {
            var model = new NewAccount
            {
                ConcordTerms = cb_terms.Checked,
                ConfirmPassword = Txt_ConfPassword_create.Text,
                Password = Txt_Password_create.Text,
                PasswordHint = Txt_PasswordHint_create.Text,
                UserName = Txt_username_create.Text
            };

            if (ModelIsValid(model))
            {
                Properties.ActiveUser = new User
                {
                    UserName = model.UserName,
                    Password = model.Password,
                    PasswordHint = model.PasswordHint,
                    FileSettings = string.Empty
                };

                new FoldersBackup(new SettingsModel
                {
                    FoldersBackupModels = new List<FoldersBackupModel>()
                }).WriteSettings();

                Txt_username_create.Clear();
                Txt_Password_create.Clear();
                Txt_PasswordHint_create.Clear();
                Txt_ConfPassword_create.Clear();
                cb_terms.Checked = false;

                ChangeGB();
                Txt_username.Text = model.UserName;
                MessageBox.Show("Por favor, confirme a sua senha para continuar.", "Cadastro realizado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Txt_password.Focus();
            }
        }
        /// <summary>
        /// check if model new account is valid and set errors in errorprovider
        /// </summary>
        /// <param name="newAccount"></param>
        /// <returns>true if model is valid</returns>
        private bool ModelIsValid(NewAccount newAccount)
        {
            var validationResults = new List<ValidationResult>();
            var contexto = new ValidationContext(newAccount, null, null);
            Validator.TryValidateObject(newAccount, contexto, validationResults, true);
            errorProvider1.Clear();
            foreach (var item in validationResults)
            {
                switch (item.MemberNames.First())
                {
                    case nameof(newAccount.UserName):
                        errorProvider1.SetError(Txt_username_create, item.ErrorMessage);
                        break;

                    case nameof(newAccount.Password):
                        errorProvider1.SetError(Txt_Password_create, item.ErrorMessage);
                        break;

                    case nameof(newAccount.ConfirmPassword):
                        errorProvider1.SetError(Txt_ConfPassword_create, item.ErrorMessage);
                        break;

                    case nameof(newAccount.PasswordHint):
                        errorProvider1.SetError(Txt_PasswordHint_create, item.ErrorMessage);
                        break;

                    case nameof(newAccount.ConcordTerms):
                        errorProvider1.SetError(cb_terms, item.ErrorMessage);
                        break;

                    default:
                        errorProvider1.SetError(Gb_newAcc, item.ErrorMessage);
                        break;
                }
            }

            return !validationResults.Any();
        }
        /// <summary>
        /// check if login is valid
        /// </summary>
        private void CheckLogin()
        {
            if (string.IsNullOrEmpty(Txt_password.Text) || string.IsNullOrEmpty(Txt_username.Text))
            {
                MessageBox.Show("Preencha os campos corretamente", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Login login = new Login(new User
            {
                UserName = Txt_username.Text,
                Password = Txt_password.Text,
                //for set new fileinfo
                FileSettings = string.Empty
            });

            var response = login.CheckLogin();

            Sucess = response.Success;

            //if true, close this form and continue execution in event load form FrmBackup
            if (Sucess)
            {
                Close();
            }
            else
            {
                MessageBox.Show(response.Mensagem, "Ops!, não foi possível realizar o login.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// change visible/enabled group box of new account and login
        /// </summary>
        private void ChangeGB()
        {
            Gb_newAcc.Enabled = !Gb_newAcc.Enabled;
            Gb_newAcc.Visible = !Gb_newAcc.Visible;
            Gb_Login.Enabled = !Gb_Login.Enabled;
            Gb_Login.Visible = !Gb_Login.Visible;

            Txt_username_create.Focus();
            Txt_username.Focus();
        }
        #endregion

        #region 4 - events

        #region 4.1 - click
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            CheckLogin();
        }
        private void Bnt_close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Btn_back_Click(object sender, EventArgs e)
        {
            ChangeGB();
        }
        private void Btn_Create_Click(object sender, EventArgs e)
        {
            NewAccount();
        }
        private void Lbl_createNewAcc_Click(object sender, EventArgs e)
        {
            ChangeGB();
            errorProvider1.Clear();
        }
        #endregion

        #region 4.2 - press key
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Login.PerformClick();
            }
        }
        #endregion

        #region 4.3 - move form

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove();
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown();
        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp();
        }

        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUp();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMove();
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown();
        }
        #endregion

        #endregion
    }
}
