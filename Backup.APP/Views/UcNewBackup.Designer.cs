
namespace Backup.APP.Views
{
    partial class UcNewBackup
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcNewBackup));
            this.BTN_save = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BTN_newsource = new System.Windows.Forms.Button();
            this.TXT_source = new System.Windows.Forms.TextBox();
            this.TXT_target = new System.Windows.Forms.TextBox();
            this.BTN_newtarget = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CLB_ignoreFiles = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TXT_namedescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GB_interval = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NUP_minutes = new System.Windows.Forms.NumericUpDown();
            this.NUP_days = new System.Windows.Forms.NumericUpDown();
            this.NUP_hours = new System.Windows.Forms.NumericUpDown();
            this.RB_automatic = new System.Windows.Forms.RadioButton();
            this.RB_manual = new System.Windows.Forms.RadioButton();
            this.TXT_backupManual = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.GB_interval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_hours)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_save
            // 
            this.BTN_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_save.FlatAppearance.BorderSize = 0;
            this.BTN_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_save.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_save.Image = ((System.Drawing.Image)(resources.GetObject("BTN_save.Image")));
            this.BTN_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTN_save.Location = new System.Drawing.Point(945, 499);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(100, 50);
            this.BTN_save.TabIndex = 0;
            this.BTN_save.Text = "Save";
            this.BTN_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTN_save.UseVisualStyleBackColor = true;
            // 
            // BTN_newsource
            // 
            this.BTN_newsource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_newsource.FlatAppearance.BorderSize = 0;
            this.BTN_newsource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_newsource.Image = ((System.Drawing.Image)(resources.GetObject("BTN_newsource.Image")));
            this.BTN_newsource.Location = new System.Drawing.Point(986, 47);
            this.BTN_newsource.Name = "BTN_newsource";
            this.BTN_newsource.Size = new System.Drawing.Size(52, 46);
            this.BTN_newsource.TabIndex = 1;
            this.BTN_newsource.UseVisualStyleBackColor = true;
            // 
            // TXT_source
            // 
            this.TXT_source.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TXT_source.ForeColor = System.Drawing.SystemColors.Control;
            this.TXT_source.Location = new System.Drawing.Point(538, 57);
            this.TXT_source.Name = "TXT_source";
            this.TXT_source.ReadOnly = true;
            this.TXT_source.Size = new System.Drawing.Size(432, 27);
            this.TXT_source.TabIndex = 2;
            // 
            // TXT_target
            // 
            this.TXT_target.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TXT_target.ForeColor = System.Drawing.SystemColors.Control;
            this.TXT_target.Location = new System.Drawing.Point(538, 127);
            this.TXT_target.Name = "TXT_target";
            this.TXT_target.ReadOnly = true;
            this.TXT_target.Size = new System.Drawing.Size(432, 27);
            this.TXT_target.TabIndex = 4;
            // 
            // BTN_newtarget
            // 
            this.BTN_newtarget.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_newtarget.FlatAppearance.BorderSize = 0;
            this.BTN_newtarget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_newtarget.Image = ((System.Drawing.Image)(resources.GetObject("BTN_newtarget.Image")));
            this.BTN_newtarget.Location = new System.Drawing.Point(986, 117);
            this.BTN_newtarget.Name = "BTN_newtarget";
            this.BTN_newtarget.Size = new System.Drawing.Size(52, 46);
            this.BTN_newtarget.TabIndex = 3;
            this.BTN_newtarget.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Target";
            // 
            // CLB_ignoreFiles
            // 
            this.CLB_ignoreFiles.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CLB_ignoreFiles.ForeColor = System.Drawing.SystemColors.Control;
            this.CLB_ignoreFiles.FormattingEnabled = true;
            this.CLB_ignoreFiles.Location = new System.Drawing.Point(538, 217);
            this.CLB_ignoreFiles.Name = "CLB_ignoreFiles";
            this.CLB_ignoreFiles.Size = new System.Drawing.Size(506, 268);
            this.CLB_ignoreFiles.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ignore files";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name description";
            // 
            // TXT_namedescription
            // 
            this.TXT_namedescription.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TXT_namedescription.ForeColor = System.Drawing.SystemColors.Control;
            this.TXT_namedescription.Location = new System.Drawing.Point(48, 57);
            this.TXT_namedescription.Name = "TXT_namedescription";
            this.TXT_namedescription.Size = new System.Drawing.Size(432, 27);
            this.TXT_namedescription.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(508, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 495);
            this.panel1.TabIndex = 11;
            // 
            // GB_interval
            // 
            this.GB_interval.BackColor = System.Drawing.Color.Transparent;
            this.GB_interval.Controls.Add(this.label9);
            this.GB_interval.Controls.Add(this.label7);
            this.GB_interval.Controls.Add(this.label6);
            this.GB_interval.Controls.Add(this.label5);
            this.GB_interval.Controls.Add(this.NUP_minutes);
            this.GB_interval.Controls.Add(this.NUP_days);
            this.GB_interval.Controls.Add(this.NUP_hours);
            this.GB_interval.Location = new System.Drawing.Point(51, 191);
            this.GB_interval.Name = "GB_interval";
            this.GB_interval.Size = new System.Drawing.Size(429, 126);
            this.GB_interval.TabIndex = 15;
            this.GB_interval.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(165, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fixed execution interval";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "minutes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "days";
            // 
            // NUP_minutes
            // 
            this.NUP_minutes.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NUP_minutes.ForeColor = System.Drawing.SystemColors.Control;
            this.NUP_minutes.Location = new System.Drawing.Point(283, 65);
            this.NUP_minutes.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NUP_minutes.Name = "NUP_minutes";
            this.NUP_minutes.Size = new System.Drawing.Size(84, 27);
            this.NUP_minutes.TabIndex = 2;
            // 
            // NUP_days
            // 
            this.NUP_days.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NUP_days.ForeColor = System.Drawing.SystemColors.Control;
            this.NUP_days.Location = new System.Drawing.Point(67, 65);
            this.NUP_days.Name = "NUP_days";
            this.NUP_days.Size = new System.Drawing.Size(84, 27);
            this.NUP_days.TabIndex = 1;
            this.NUP_days.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUP_hours
            // 
            this.NUP_hours.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.NUP_hours.ForeColor = System.Drawing.SystemColors.Control;
            this.NUP_hours.Location = new System.Drawing.Point(175, 65);
            this.NUP_hours.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.NUP_hours.Name = "NUP_hours";
            this.NUP_hours.Size = new System.Drawing.Size(84, 27);
            this.NUP_hours.TabIndex = 0;
            // 
            // RB_automatic
            // 
            this.RB_automatic.AutoSize = true;
            this.RB_automatic.Checked = true;
            this.RB_automatic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_automatic.Location = new System.Drawing.Point(73, 4);
            this.RB_automatic.Name = "RB_automatic";
            this.RB_automatic.Size = new System.Drawing.Size(99, 24);
            this.RB_automatic.TabIndex = 16;
            this.RB_automatic.TabStop = true;
            this.RB_automatic.Text = "Automatic";
            this.RB_automatic.UseVisualStyleBackColor = true;
            this.RB_automatic.Click += new System.EventHandler(this.RB_automatic_Click);
            // 
            // RB_manual
            // 
            this.RB_manual.AutoSize = true;
            this.RB_manual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RB_manual.Location = new System.Drawing.Point(263, 4);
            this.RB_manual.Name = "RB_manual";
            this.RB_manual.Size = new System.Drawing.Size(79, 24);
            this.RB_manual.TabIndex = 17;
            this.RB_manual.Text = "Manual";
            this.RB_manual.UseVisualStyleBackColor = true;
            this.RB_manual.Click += new System.EventHandler(this.RB_manual_Click);
            // 
            // TXT_backupManual
            // 
            this.TXT_backupManual.Location = new System.Drawing.Point(118, 191);
            this.TXT_backupManual.Name = "TXT_backupManual";
            this.TXT_backupManual.ReadOnly = true;
            this.TXT_backupManual.Size = new System.Drawing.Size(289, 27);
            this.TXT_backupManual.TabIndex = 18;
            this.TXT_backupManual.Text = "Backup will be performed manually";
            this.TXT_backupManual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Choose an execution mode";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.RB_automatic);
            this.panel2.Controls.Add(this.RB_manual);
            this.panel2.Location = new System.Drawing.Point(51, 138);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(429, 35);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 566);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1088, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 566);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(4, 562);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1084, 4);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(4, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1084, 4);
            this.panel6.TabIndex = 24;
            // 
            // UcNewBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GB_interval);
            this.Controls.Add(this.TXT_backupManual);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TXT_namedescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CLB_ignoreFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_target);
            this.Controls.Add(this.BTN_newtarget);
            this.Controls.Add(this.TXT_source);
            this.Controls.Add(this.BTN_newsource);
            this.Controls.Add(this.BTN_save);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "UcNewBackup";
            this.Size = new System.Drawing.Size(1092, 566);
            this.GB_interval.ResumeLayout(false);
            this.GB_interval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUP_hours)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox GB_interval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RB_automatic;
        private System.Windows.Forms.RadioButton RB_manual;
        private System.Windows.Forms.TextBox TXT_backupManual;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.Button BTN_save;
        public System.Windows.Forms.Button BTN_newsource;
        public System.Windows.Forms.Button BTN_newtarget;
        public System.Windows.Forms.TextBox TXT_source;
        public System.Windows.Forms.TextBox TXT_target;
        public System.Windows.Forms.CheckedListBox CLB_ignoreFiles;
        public System.Windows.Forms.TextBox TXT_namedescription;
        public System.Windows.Forms.NumericUpDown NUP_minutes;
        public System.Windows.Forms.NumericUpDown NUP_days;
        public System.Windows.Forms.NumericUpDown NUP_hours;
    }
}
