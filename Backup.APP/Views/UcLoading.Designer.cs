
namespace Backup.APP.Views
{
    partial class UcLoading
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PB_loading = new System.Windows.Forms.ProgressBar();
            this.LBL_tittle = new System.Windows.Forms.Label();
            this.LBL_description = new System.Windows.Forms.Label();
            this.LBL_operation = new System.Windows.Forms.Label();
            this.LBL_percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1075, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 575);
            this.panel4.TabIndex = 25;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1075, 4);
            this.panel6.TabIndex = 27;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 571);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1075, 4);
            this.panel5.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 567);
            this.panel3.TabIndex = 30;
            // 
            // PB_loading
            // 
            this.PB_loading.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PB_loading.Location = new System.Drawing.Point(102, 405);
            this.PB_loading.Name = "PB_loading";
            this.PB_loading.Size = new System.Drawing.Size(811, 60);
            this.PB_loading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PB_loading.TabIndex = 31;
            // 
            // LBL_tittle
            // 
            this.LBL_tittle.AutoSize = true;
            this.LBL_tittle.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_tittle.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_tittle.Location = new System.Drawing.Point(41, 45);
            this.LBL_tittle.Name = "LBL_tittle";
            this.LBL_tittle.Size = new System.Drawing.Size(402, 106);
            this.LBL_tittle.TabIndex = 35;
            this.LBL_tittle.Text = "Loading ...";
            // 
            // LBL_description
            // 
            this.LBL_description.AutoSize = true;
            this.LBL_description.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_description.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_description.Location = new System.Drawing.Point(162, 171);
            this.LBL_description.Name = "LBL_description";
            this.LBL_description.Size = new System.Drawing.Size(636, 59);
            this.LBL_description.TabIndex = 36;
            this.LBL_description.Text = "small description for the process";
            // 
            // LBL_operation
            // 
            this.LBL_operation.AutoSize = true;
            this.LBL_operation.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LBL_operation.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_operation.Location = new System.Drawing.Point(109, 360);
            this.LBL_operation.Name = "LBL_operation";
            this.LBL_operation.Size = new System.Drawing.Size(334, 31);
            this.LBL_operation.TabIndex = 37;
            this.LBL_operation.Text = "what\'s going on at the moment";
            // 
            // LBL_percent
            // 
            this.LBL_percent.AutoSize = true;
            this.LBL_percent.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBL_percent.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_percent.Location = new System.Drawing.Point(931, 415);
            this.LBL_percent.Name = "LBL_percent";
            this.LBL_percent.Size = new System.Drawing.Size(61, 41);
            this.LBL_percent.TabIndex = 38;
            this.LBL_percent.Text = "0%";
            // 
            // UcLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.Controls.Add(this.LBL_percent);
            this.Controls.Add(this.LBL_operation);
            this.Controls.Add(this.LBL_description);
            this.Controls.Add(this.LBL_tittle);
            this.Controls.Add(this.PB_loading);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "UcLoading";
            this.Size = new System.Drawing.Size(1079, 575);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LBL_tittle;
        public System.Windows.Forms.Label LBL_description;
        public System.Windows.Forms.ProgressBar PB_loading;
        public System.Windows.Forms.Label LBL_operation;
        public System.Windows.Forms.Label LBL_percent;
    }
}
