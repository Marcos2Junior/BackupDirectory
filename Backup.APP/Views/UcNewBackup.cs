using Backup.APP.Library;
using Backup.APP.Models;
using Backup.APP.Views.Forms;
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
            if (FoldersBackupModel != null)
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
                        var frm = (FrmBackup)Application.OpenForms[nameof(FrmBackup)];
                        frm.ucLoading1.BringToFront();
                        CLB_ignoreFiles.Items.Clear();
                        frm.StartProgressBar("Selecting files", new Action(() =>
                        {
                            frm.ucLoading1.UpdateProgressBar(0, $"selecting directory {folderBrowserDialog1.SelectedPath}");
                            System.Threading.Thread.Sleep(1000);

                            TXT_source.Invoke(new Action(() => TXT_source.Text = folderBrowserDialog1.SelectedPath));

                            Properties.SettingsModel.User.RememberUser.LastDirectorySource = folderBrowserDialog1.SelectedPath;
                            frm.ucLoading1.UpdateProgressBar(0, "adding directory path in user memory");
                            System.Threading.Thread.Sleep(1000);

                            var files = new DirectoryInfo(folderBrowserDialog1.SelectedPath).GetFiles("*.*", SearchOption.AllDirectories);

                            frm.ucLoading1.UpdateProgressBar(0, $"selecting {files.Length} files");
                            System.Threading.Thread.Sleep(1000);

                            for (int i = 0; i < files.Length; i++)
                            {
                                string fileName = $"{files[i].Directory.Name} / {files[i].Name}";
                                frm.ucLoading1.UpdateProgressBar(SelectPercentToProgress(i, files.Length), $"checking file {fileName }");
                                CLB_ignoreFiles.Invoke(new Action(() => CLB_ignoreFiles.Items.Add(fileName)));
                            }

                            frm.ucLoading1.UpdateProgressBar(100, $"successfull");

                            System.Threading.Thread.Sleep(1000);
                            frm.Invoke(new Action(() => frm.ucNewBackup1.BringToFront()));
                        }));

                    }
                    else
                    {
                        TXT_target.Text = folderBrowserDialog1.SelectedPath;
                        Properties.SettingsModel.User.RememberUser.LastDirectoryTarget = folderBrowserDialog1.SelectedPath;
                    }
                }
            }
        }

        private int SelectPercentToProgress(int value, int total)
        {
            var interval = total / 100;
            if (value == 0) { value++; }

            if(interval == 0) { return 100; }

            var percent = value / interval;

            return percent > 100 ? 100 : percent;
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
    }
}
