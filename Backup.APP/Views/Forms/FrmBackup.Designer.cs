
namespace Backup.APP.Views.Forms
{
    partial class FrmBackup
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackup));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Btn_GetFolder = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tv_backups = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Btn_GetFolder
            // 
            this.Btn_GetFolder.Location = new System.Drawing.Point(577, 304);
            this.Btn_GetFolder.Name = "Btn_GetFolder";
            this.Btn_GetFolder.Size = new System.Drawing.Size(122, 44);
            this.Btn_GetFolder.TabIndex = 1;
            this.Btn_GetFolder.Text = "Btn_GetFolder";
            this.Btn_GetFolder.UseVisualStyleBackColor = true;
            this.Btn_GetFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Backup Directory";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Tv_backups
            // 
            this.Tv_backups.Location = new System.Drawing.Point(912, 74);
            this.Tv_backups.Name = "Tv_backups";
            this.Tv_backups.Size = new System.Drawing.Size(375, 406);
            this.Tv_backups.TabIndex = 2;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 588);
            this.Controls.Add(this.Tv_backups);
            this.Controls.Add(this.Btn_GetFolder);
            this.Name = "FrmBackup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Btn_GetFolder;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TreeView Tv_backups;
    }
}

