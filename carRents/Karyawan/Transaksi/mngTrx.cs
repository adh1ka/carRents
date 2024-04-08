using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Karyawan.Transaksi
{
    public partial class mngTrx : Form
    {
        public mngTrx()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addTrx addTrx = new addTrx();
            addTrx.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editTrx editTrx = new editTrx();
            editTrx.ShowDialog();
        }
    }
}
