using carRents.Administrator.User;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Administrator
{
    public partial class mngUser : Form
    {
        public mngUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addUser addUser = new addUser();
            addUser.ShowDialog();
            tbNama.Visible = false;
            tbPwd.Visible = false;
            tbUsn.Visible = false;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "" || tbPwd.Text == "" || tbUsn.Text == "")
            {
                koneksi.error0msg();
            }
            else
            {
                //koneksi.update("users", namaKolom, value, koneksi.getId)
            }
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            koneksi.info();
            if (tbNama.Visible == false || tbPwd.Visible == false || tbUsn.Visible == false)
            {
                tbNama.Visible = true;
                tbPwd.Visible = true;
                tbUsn.Visible = true;
                btnEdit.Visible = true; 
            }
            string[] namaKolom = { "name", "username", "level" };
            koneksi.tampil("users", namaKolom, dgvUsr);
        }

        private void mngUser_Load(object sender, EventArgs e)
        {
            //string[] namaKolom = { "name", "username", "level" };
            //koneksi.tampil("users", namaKolom, dgvUsr);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "name", "username", "level" };
            string[] value = { tbNama.Text, tbUsn.Text, tbPwd.Text };
            int id = koneksi.getId("users", namaKolom, value, "user_id");
            MessageBox.Show(id.ToString());
            
        }

        private void dgvUsr_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dgvUsr.Rows[e.RowIndex];
            tbNama.Text = row.Cells[0].Value.ToString();
            tbUsn.Text = row.Cells[1].Value.ToString();
            tbPwd.Text = row.Cells[2].Value.ToString();
        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan hapus data?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string[] namaKolom = { "name", "username", "level" };
                string[] value = { tbNama.Text, tbUsn.Text, tbPwd.Text };
                string kolomID = "user_id";
                koneksi.delete("users", koneksi.getId("users", namaKolom, value, kolomID), kolomID);
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] namaKolom = { "name", "username", "level" };
            string[] value = { tbNama.Text, tbUsn.Text, tbPwd.Text };
            int id = koneksi.getId("users", namaKolom, value, "user_id");
            id.ToString();
            string k = koneksi.getRole("users", "user_id", id, "level");
            MessageBox.Show(k);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //string[] namaKolom = { "name", "username", "level" };
            //koneksi.tampil("users", namaKolom, dgvUsr);
        }
    }
}
