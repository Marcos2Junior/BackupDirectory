
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
            this.BTN_theme = new System.Windows.Forms.Button();
            this.PB_logo = new System.Windows.Forms.PictureBox();
            this.LBL_logo = new System.Windows.Forms.Label();
            this.BTN_usermenu = new System.Windows.Forms.Button();
            this.BTN_settings = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.BTN_newbackup = new System.Windows.Forms.Button();
            this.ucWelcome1 = new Backup.APP.Views.UcWelcome();
            this.ucIndex1 = new Backup.APP.Views.UcIndex();
            this.BTN_info = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.P_selectedButton = new System.Windows.Forms.Panel();
            this.BTN_activity = new System.Windows.Forms.Button();
            this.BTN_index = new System.Windows.Forms.Button();
            this.ucInfo1 = new Backup.APP.Views.UcInfo();
            this.ucUserAccount1 = new Backup.APP.Views.UcUserAccount();
            this.ucSettings1 = new Backup.APP.Views.UcSettings();
            this.ucActivity1 = new Backup.APP.Views.UcActivity();
            this.groupBox1.SuspendLayout();
            this.P_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.ucNewBackup1.Location = new System.Drawing.Point(541, 157);
            this.ucNewBackup1.Name = "ucNewBackup1";
            this.ucNewBackup1.Size = new System.Drawing.Size(1079, 577);
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
            this.P_top.Controls.Add(this.BTN_theme);
            this.P_top.Controls.Add(this.PB_logo);
            this.P_top.Controls.Add(this.LBL_logo);
            this.P_top.Controls.Add(this.BTN_minimize);
            this.P_top.Controls.Add(this.BTN_close);
            this.P_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.P_top.Location = new System.Drawing.Point(0, 0);
            this.P_top.Name = "P_top";
            this.P_top.Size = new System.Drawing.Size(1667, 82);
            this.P_top.TabIndex = 9;
            // 
            // BTN_theme
            // 
            this.BTN_theme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_theme.FlatAppearance.BorderSize = 0;
            this.BTN_theme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_theme.Image = ((System.Drawing.Image)(resources.GetObject("BTN_theme.Image")));
            this.BTN_theme.Location = new System.Drawing.Point(1512, 10);
            this.BTN_theme.Name = "BTN_theme";
            this.BTN_theme.Size = new System.Drawing.Size(45, 38);
            this.BTN_theme.TabIndex = 12;
            this.BTN_theme.UseVisualStyleBackColor = true;
            this.BTN_theme.Click += new System.EventHandler(this.BTN_theme_Click);
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
            // LBL_logo
            // 
            this.LBL_logo.AutoSize = true;
            this.LBL_logo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_logo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LBL_logo.Location = new System.Drawing.Point(73, 23);
            this.LBL_logo.Name = "LBL_logo";
            this.LBL_logo.Size = new System.Drawing.Size(228, 38);
            this.LBL_logo.TabIndex = 9;
            this.LBL_logo.Text = "Backup Directory";
            this.LBL_logo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTN_usermenu
            // 
            this.BTN_usermenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_usermenu.FlatAppearance.BorderSize = 0;
            this.BTN_usermenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_usermenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_usermenu.Image = ((System.Drawing.Image)(resources.GetObject("BTN_usermenu.Image")));
            this.BTN_usermenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_usermenu.Location = new System.Drawing.Point(556, 2);
            this.BTN_usermenu.Name = "BTN_usermenu";
            this.BTN_usermenu.Size = new System.Drawing.Size(130, 38);
            this.BTN_usermenu.TabIndex = 13;
            this.BTN_usermenu.Text = "Account";
            this.BTN_usermenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_usermenu.UseVisualStyleBackColor = true;
            // 
            // BTN_settings
            // 
            this.BTN_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_settings.FlatAppearance.BorderSize = 0;
            this.BTN_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_settings.Image = ((System.Drawing.Image)(resources.GetObject("BTN_settings.Image")));
            this.BTN_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_settings.Location = new System.Drawing.Point(705, 2);
            this.BTN_settings.Name = "BTN_settings";
            this.BTN_settings.Size = new System.Drawing.Size(132, 38);
            this.BTN_settings.TabIndex = 11;
            this.BTN_settings.Text = "Settings";
            this.BTN_settings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_settings.UseVisualStyleBackColor = true;
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
            this.BTN_newbackup.FlatAppearance.BorderSize = 0;
            this.BTN_newbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_newbackup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_newbackup.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_newbackup.Image = ((System.Drawing.Image)(resources.GetObject("BTN_newbackup.Image")));
            this.BTN_newbackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_newbackup.Location = new System.Drawing.Point(372, 2);
            this.BTN_newbackup.Name = "BTN_newbackup";
            this.BTN_newbackup.Size = new System.Drawing.Size(165, 38);
            this.BTN_newbackup.TabIndex = 27;
            this.BTN_newbackup.Text = "New Backup";
            this.BTN_newbackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_newbackup.UseVisualStyleBackColor = true;
            // 
            // ucWelcome1
            // 
            this.ucWelcome1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucWelcome1.Location = new System.Drawing.Point(541, 157);
            this.ucWelcome1.Name = "ucWelcome1";
            this.ucWelcome1.Size = new System.Drawing.Size(1079, 577);
            this.ucWelcome1.TabIndex = 28;
            // 
            // ucIndex1
            // 
            this.ucIndex1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucIndex1.Location = new System.Drawing.Point(541, 157);
            this.ucIndex1.Name = "ucIndex1";
            this.ucIndex1.Size = new System.Drawing.Size(1079, 577);
            this.ucIndex1.TabIndex = 29;
            // 
            // BTN_info
            // 
            this.BTN_info.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_info.FlatAppearance.BorderSize = 0;
            this.BTN_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_info.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_info.Image = ((System.Drawing.Image)(resources.GetObject("BTN_info.Image")));
            this.BTN_info.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_info.Location = new System.Drawing.Point(856, 2);
            this.BTN_info.Name = "BTN_info";
            this.BTN_info.Size = new System.Drawing.Size(176, 38);
            this.BTN_info.TabIndex = 14;
            this.BTN_info.Text = "Informations";
            this.BTN_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_info.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.P_selectedButton);
            this.panel1.Controls.Add(this.BTN_activity);
            this.panel1.Controls.Add(this.BTN_index);
            this.panel1.Controls.Add(this.BTN_newbackup);
            this.panel1.Controls.Add(this.BTN_info);
            this.panel1.Controls.Add(this.BTN_settings);
            this.panel1.Controls.Add(this.BTN_usermenu);
            this.panel1.Location = new System.Drawing.Point(541, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1079, 47);
            this.panel1.TabIndex = 30;
            // 
            // P_selectedButton
            // 
            this.P_selectedButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.P_selectedButton.Location = new System.Drawing.Point(18, 45);
            this.P_selectedButton.Name = "P_selectedButton";
            this.P_selectedButton.Size = new System.Drawing.Size(139, 10);
            this.P_selectedButton.TabIndex = 31;
            // 
            // BTN_activity
            // 
            this.BTN_activity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_activity.FlatAppearance.BorderSize = 0;
            this.BTN_activity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_activity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_activity.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_activity.Image = ((System.Drawing.Image)(resources.GetObject("BTN_activity.Image")));
            this.BTN_activity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_activity.Location = new System.Drawing.Point(163, 2);
            this.BTN_activity.Name = "BTN_activity";
            this.BTN_activity.Size = new System.Drawing.Size(190, 38);
            this.BTN_activity.TabIndex = 29;
            this.BTN_activity.Text = "System activity";
            this.BTN_activity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_activity.UseVisualStyleBackColor = true;
            // 
            // BTN_index
            // 
            this.BTN_index.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_index.FlatAppearance.BorderSize = 0;
            this.BTN_index.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_index.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_index.ForeColor = System.Drawing.SystemColors.Control;
            this.BTN_index.Image = ((System.Drawing.Image)(resources.GetObject("BTN_index.Image")));
            this.BTN_index.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_index.Location = new System.Drawing.Point(30, 2);
            this.BTN_index.Name = "BTN_index";
            this.BTN_index.Size = new System.Drawing.Size(114, 38);
            this.BTN_index.TabIndex = 28;
            this.BTN_index.Text = "Home";
            this.BTN_index.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_index.UseVisualStyleBackColor = true;
            // 
            // ucInfo1
            // 
            this.ucInfo1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucInfo1.ForeColor = System.Drawing.SystemColors.Control;
            this.ucInfo1.Location = new System.Drawing.Point(541, 157);
            this.ucInfo1.Name = "ucInfo1";
            this.ucInfo1.Size = new System.Drawing.Size(1079, 577);
            this.ucInfo1.TabIndex = 31;
            // 
            // ucUserAccount1
            // 
            this.ucUserAccount1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucUserAccount1.ForeColor = System.Drawing.SystemColors.Control;
            this.ucUserAccount1.Location = new System.Drawing.Point(541, 157);
            this.ucUserAccount1.Name = "ucUserAccount1";
            this.ucUserAccount1.Size = new System.Drawing.Size(1079, 577);
            this.ucUserAccount1.TabIndex = 32;
            // 
            // ucSettings1
            // 
            this.ucSettings1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucSettings1.ForeColor = System.Drawing.SystemColors.Control;
            this.ucSettings1.Location = new System.Drawing.Point(541, 157);
            this.ucSettings1.Name = "ucSettings1";
            this.ucSettings1.Size = new System.Drawing.Size(1079, 577);
            this.ucSettings1.TabIndex = 33;
            // 
            // ucActivity1
            // 
            this.ucActivity1.BackColor = System.Drawing.SystemColors.Desktop;
            this.ucActivity1.ForeColor = System.Drawing.SystemColors.Control;
            this.ucActivity1.Location = new System.Drawing.Point(541, 157);
            this.ucActivity1.Name = "ucActivity1";
            this.ucActivity1.Size = new System.Drawing.Size(1079, 577);
            this.ucActivity1.TabIndex = 5;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1667, 770);
            this.Controls.Add(this.ucActivity1);
            this.Controls.Add(this.ucSettings1);
            this.Controls.Add(this.ucUserAccount1);
            this.Controls.Add(this.ucInfo1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucIndex1);
            this.Controls.Add(this.ucWelcome1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.P_top);
            this.Controls.Add(this.ucNewBackup1);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBackup";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBackup_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.P_top.ResumeLayout(false);
            this.P_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LBL_logo;
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
        private UcWelcome ucWelcome1;
        private UcIndex ucIndex1;
        public System.Windows.Forms.Button BTN_info;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button BTN_activity;
        public System.Windows.Forms.Button BTN_index;
        private System.Windows.Forms.Panel P_selectedButton;
        private UcInfo ucInfo1;
        private UcUserAccount ucUserAccount1;
        private UcSettings ucSettings1;
        private UcActivity ucActivity1;
    }
}

