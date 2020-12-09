using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Backup.APP.Views.Forms
{
    public partial class FrmLogin : Form
    {
        public bool Sucess { get; set; } = false;

        public FrmLogin()
        {
            InitializeComponent();
            TransparencyKey = SystemColors.HotTrack;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {

        }

        private void Bnt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Login.PerformClick();
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            ChangeGB();
        }

        private void ChangeGB()
        {
            Gb_newAcc.Enabled = !Gb_newAcc.Enabled;
            Gb_newAcc.Visible = !Gb_newAcc.Visible;
            Gb_Login.Enabled = !Gb_Login.Enabled;
            Gb_Login.Visible = !Gb_Login.Visible;

            Txt_username_create.Focus();
            Txt_username.Focus();
        }

        private void Lbl_createNewAcc_Click(object sender, EventArgs e)
        {
            ChangeGB();
        }
    }
}
