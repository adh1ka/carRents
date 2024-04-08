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
    public partial class addcs : Form
    {
        public addcs()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNama.Text == "")
            {
                koneksi.error0msg();
            }
            else
            {
                string[] namaKolom = { "name" };
                string[] value = { tbNama.Text };
                koneksi.insert("carseat", namaKolom, value);
                koneksi.adHore("Car seat", "Car seat");
                this.Hide();
            }
        }

        private void addcs_Load(object sender, EventArgs e)
        {
            
        }
    }
}
