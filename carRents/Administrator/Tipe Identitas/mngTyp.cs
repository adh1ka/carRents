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
    public partial class mngTyp : Form
    {
        public mngTyp()
        {
            InitializeComponent();
        }
        string[] namaKolom = { "name AS Nama" };
        void refresh()
        {
            this.Hide();
            mngTyp mngTyp = new mngTyp();
            mngTyp.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addTI addTI = new addTI();
            addTI.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                koneksi.error0msg();
            }
            else
            {
                string[] namaKolom = { "name" };
                string[] value = { tbNama.Text };
                int id = koneksi.getId("identity_type", namaKolom, value, "identity_type_id");
                koneksi.update("identity_type", namaKolom, value,id, "identity_type_id");
                koneksi.edHore("Identity type", "Identity type");
            }
        }

        private void mngTyp_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            koneksi.info();
            if (tbNama.Visible == false)
            {
                tbNama.Visible = true;
                btnEdit.Visible = true;
                btnDel.Visible = true;
            }
            koneksi.tampil("identity_type", namaKolom, dgvti);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string[] namaKolom = { "name" };
            string[] value = { tbNama.Text };
            int id = koneksi.getId("identity_type",namaKolom, value, "identity_type_id");
            MessageBox.Show(id.ToString());
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                koneksi.error0msg();
            }
            else
            {
                string[] namaKolom = { "name" };
                string[] value = { tbNama.Text };
                int id = koneksi.getId("identity_type", namaKolom, value, "identity_type_id");
                koneksi.delete("identity_type", id, "identity_type_id");
                koneksi.delHore("Identity Type");
            }
        }

        private void btnRf_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
