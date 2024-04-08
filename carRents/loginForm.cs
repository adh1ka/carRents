using carRents.Administrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents
{
    public partial class loginForm : Form
    {
        Random random = new Random();
        public loginForm()
        {
            InitializeComponent();
        }
        void getCaptcha()
        {
            int num = random.Next(1000, 9999);
            string cp = num.ToString();
            lblcp.Text = cp;
        }

        private void btnLgn_Click(object sender, EventArgs e)
        {
            if (tbUsn.Text == "" || tbPwd.Text == "" || tbcp.Text != lblcp.Text)
            {
                koneksi.error0msg();
                getCaptcha();
            }
            else
            {
                string[] namaKolom = {"username", "password"};
                string[] value = {tbUsn.Text, tbPwd.Text};
                if(koneksi.validate("users", namaKolom, value) == true)
                {
                    this.Hide();
                    dbdAdm dbdAdm = new dbdAdm();
                    dbdAdm.ShowDialog();
                }
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            tbPwd.Text = string.Empty;
            tbUsn.Text = string.Empty;
            tbPwd.PasswordChar = '*';
            getCaptcha();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            koneksi.exit();
        }

        private void btnKtlg_Click(object sender, EventArgs e)
        {
            this.Hide();
            katalog katalog = new katalog();
            katalog.ShowDialog();
        }
    }
}
