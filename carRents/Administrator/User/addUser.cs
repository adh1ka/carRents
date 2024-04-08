using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Administrator.User
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        void pindah()
        {
            mngUser mngUser = new mngUser();
            mngUser.ShowDialog();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            koneksi.exit();
        }

        private void addUser_Load(object sender, EventArgs e)
        {
            tbPwd.PasswordChar = '*';
        }

        private void cbAdm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbPwd.Text == "" || tbUsn.Text == ""|| cbLvl.Text =="")
            {
                koneksi.error0msg();
            }
            else
            {
                string[] namaKolom = { "name", "username", "password", "level" };
                string[] value = { tbNama.Text, tbUsn.Text, tbPwd.Text, cbLvl.Text };
                koneksi.insert("users", namaKolom, value);
                MessageBox.Show("Insert data berhasil", "Hore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Hide();
            pindah();
        }
    }
}
