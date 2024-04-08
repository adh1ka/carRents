using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Administrator.Mobil
{
    public partial class mngMobil : Form
    {
        public mngMobil()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addMobil addMobil = new addMobil();
            addMobil.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMobil editMobil = new editMobil();
            editMobil.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            koneksi.info();
            tbNama.Visible = true;
            tbPwd.Visible = true;
            tbUsn.Visible = true;
            btnEdit.Visible = true;
            btnDel.Visible = true;
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void mngMobil_Load(object sender, EventArgs e)
        {

        }
    }
}
