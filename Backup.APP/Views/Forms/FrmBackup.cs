using Backup.APP.Classes;
using Backup.APP.Classes.Themes;
using Backup.APP.Library;
using Backup.APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup.APP.Views.Forms
{
    public partial class FrmBackup : MainForm
    {
        private bool allowVisible;
        private bool allowClose;
        public FrmBackup()
        {
            InitializeComponent();
            Login();
            AddEvents();
        }

        private void AddEvents()
        {
            BTN_activity.Click += new EventHandler(ClickButtonsMenu);
            BTN_index.Click += new EventHandler(ClickButtonsMenu);
            BTN_info.Click += new EventHandler(ClickButtonsMenu);
            BTN_addnewbackup.Click += new EventHandler(ClickButtonsMenu);
            BTN_settings.Click += new EventHandler(ClickButtonsMenu);
            BTN_usermenu.Click += new EventHandler(ClickButtonsMenu);
            P_top.MouseDown += new MouseEventHandler(MouseDown);
            P_top.MouseMove += new MouseEventHandler(MouseMove);
            P_top.MouseUp += new MouseEventHandler(MouseUp);
        }

        private void UserLoad()
        {
            LoadTreeViewBackup();

        }

        /// <summary>
        /// load the tree view with foldersbackup of settings model
        /// </summary>
        private void LoadTreeViewBackup()
        {
            Tv_backups.Nodes.Clear();
            foreach (var item in Properties.SettingsModel.FoldersBackupModels)
            {
                AddTreeNodeBackup(item);
            }
        }

        private void AddNewFolderBackup(object sender, EventArgs e)
        {
            List<FileInfo> fileInfos = new List<FileInfo>();

            foreach (string fileChecked in ucNewBackup1.CLB_ignoreFiles.CheckedItems)
            {
                fileInfos.Add(ucNewBackup1.FilesIgnore[int.Parse(fileChecked.Substring(0, 1))]);
            }

            var FoldersBackupModel = new FoldersBackupModel(
                ucNewBackup1.TXT_namedescription.Text,
                new DirectoryInfo(ucNewBackup1.TXT_source.Text),
                new DirectoryInfo(ucNewBackup1.TXT_target.Text),
                fileInfos, null);

            Properties.SettingsModel.FoldersBackupModels.Add(FoldersBackupModel);
            AddTreeNodeBackup(FoldersBackupModel);

            new FoldersBackup(Properties.SettingsModel).WriteSettings();

            ucNewBackup1.ClearControls();
            BTN_save.Click -= new EventHandler(AddNewFolderBackup); //nao ta legal.. preciso que ao cadastrar saia da pagina de cadastro, pode sei la enviar para a pagina de atividades...
        }


        /// <summary>
        /// add a new folderBackup in tree view
        /// </summary>
        /// <param name="model"></param>
        private void AddTreeNodeBackup(FoldersBackupModel model)
        {
            List<TreeNode> filesIgnored = new List<TreeNode>();

            model.FilesIgnore.ForEach(x =>
            {
                var fileInfo = new FileInfo(x);
                filesIgnored.Add(new TreeNode($"{fileInfo.Directory.Name} / {fileInfo.Name}"));
            });

            Tv_backups.Nodes.Add(
                new TreeNode(
                    model.NameDescription, new TreeNode[] {
                            new TreeNode($"Source/ {new DirectoryInfo(model.Source).Name}"),
                            new TreeNode($"Target/ {new DirectoryInfo(model.Target).Name}"),
                            new TreeNode("files ignored", filesIgnored.ToArray()),
                            new TreeNode(model.LastBackup.HasValue ? model.LastBackup.ToString() : "never performed")
                    }));
        }

        private void Login()
        {
            if (Properties.ActiveUser == null)
            {
                bool success = false;

                //checks if an application is running
                var process = System.Diagnostics.Process.GetCurrentProcess();
                var processRunning = System.Diagnostics.Process.GetProcessesByName(process.ProcessName).Any(x => x.Id != process.Id);

                //checks if existis form open
                var frmLoginOpen = Application.OpenForms[nameof(FrmLogin)] != null;

                if (!processRunning && !frmLoginOpen)
                {
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.ShowDialog();

                    success = frmLogin.Sucess;
                }

                if (!success)
                {
                    allowClose = true;
                }
                else
                {
                    ucWelcome1.BringToFront();
                    UserLoad();
                    ShowForm();
                    ChooseTheme(false);
                }
            }
            else
            {
                ucIndex1.BringToFront();
                ShowForm();
            }
        }

        private void ShowForm()
        {
            allowVisible = true;
            Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Login();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!IsHandleCreated) CreateHandle();
            }

            base.SetVisibleCore(value);

            if (allowClose) { Close(); }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                Hide();
                e.Cancel = true;
            }
            base.OnFormClosing(e);
        }

        private void ucNewBackup1_Load(object sender, EventArgs e)
        {

        }

        private void BTN_close_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("If you close the application, it will not be possible to perform backups.\n\n" +
                "You can choose to minimize, so that the application runs in the background and you can open " +
                "it whenever you want by clicking on \"Hidden icons\" in your taskbar.",
                "Are you sure you want to close the application?",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                allowClose = true;
                Close();
            }
        }

        private void BTN_minimize_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The application will continue to run normally and you can open it by clicking on \"hidden icons\" on your taskbar",
                "Application will be minimized",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            Close();
        }

        private void BTN_theme_Click(object sender, EventArgs e)
        {
            ChooseTheme(true);
            new FoldersBackup(Properties.SettingsModel).WriteSettings();
        }

        private void ChooseTheme(bool change)
        {
            string nameTheme = Properties.ActiveUser.RememberUser.Theme;

            if (nameTheme == nameof(DarkTheme))
            {
                if (change)
                {
                    new LightTheme().ChooseTheme(new OpenForms());

                }
                else
                {
                    new DarkTheme().ChooseTheme(new OpenForms());
                }
            }
            else
            {
                if (change)
                {
                    new DarkTheme().ChooseTheme(new OpenForms());
                }
                else
                {
                    new LightTheme().ChooseTheme(new OpenForms());
                }
            }
        }

        private void FrmBackup_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F12:
                    var dialogResult = MessageBox.Show("Log out?", string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.OK)
                    {
                        Properties.ActiveUser = null;
                        Properties.SettingsModel = null;
                        Close();
                        Login();
                    }

                    break;
                default:
                    break;
            }

        }

        private void ClickButtonsMenu(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            SelectedButtonMenu(btn.Location.X, btn.Size.Width);

            BTN_save.Click -= null; // isso aqui nao funciona ... depois testar se add -= para todos os metodos vai dar algum pau
            //ideia é deixar esse botao para salvar todos os usercontrol.. ou seja, ele vai chamar o metodo de addnewfolder, no futuro vai ter o metodo salvar alteracoes usuario.. assim por diante

            switch (btn.Name)
            {
                case nameof(BTN_activity):
                    ucActivity1.BringToFront();
                    break;
                case nameof(BTN_index):
                    ucIndex1.BringToFront();
                    break;
                case nameof(BTN_info):
                    ucInfo1.BringToFront();
                    break;
                case nameof(BTN_addnewbackup):
                    ucNewBackup1.BringToFront();
                    BTN_save.BringToFront();
                    BTN_save.Click += new EventHandler(AddNewFolderBackup);
                    break;
                case nameof(BTN_settings):
                    ucSettings1.BringToFront();
                    break;
                case nameof(BTN_usermenu):
                    ucUserAccount1.BringToFront();
                    break;
                default:
                    break;
            }
        }

        private void SelectedButtonMenu(int locationX, int width)
        {
            P_selectedButton.Location = new Point(locationX, 34);
            P_selectedButton.Size = new Size(width, 10);
        }

        public void StartProgressBar(string description, Action action)
        {
            ucLoading1.LBL_description.Text = description;
            ucLoading1.LBL_operation.Text = "checking process ...";
            ucLoading1.LBL_percent.Text = "0%";

            ucLoading1.BringToFront();
            Task task = new Task(action);
            task.Start();
        }
    }
}
