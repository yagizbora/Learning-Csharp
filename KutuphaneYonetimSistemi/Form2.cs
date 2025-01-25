using DotNetEnv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneYonetimSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection connection;

        public void showdata()
        {
            string query = "SELECT * FROM TableKitaplar";
            SqlDataAdapter response = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            response.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewKitaplar.DataSource = dt;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            try
            {
                Env.Load();
                // Console.WriteLine("DB_CONNECTION_STRING: " + Env.GetString("DB_CONNECTION_STRING"));
                // string connectionString = @"Data Source=YAGIZ-PC\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Persist Security Info=True;User ID=library;Password=library;Encrypt=False;";
                string connectionString = Env.GetString("DB_CONNECTION_STRING");
                // Console.WriteLine("Connection String: " + connectionString);

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Bağlantı dizesi null veya boş. Lütfen .env dosyasını kontrol edin.");
                    return;
                }

                connection = new SqlConnection(connectionString);

                if (!string.IsNullOrEmpty(connectionString))
                {
                    showdata();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bağlantı hatası: " + ex.Message);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void buttonKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBoxKitapAdi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYazarAdi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxYazarSoyadi.Text) ||
                    string.IsNullOrWhiteSpace(textBoxISBN.Text) ||
                    string.IsNullOrWhiteSpace(textBoxKitapTurKodu.Text))
                {
                    MessageBox.Show("Tüm alanlar doldurulmalıdır!");
                    return;
                }

                connection.Open();
                string query = "INSERT INTO TableKitaplar (KitapAdi, YazarAdi, YazarSoyadi, ISBN, Durum, KitapTurKodu) VALUES (@p1, @p2, @p3, @p4, @p5, @p6)";
                SqlCommand response = new SqlCommand(query, connection);
                response.Parameters.AddWithValue("@P1", textBoxKitapAdi.Text);
                response.Parameters.AddWithValue("@P2", textBoxYazarAdi.Text);
                response.Parameters.AddWithValue("@P3", textBoxYazarSoyadi.Text);
                response.Parameters.AddWithValue("@P4", textBoxISBN.Text);
                response.Parameters.AddWithValue("@P5", "True");
                response.Parameters.AddWithValue("@P6", textBoxKitapTurKodu.Text);

                response.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            showdata();
        }

        private void dataGridViewKitaplar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chooseline = dataGridViewKitaplar.SelectedCells[0].RowIndex;
            kitapid.Text = dataGridViewKitaplar.Rows[chooseline].Cells[0].Value.ToString();
            textBoxKitapAdi.Text = dataGridViewKitaplar.Rows[chooseline].Cells[1].Value.ToString();
            textBoxYazarAdi.Text = dataGridViewKitaplar.Rows[chooseline].Cells[2].Value.ToString();
            textBoxYazarSoyadi.Text = dataGridViewKitaplar.Rows[chooseline].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewKitaplar.Rows[chooseline].Cells[4].Value.ToString();
            textBoxKitapTurKodu.Text = dataGridViewKitaplar.Rows[chooseline].Cells[8].Value.ToString();
            textBoxOduncAlan.Text = dataGridViewKitaplar.Rows[chooseline].Cells[6].Value.ToString();

            if (dataGridViewKitaplar.Rows[chooseline].Cells[7].Value != DBNull.Value)
            {
                dateTimePicker1.Value = Convert.ToDateTime(dataGridViewKitaplar.Rows[chooseline].Cells[7].Value);
            }

        }

        private void buttonKitapBilgiGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden güncelleme işlemi yapılamaz!");
                }
                else
                {
                    connection.Open();
                    string query = "UPDATE TableKitaplar SET KitapAdi = @p1, YazarAdi = @p2, YazarSoyadi = @p3, ISBN = @p4, KitapTurKodu = @p5 WHERE ID = @p6";
                    SqlCommand response = new SqlCommand(query, connection);
                    response.Parameters.AddWithValue("@p1", textBoxKitapAdi.Text);
                    response.Parameters.AddWithValue("@p2", textBoxYazarAdi.Text);
                    response.Parameters.AddWithValue("@p3", textBoxYazarSoyadi.Text);
                    response.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                    response.Parameters.AddWithValue("@p5", textBoxKitapTurKodu.Text);
                    response.Parameters.AddWithValue("@p6", kitapid.Text);
                    response.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            showdata();
        }

        private void buttonKitabiOduncVer_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden güncelleme işlemi yapılamaz!");
                }

                else
                {
                    connection.Open();
                    string query = "UPDATE TableKitaplar SET OduncAlan = @p1, OduncAlmaTarihi = @p2,Durum = @p3 WHERE ID = @p4";
                    SqlCommand response = new SqlCommand(query, connection);
                    response.Parameters.AddWithValue("@p1", textBoxOduncAlan.Text);
                    response.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                    response.Parameters.AddWithValue("@p3", "False");
                    response.Parameters.AddWithValue("@p4", kitapid.Text);
                    response.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            showdata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
                {
                    MessageBox.Show("Kitap seçmeden hesaplama işlemi yapılamaz!");
                }
                else
                {
                    if (connection == null || connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    // SQL komutunu oluştururken bağlantıyı belirtin
                    SqlCommand response = new SqlCommand(
                        "UPDATE TableKitaplar SET OduncAlan = @p1, OduncAlmaTarihi = @p2, Durum = @p3 WHERE ID = @p4",
                        connection);

                    // Parametreleri ekle
                    response.Parameters.AddWithValue("@p1", DBNull.Value); 
                    response.Parameters.Add("@p2", SqlDbType.Date).Value = DBNull.Value; 
                    response.Parameters.AddWithValue("@p3", true); 
                    response.Parameters.AddWithValue("@p4", kitapid.Text); 
                    response.ExecuteNonQuery();
                    textBoxOduncAlan.Text = "";
                    dateTimePicker1.Value = DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            showdata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kitapid.Text == "-" || string.IsNullOrEmpty(kitapid.Text))
            {
                MessageBox.Show("Kitap seçmeden hesaplama yapılamaz işlemi yapılamaz!");
            }
            else
            {
                DateTime todaydate = DateTime.Now;
                int calculateday = (int)  (todaydate - dateTimePicker1.Value.Date).TotalDays;

                if (calculateday > 10) 
                {
                    int delayallowance = (int) (calculateday - 10) * 1;
                    labelgecikmebedeli.Text = delayallowance.ToString();
                }
            }
        }
    }
}
