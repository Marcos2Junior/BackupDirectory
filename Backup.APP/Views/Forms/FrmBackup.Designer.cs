
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
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.Tv_backups = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucNewBackup1 = new Backup.APP.Views.UcNewBackup();
            this.BTN_close = new System.Windows.Forms.Button();
            this.BTN_minimize = new System.Windows.Forms.Button();
            this.P_top = new System.Windows.Forms.Panel();
            this.BTN_usermenu = new System.Windows.Forms.Button();
            this.BTN_theme = new System.Windows.Forms.Button();
            this.BTN_settings = new System.Windows.Forms.Button();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BTN_newbackup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.P_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.SuspendLayout();
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
            this.Tv_backups.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Tv_backups.ForeColor = System.Drawing.SystemColors.Control;
            this.Tv_backups.Location = new System.Drawing.Point(29, 27);
            this.Tv_backups.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Tv_backups.Name = "Tv_backups";
            this.Tv_backups.Size = new System.Drawing.Size(428, 587);
            this.Tv_backups.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Tv_backups);
            this.groupBox1.Location = new System.Drawing.Point(24, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(485, 646);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory backups";
            // 
            // ucNewBackup1
            // 
            this.ucNewBackup1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucNewBackup1.ForeColor = System.Drawing.SystemColors.Control;
            this.ucNewBackup1.Location = new System.Drawing.Point(541, 159);
            this.ucNewBackup1.Name = "ucNewBackup1";
            this.ucNewBackup1.Size = new System.Drawing.Size(1079, 575);
            this.ucNewBackup1.TabIndex = 4;
            // 
            // BTN_close
            // 
            this.BTN_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_close.FlatAppearance.BorderSize = 0;
            this.BTN_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_close.Image = ((System.Drawing.Image)(resources.GetObject("BTN_close.Image")));
            this.BTN_close.Location = new System.Drawing.Point(1614, 10);
            this.BTN_close.Name = "BTN_close";
            this.BTN_close.Size = new System.Drawing.Size(45, 38);
            this.BTN_close.TabIndex = 7;
            this.BTN_close.UseVisualStyleBackColor = true;
            this.BTN_close.Click += new System.EventHandler(this.BTN_close_Click);
            // 
            // BTN_minimize
            // 
            this.BTN_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_minimize.FlatAppearance.BorderSize = 0;
            this.BTN_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_minimize.Image = ((System.Drawing.Image)(resources.GetObject("BTN_minimize.Image")));
            this.BTN_minimize.Location = new System.Drawing.Point(1563, 10);
            this.BTN_minimize.Name = "BTN_minimize";
            this.BTN_minimize.Size = new System.Drawing.Size(45, 38);
            this.BTN_minimize.TabIndex = 8;
            this.BTN_minimize.UseVisualStyleBackColor = true;
            this.BTN_minimize.Click += new System.EventHandler(this.BTN_minimize_Click);
            // 
            // P_top
            // 
            this.P_top.BackColor = System.Drawing.SystemColors.Desktop;
            this.P_top.Controls.Add(this.BTN_usermenu);
            this.P_top.Controls.Add(this.BTN_theme);
            this.P_top.Controls.Add(this.BTN_settings);
            this.P_top.Controls.Add(this.PB_logo);
            this.P_top.Controls.Add(this.label2);
            this.P_top.Controls.Add(this.BTN_minimize);
            this.P_top.Controls.Add(this.BTN_close);
            this.P_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_top.Location = new System.Drawing.Point(0, 0);
            this.P_top.Name = "P_top";
            this.P_top.Size = new System.Drawing.Size(1667, 82);
            this.P_top.TabIndex = 9;
            // 
            // BTN_usermenu
            // 
            this.BTN_usermenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_usermenu.FlatAppearance.BorderSize = 0;
            this.BTN_usermenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_usermenu.Image = ((System.Drawing.Image)(resources.GetObject("BTN_usermenu.Image")));
            this.BTN_usermenu.Location = new System.Drawing.Point(1410, 12);
            this.BTN_usermenu.Name = "BTN_usermenu";
            this.BTN_usermenu.Size = new System.Drawing.Size(45, 38);
            this.BTN_usermenu.TabIndex = 13;
            this.BTN_usermenu.UseVisualStyleBackColor = true;
            // 
            // BTN_theme
            // 
            this.BTN_theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_theme.FlatAppearance.BorderSize = 0;
            this.BTN_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_theme.Image = ((System.Drawing.Image)(resources.GetObject("BTN_theme.Image")));
            this.BTN_theme.Location = new System.Drawing.Point(1461, 12);
            this.BTN_theme.Name = "BTN_theme";
            this.BTN_theme.Size = new System.Drawing.Size(45, 38);
            this.BTN_theme.TabIndex = 12;
            this.BTN_theme.UseVisualStyleBackColor = true;
            this.BTN_theme.Click += new System.EventHandler(this.BTN_theme_Click);
            // 
            // BTN_settings
            // 
            this.BTN_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_settings.FlatAppearance.BorderSize = 0;
            this.BTN_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_settings.Image = ((System.Drawing.Image)(resources.GetObject("BTN_settings.Image")));
            this.BTN_settings.Location = new System.Drawing.Point(1512, 12);
            this.BTN_settings.Name = "BTN_settings";
            this.BTN_settings.Size = new System.Drawing.Size(45, 38);
            this.BTN_settings.TabIndex = 11;
            this.BTN_settings.UseVisualStyleBackColor = true;
            // 
            // PB_logo
            // 
            this.PB_logo.Image = ((System.Drawing.Image)(resources.GetObject("PB_logo.Image")));
            this.PB_logo.Location = new System.Drawing.Point(12, 12);
            this.PB_logo.Name = "PB_logo";
            this.PB_logo.Size = new System.Drawing.Size(58, 62);
            this.PB_logo.TabIndex = 10;
            this.PB_logo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(73, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Backup Directory";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 688);
            this.panel3.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(4, 766);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1663, 4);
            this.panel5.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1663, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 684);
            this.panel4.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(4, 82);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1659, 4);
            this.panel6.TabIndex = 26;
            // 
            // BTN_newbackup
            // 
            this.BTN_newbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_newbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_newbackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_newbackup.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_newbackup.Image = ((System.Drawing.Image)(resources.GetObject("BTN_newbackup.Image")));
            this.BTN_newbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_newbackup.Location = new System.Drawing.Point(541, 102);
            this.BTN_newbackup.Name = "BTN_newbackup";
            this.BTN_newbackup.Size = new System.Drawing.Size(221, 43);
            this.BTN_newbackup.TabIndex = 27;
            this.BTN_newbackup.Text = "Add a new backup folder";
            this.BTN_newbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_newbackup.UseVisualStyleBackColor = true;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1667, 770);
            this.Controls.Add(this.BTN_newbackup);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.P_top);
            this.Controls.Add(this.ucNewBackup1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.P_top.ResumeLayout(false);
            this.P_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Button BTN_theme;
        public System.Windows.Forms.Panel P_top;
        public UcNewBackup ucNewBackup1;
        public System.Windows.Forms.PictureBox PB_logo;
        public System.Windows.Forms.Button BTN_newbackup;
        public System.Windows.Forms.Button BTN_close;
        public System.Windows.Forms.Button BTN_minimize;
        public System.Windows.Forms.Button BTN_usermenu;
        public System.Windows.Forms.Button BTN_settings;
        public System.Windows.Forms.TreeView Tv_backups;
    }
}

