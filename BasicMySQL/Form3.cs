using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BasicMySQL
{
    public partial class Form3 : Form
    {
        private static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=perpustakaan2;SslMode=none;";
        private MySqlConnection databaseConnection = new MySqlConnection(connString);

        public Form3()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            lvPeminjaman.Items.Clear();
            string query = "SELECT m.nim, m.nama, b.id_buku, b.judul FROM `data_pinjaman` AS p JOIN `mahasiswa` AS m ON m.nim = p.nim JOIN `data_buku` AS b ON b.id_buku = p.id_buku";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["nim"].ToString());
                        listViewItem.SubItems.Add(reader["nama"].ToString());
                        listViewItem.SubItems.Add(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString());
                        lvPeminjaman.Items.Add(listViewItem);
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO `data_pinjaman` (id_buku, nim) VALUES (@id, @nim)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", txtIdBuku.Text);
                cmd.Parameters.AddWithValue("@nim", txtNim.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil ditambahkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                refresh();
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM `data_pinjaman` WHERE nim = @nim AND id_buku = @id_buku"; try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", txtNim.Text);
                cmd.Parameters.AddWithValue("@id_buku", txtIdBuku.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil dihapus");
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
            finally
            {
                databaseConnection.Close();
                refresh();
            }
        }

        private void lvPeminjaman_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPeminjaman.SelectedItems.Count == 0)
            {
                return;
            }

            var item = lvPeminjaman.SelectedItems[0];

            txtNim.Text = item.SubItems[0].Text;
            txtIdBuku.Text = item.SubItems[2].Text;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
