using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMySQL
{
    public partial class Form1 : Form
    {
        private static string connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=basicmysql;SslMode=none;";
        private MySqlConnection databaseConnection = new MySqlConnection(connString);

        public Form1()
        {
            InitializeComponent();
    
        }

        public void refresh()
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku";
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
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString()); listViewItem.SubItems.Add(reader["pengarang"].ToString()); listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
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
            string query = "INSERT INTO data_buku (id_buku, judul, pengarang, jumlah) VALUES (@id, @judul, @pengarang,@jumlah)";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
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

        private void button_update_Click(object sender, EventArgs e)
        {
            string query = "UPDATE data_buku SET judul = @judul, pengarang=@pengarang, jumlah=@jumlah WHERE id_buku= @id";
            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
                cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);
                cmd.Parameters.AddWithValue("@jumlah", text_jumlah.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diupdate");
                
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

        private void button_delete_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM data_buku WHERE id_buku = @id"; try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                cmd.CommandTimeout = 60;
                cmd.Parameters.AddWithValue("@id", text_id.Text);
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

        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void listBuku_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBuku.SelectedItems.Count == 0)
            {
                return;
            }

            ListViewItem item = listBuku.SelectedItems[0];

            text_id.Text = item.SubItems[0].Text;
            text_judul.Text = item.SubItems[1].Text;
            text_pengarang.Text = item.SubItems[2].Text;
            text_jumlah.Text = item.SubItems[3].Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        public void Search()
        {
            listBuku.Items.Clear();
            string query = "SELECT * FROM data_buku WHERE judul LIKE '%"+text_judul.Text+"%' OR pengarang LIKE '%"+text_pengarang.Text+"%'; ";

            try
            {
                // Open the database
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                //cmd.Parameters.AddWithValue("@judul", text_judul.Text);
                //cmd.Parameters.AddWithValue("@pengarang", text_pengarang.Text);

                cmd.CommandTimeout = 60;
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem listViewItem = new ListViewItem(reader["id_buku"].ToString());
                        listViewItem.SubItems.Add(reader["judul"].ToString()); listViewItem.SubItems.Add(reader["pengarang"].ToString()); listViewItem.SubItems.Add(reader["jumlah"].ToString());
                        listBuku.Items.Add(listViewItem);
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

        private void button_search_Click(object sender, EventArgs e)
        {
            Search();
        }
    }
}
