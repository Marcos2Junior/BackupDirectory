﻿
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Btn_GetFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(1062, 63);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 564);
            this.listBox1.TabIndex = 0;
            // 
            // Btn_GetFolder
            // 
            this.Btn_GetFolder.Location = new System.Drawing.Point(659, 406);
            this.Btn_GetFolder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btn_GetFolder.Name = "Btn_GetFolder";
            this.Btn_GetFolder.Size = new System.Drawing.Size(139, 59);
            this.Btn_GetFolder.TabIndex = 1;
            this.Btn_GetFolder.Text = "Btn_GetFolder";
            this.Btn_GetFolder.UseVisualStyleBackColor = true;
            this.Btn_GetFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 784);
            this.Controls.Add(this.Btn_GetFolder);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBackup";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmBackup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Btn_GetFolder;
    }
}

