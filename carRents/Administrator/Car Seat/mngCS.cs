using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Administrator.Car_Seat
{
    public partial class mngCS : Form
    {
        public mngCS()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addcs addcs = new addcs();
            addcs.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editCS editCS = new editCS();
            editCS.ShowDialog();    
        }

        private void mngCS_Load(object sender, EventArgs e)
        {
            //string[] namaKolom = { "name" };
            //koneksi.tampil("carseat", namaKolom, dgvcs);
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
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
            string[] namaKolom = { "name" };
            koneksi.tampil("carseat", namaKolom, dgvcs);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            addcs addcs1 = new addcs();
            addcs1.ShowDialog();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvcs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tbNama.Visible = true;
            btnEdit.Visible = true;
            btnDel.Visible = true;

            DataGridViewRow row = dgvcs.Rows[e.RowIndex];
            tbNama.Text = row.Cells[0].Value.ToString();
        }

        private void dgvcs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tbNama.Visible = true;
            btnEdit.Visible = true;
            btnDel.Visible = true;

            DataGridViewRow row = dgvcs.Rows[e.RowIndex];
            tbNama.Text = row.Cells[0].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                string[] namaKolom = { "name" };
                string[] value = { tbNama.Text };
                int id = koneksi.getId("carseat", namaKolom, value, "car_seat_id");
                koneksi.delete("carseat", id, "car_seat_id");
            }
        }
    }
}
