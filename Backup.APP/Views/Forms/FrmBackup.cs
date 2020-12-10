using Backup.APP.Classes;
using Backup.APP.Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            StartupApp startupApp = new StartupApp();

            if (!startupApp.StartWithWindows)
            {
                startupApp.SetStartup();
            }

            startupApp.RemoveStartWithWindows();

            notifyIcon1.Text = "Backup directory";
            notifyIcon1.Icon = Resources.notify;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            //if (Properties.ActiveUser == null)
            //{
            //    FrmLogin frmLogin = new FrmLogin();
            //    frmLogin.ShowDialog();

            //    if (!frmLogin.Sucess)
            //    {
            //        Close();
            //        return;
            //    }
            //}
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            allowVisible = true;
            Show();
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!allowVisible)
            {
                value = false;
                if (!IsHandleCreated) CreateHandle();
            }

            base.SetVisibleCore(value);
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
