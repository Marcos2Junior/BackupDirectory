using Backup.APP.Library;
using Backup.APP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Backup.APP.Views
{
    public partial class UcNewBackup : UserControl
    {
        public FoldersBackupModel FoldersBackupModel { get; private set; }
        public UcNewBackup()
        {
            InitializeComponent();
            EnabledIntervalValueChanged(true);
            AddEvents();
        }

        private void Load()
        {
            if(FoldersBackupModel != null)
            {
                //txt
            }
        }


        private void RB_automatic_Click(object sender, EventArgs e)
        {
            RB_manual.Checked = false;
            GB_interval.Visible = true;
        }

        private void RB_manual_Click(object sender, EventArgs e)
        {
            RB_automatic.Checked = false;
            GB_interval.Visible = false;
        }

        private void ChangeInterval(object sender, EventArgs e)
        {
            EnabledIntervalValueChanged(false);
            //esse esquema eu achei muuuuuuuuuuuuito insano hahaha
            TimeSpan ts = new TimeSpan((int)NUP_days.Value, (int)NUP_hours.Value, (int)NUP_minutes.Value, 0);
            if (ts.Days > 100) { ts = new TimeSpan(100, 0, 0); }

            NUP_days.Value = ts.Days;
            NUP_hours.Value = ts.Hours;
            NUP_minutes.Value = ts.Minutes;

            EnabledIntervalValueChanged(true);
        }

        private void EnabledIntervalValueChanged(bool enabled)
        {
            if (enabled)
            {
                NUP_days.ValueChanged += new EventHandler(ChangeInterval);
                NUP_hours.ValueChanged += new EventHandler(ChangeInterval);
                NUP_minutes.ValueChanged += new EventHandler(ChangeInterval);
            }
            else
            {
                NUP_days.ValueChanged -= new EventHandler(ChangeInterval);
                NUP_hours.ValueChanged -= new EventHandler(ChangeInterval);
                NUP_minutes.ValueChanged -= new EventHandler(ChangeInterval);
            }
        }

        private void LoadDirectory(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = SelectedPath((Button)sender);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!Directory.Exists(folderBrowserDialog1.SelectedPath))
                {
                    if (MessageBox.Show("directory not found, please choose a valid path", string.Empty, MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        LoadDirectory(sender, e);
                    }
                }
                else
                {
                    if ((Button)sender == BTN_newsource)
                    {
                        TXT_source.Text = folderBrowserDialog1.SelectedPath;
                        Properties.SettingsModel.User.RememberUser.LastDirectorySource = folderBrowserDialog1.SelectedPath;

                        var files = new DirectoryInfo(folderBrowserDialog1.SelectedPath).GetFiles("*.*", SearchOption.AllDirectories);
                        CLB_ignoreFiles.Items.Clear();
                        foreach (FileInfo file in files)
                        {
                            CLB_ignoreFiles.Items.Add($"{file.Directory.Name} / {file.Name}");
                        }
                    }
                    else
                    {
                        TXT_target.Text = folderBrowserDialog1.SelectedPath;
                        Properties.SettingsModel.User.RememberUser.LastDirectoryTarget = folderBrowserDialog1.SelectedPath;
                    }
                }
            }
        }

        private string SelectedPath(Button button)
        {
            if (button == BTN_newsource)
            {
                return string.IsNullOrEmpty(Properties.ActiveUser.RememberUser.LastDirectorySource) ?
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) :
                Properties.ActiveUser.RememberUser.LastDirectorySource;
            }
            else
            {
                return string.IsNullOrEmpty(Properties.ActiveUser.RememberUser.LastDirectoryTarget) ?
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) :
                Properties.ActiveUser.RememberUser.LastDirectoryTarget;
            }
        }

        private void AddEvents()
        {
            BTN_newsource.Click += new EventHandler(LoadDirectory);
            BTN_newtarget.Click += new EventHandler(LoadDirectory);
        }

        private void UcNewBackup_Load(object sender, EventArgs e)
        {

        }

        private void UcNewBackup_Load_1(object sender, EventArgs e)
        {

        }
    }
}
