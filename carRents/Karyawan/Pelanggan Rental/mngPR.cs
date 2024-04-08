using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carRents.Karyawan.Pelanggan_Rental
{
    public partial class mngPR : Form
    {
        public mngPR()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addPR addPR = new addPR();
            addPR.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editPR editPR = new editPR();
            editPR.ShowDialog();
        }
    }
}
