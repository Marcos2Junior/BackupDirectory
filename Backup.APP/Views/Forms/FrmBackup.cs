using Backup.APP.Classes;
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
    public partial class FrmBackup : Form
    {
        private bool allowVisible;
        private bool allowClose;
        public FrmBackup()
        {
            InitializeComponent();
            Login();
        }

        private void Startup()
        {
            StartupApp startupApp = new StartupApp();

            if (!startupApp.StartWithWindows)
            {
                startupApp.SetStartup();
            }

            startupApp.RemoveStartWithWindows();

            startupApp.CloseRegistry();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            Login();
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
            foreach (var item in Properties.SettingsModel.FoldersBackupModels)
            {
                AddTreeNodeBackup(item);
            }
        }

        private void AddNewFolderBackup()
        {
            var folderBackup = new FoldersBackupModel("name", new DirectoryInfo(""), new DirectoryInfo(""), new List<FileInfo> { }, null);
            Properties.SettingsModel.FoldersBackupModels.Add(folderBackup);
            AddTreeNodeBackup(folderBackup);

            try
            {
                new FoldersBackup(Properties.SettingsModel).WriteSettings();
            }
            catch (Exception ex)
            {
                //verificar oq fazer pq pode acontecer de na tentativa de gravar, acabar perdendo o registro do txt
                //nesse caso pensar em tentar gravar a propriedade Properties.SettingsModel em um outro arquivo ou algo assim ..

                throw;
            }
        }


        /// <summary>
        /// add a new folderBackup in tree view
        /// </summary>
        /// <param name="model"></param>
        private void AddTreeNodeBackup(FoldersBackupModel model)
        {
            List<TreeNode> filesIgnored = new List<TreeNode>();

            model.FilesIgnore.ForEach(x => filesIgnored.Add(new TreeNode($"{x.Name} . {x.Extension}")));

            Tv_backups.Nodes.Add(
                new TreeNode(
                    model.NameDescription, new TreeNode[] {
                            new TreeNode(model.Source.Name),
                            new TreeNode(model.Target.Name),
                            new TreeNode("files ignored", filesIgnored.ToArray()),
                            new TreeNode(model.LastBackup.ToString())
                    }));
        }

        private void Login()
        {
            if (Properties.ActiveUser == null)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();

                if (!frmLogin.Sucess)
                {
                    allowClose = true;
                }
                else
                {
                    UserLoad();
                    ShowForm();
                }
            }
        }

        private void ShowForm()
        {
            allowVisible = true;
            Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowForm();
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
    }
}
