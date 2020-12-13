using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Backup.APP.Views
{
    public partial class UcLoading : UserControl
    {
        public UcLoading()
        {
            InitializeComponent();
        }

        public void UpdateProgressBar(int value, string comment)
        {
            Invoke((MethodInvoker)delegate
            {
                LBL_operation.Text = comment;
                LBL_percent.Text = $"{value}%";
                PB_loading.Value = value;
            });
        }
    }
}
