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
        public FrmBackup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            if (Properties.ActiveUser == null)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.ShowDialog();

                if (!frmLogin.Sucess)
                {
                    Close();
                    return;
                }
            }
        }
    }
}
