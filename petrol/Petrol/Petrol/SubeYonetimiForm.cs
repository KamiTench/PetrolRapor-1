using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Petrol
{
    public partial class SubeYonetimiForm : Form
    {
        public SubeYonetimiForm()
        {
            InitializeComponent();
            // Form yüklendiğinde şube listesini yükle
            LoadDataFromDatabase();
        }

        // Veritabanından şube verilerini almak
        private void LoadDataFromDatabase()
        {
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM Subeler";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                // Veritabanından çekilen veriyi DataGridView'e yükle
                dataGridView1.DataSource = table;
            }
        }

        // Yeni şube ekleme
        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "INSERT INTO Subeler (SubeAdi, Il, Adres) VALUES (@SubeAdi, @Il, @Adres)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeAdi", txtSubeAd.Text);
                    command.Parameters.AddWithValue("@Il", txtIl.Text);
                    command.Parameters.AddWithValue("@Adres", txtSubeAdres.Text);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Veritabanını güncelle
            LoadDataFromDatabase();
            MessageBox.Show("Şube başarıyla eklendi!");
        }

        // Şube düzenleme
        private void btnSubeDüzenle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubeID.Text))
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz şubenin ID'sini girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "UPDATE Subeler SET SubeAdi = @SubeAdi, Il = @Il, Adres = @Adres WHERE SubeID = @SubeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeAdi", txtSubeAd.Text);
                    command.Parameters.AddWithValue("@Il", txtIl.Text);
                    command.Parameters.AddWithValue("@Adres", txtSubeAdres.Text);
                    command.Parameters.AddWithValue("@SubeID", txtSubeID.Text); // ŞubeID'yi TextBox'tan al

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Veritabanını güncelle
            LoadDataFromDatabase();
            MessageBox.Show("Şube başarıyla düzenlendi!");
        }

        // Şube silme
        private void btnSubeSil_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubeID.Text))
            {
                MessageBox.Show("Lütfen silmek istediğiniz şubenin ID'sini girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "DELETE FROM Subeler WHERE SubeID = @SubeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeID", txtSubeID.Text); // ŞubeID'yi TextBox'tan al

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }

            // Veritabanını güncelle
            LoadDataFromDatabase();
            MessageBox.Show("Şube başarıyla silindi!");
        }

        // Şube bilgilerini ID'ye göre getir
        private void btnSubeGetir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubeID.Text))
            {
                MessageBox.Show("Lütfen şube ID'si girin!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-UGRNDE4;Initial Catalog=PetrolSatisSistemi;Integrated Security=True;Encrypt=False;";
            string query = "SELECT * FROM Subeler WHERE SubeID = @SubeID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@SubeID", txtSubeID.Text);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtSubeAd.Text = reader["SubeAdi"].ToString();
                            txtIl.Text = reader["Il"].ToString();
                            txtSubeAdres.Text = reader["Adres"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Bu ID'ye sahip bir şube bulunamadı!");
                        }
                    }
                    connection.Close();
                }
            }
        }
    }
}
