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
    public partial class Form2 : Form
    {
        private static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=perpustakaan2;SslMode=none;";
        private MySqlConnection databaseConnection = new MySqlConnection(connString);

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void refresh()
        {
            lvMahasiswa.Items.Clear();
            string query = "SELECT * FROM `mahasiswa`";
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
                        lvMahasiswa.Items.Add(listViewItem);
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
            string query = "INSERT INTO mahasiswa (nim, nama) VALUES (@nim, @nama)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", txtNim.Text);
                cmd.Parameters.AddWithValue("@nama", txtNama.Text);
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
            string query = "DELETE FROM `mahasiswa` WHERE nim = @nim"; try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@nim", txtNim.Text);
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

        private void lvMahasiswa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMahasiswa.SelectedItems.Count == 0)
            {
                return;
            }

            var item = lvMahasiswa.SelectedItems[0];

            txtNim.Text = item.SubItems[0].Text;
            txtNama.Text = item.SubItems[1].Text;
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
