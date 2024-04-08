using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace carRents
{
    internal class koneksi
    {
        public static SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-210TKKE\SQLEXPRESS;initial catalog=lks;integrated security=true");
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static SqlDataAdapter da;
        public static DataSet ds = new DataSet();
        public static DataTable dt = new DataTable();

        public static void error0msg()
        {
            MessageBox.Show("Kesalahan ada kolom yang belum diisi!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void exit() 
        {
            if(MessageBox.Show("Apakah anda yakin ingin exit", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public static void delHore(string judul)
        {
            if (MessageBox.Show("Semua data " +judul+" akan hilang", "Hapus data " +judul+"???????????????????????????", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

            }
        }
        public static void edHore(string judul, string apa)
        {
            MessageBox.Show("Update data " + apa + " pada " + judul + " Berhasil", "HOREEEEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void adHore(string judul, string apa)
        {
            MessageBox.Show("Insert data " + apa + " pada " + judul + " Berhasil", "HOREEEEEEEEE", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void info()
        {
            MessageBox.Show("Untuk mengedit atau menghapus data, silahkan klik isi tabel terlebih dahulu", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static bool validate(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "SELECT * FROM " + namaTabel + " WHERE ";
            for (int i = 0; i < value.Length; i++)
            {
                query += namaKolom[i] + " = ";
                if (namaKolom[i] == "password")
                {
                    query += "HASHBYTES('SHA2_256','" + value[i] + "')";
                }
                else
                {
                    query += "'" + value[i] + "'";
                }
                if (i < namaKolom.Length - 1)
                {
                    query += " AND ";
                }
            }
            conn.Open();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                dr.Close();
                conn.Close();
                return true;
            }
            else
            {
                dr.Close();
                conn.Close();
                return false;
            }
        }

        public static void tampil(string namaTabel, string[] namaKolom, DataGridView dgv)
        {
            string query = "SELECT ";
            for (int i = 0; i < namaKolom.Length; i++)
            {
                query += namaKolom[i];
                if(i < namaKolom.Length - 1)
                {
                    query += ",";
                }
            }
            query += " FROM " + namaTabel;
            conn.Open();
            cmd = new SqlCommand(query, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgv.DataSource = dt;
            conn.Close();
        }

        public static int getId(string namaTabel, string[] namaKolom, string[] value, string kolomId)
        {
            string query = "SELECT " + kolomId + " FROM " + namaTabel + " WHERE "; ;
            for (int i = 0; i < value.Length; i++)
            {
                query += namaKolom[i] + " = ";
                if (namaKolom[i] == "password")
                {
                    query += "HASHBYTES('SHA2_256','" + value[i] + "')";
                }
                else
                {
                    query += "'" + value[i] + "'";
                }
                if (i < namaKolom.Length - 1)
                {
                    query += " AND ";
                }

            }
            conn.Open();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            int id;
            
            if (dr.HasRows)
            {
                id = Convert.ToInt32(dr["" + kolomId + ""]);
            }
            else
            {
                id = 0;
            }
            dr.Close();
            conn.Close();
            return id;
        }

        public static string getRole(string namaTabel, string kolomId, int id, string kolomRole)
        {
            string query = "SELECT " + kolomRole + " FROM" + namaTabel + " WHERE " + kolomId + " = '" + id + "'";
            conn.Open();
            cmd = new SqlCommand(query, conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            string rl;
            if (dr.HasRows)
            {
                rl = Convert.ToString(dr["" + kolomRole + ""]);
            }
            else
            {
                rl = null;
            }
            dr.Close();
            conn.Close();
            return rl;
        }
        public static void insert(string namaTabel, string[] namaKolom, string[] value)
        {
            string query = "INSERT INTO " + namaTabel + " (";
            for (int i = 0; i < namaKolom.Length; i++)
            {
                query += namaKolom[i];
                if (i < namaKolom.Length - 1)
                {
                    query += ",";
                }
            }
            query += ") VALUES (";
            for (int i = 0; i < value.Length; i++)
            {
                if (namaKolom[i] == "password")
                {
                    query += "HASHBYTES('SHA2_256','" + value[i] + "')";
                }
                else
                {
                    query += "'" + value[i] + "'";
                }
                if (i < namaKolom.Length - 1)
                {
                    query += ",";
                }
            }
            query += ");";
            conn.Open();
            cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public static void update(string namaTabel, string[] namaKolom, string[] value, int id, string kolomID)
        {
            try
            {
                string query = "UPDATE " + namaTabel + " SET ";
                for (int i = 0; i < namaKolom.Length; i++)
                {
                    if (namaKolom[i] == "password")
                    {
                        query += namaKolom[i] + "HASHBYTES('SHA2_256','" + value[i] + "')";
                    }
                    else
                    {
                        query += namaKolom[i] + " = '" + value[i] + "'";
                    }
                    if (i < namaKolom.Length - 1)
                    {
                        query += ",";
                    }
                    query += " WHERE " + kolomID + " = '" + id + "'";
                }
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public static void delete(string namaTabel, int id, string kolomID)
        {
            try
            {
                string query = "DELETE FROM " + namaTabel + " WHERE " + kolomID + " = '" + id + "'";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
