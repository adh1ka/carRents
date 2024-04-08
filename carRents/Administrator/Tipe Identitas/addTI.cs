using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Administrator.Tipe_Identitas
{
    public partial class addTI : Form
    {
        public addTI()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(tbNama.Text == "")
            {
                koneksi.error0msg();
            }
            else
            {
                string[] namaKolom = { "name" };
                string[] value = { tbNama.Text };
                koneksi.insert("identity_type", namaKolom, value);
                MessageBox.Show("Insert Identity Type " + tbNama.Text + " Berhasil", "Hore", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            
        }

        private void btnCncl_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
