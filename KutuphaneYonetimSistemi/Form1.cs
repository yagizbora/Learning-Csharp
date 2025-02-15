using System.Data;
using System.Data.SqlClient;
using DotNetEnv;
namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        Form2? formKitaplar;

        [Obsolete]
        SqlConnection connection;

        [Obsolete]
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Env.Load();
                string connectionString = Env.GetString("DB_CONNECTION_STRING");

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Ba�lant� dizesi null veya bo�. L�tfen .env dosyas�n� kontrol edin.");
                    return;
                }

                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� hatas�: " + ex.Message);
            }
        }

        [Obsolete]
        private void button1_Click(object? sender, EventArgs e)
        {
            string sifre = string.Empty;

            if (connection == null)
            {
                MessageBox.Show("Ba�lant� nesnesi null. L�tfen ba�lant�y� kontrol edin.");
                return;
            }

            if (string.IsNullOrEmpty(textBoxSifre.Text) || string.IsNullOrEmpty(textBoxKullaniciAdi.Text))
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre bo� olamaz");
                return;
            }

            try
            {
                connection.Open();

                if (string.IsNullOrEmpty(textBoxKullaniciAdi.Text))
                {
                    MessageBox.Show("Kullan�c� ad� bo� olamaz.");
                    return;
                }

                SqlCommand sqlcommand = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", connection);
                sqlcommand.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);

                SqlDataReader response = sqlcommand.ExecuteReader();
                if (response == null)
                {
                    MessageBox.Show("Veri okunamad�. L�tfen veritaban�n� kontrol edin.");
                    return;
                }

                if (response.Read())
                {
                    sifre = response[0].ToString();
                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� bulunamad�!");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                    return;
                }

                if (sifre == textBoxSifre.Text)
                {


                    formKitaplar = new Form2();
                    this.Hide();
                    formKitaplar.Show();

                }
                else
                {
                    MessageBox.Show("Kullan�c� ad� veya �ifre hatal�!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� Hatas�! " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, EventArgs.Empty);
            }

        }

        private void textBoxKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(null, EventArgs.Empty);
            }
        }

        private void textBoxSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button1_Click(null, EventArgs.Empty);
            }
        }
    }
}
