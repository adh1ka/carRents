using carRents.Administrator.Car_Seat;
using carRents.Administrator.Mobil;
using carRents.Administrator.Tipe_Identitas;
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
    public partial class dbdAdm : Form
    {
        public dbdAdm()
        {
            InitializeComponent();
        }

        private void usrMenu_Click(object sender, EventArgs e)
        {
            mngUser mUsr = new mngUser();
            mUsr.ShowDialog();
        }

        private void mANAJEMENMOBILToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mngMobil mMbl = new mngMobil();
            mMbl.ShowDialog();
        }

        private void rIWAYATTRANSAKSIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            trxHstry tH = new trxHstry();
            tH.ShowDialog();

        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah anda ingin keluar?", "Konfirmasi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                loginForm loginForm = new loginForm();
                loginForm.ShowDialog();
            }
        }

        private void cARSEATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mngCS mCS = new mngCS();
            mCS.ShowDialog();
        }

        private void tIPEIDENTITASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mngTyp mTI = new mngTyp();
            mTI.ShowDialog();
        }

        private void pELANGGANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mngPlg mPlg = new mngPlg();
            mPlg.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            koneksi.exit();
        }

        private void pENGATURANToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
