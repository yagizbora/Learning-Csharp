using System.Data;
using System.Data.SqlClient;
using DotNetEnv;
namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        Form2 formKitaplar; // Doðru nesne tanýmý

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connection;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // .env dosyasýný yükle
                Env.Load();

                // DB_CONNECTION_STRING deðerini kontrol et
                string connectionString = @"Data Source=YAGIZ-PC\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Persist Security Info=True;User ID=library;Password=library;Encrypt=False;";
                // that'll be fixed maybe method will change    
                // string connectionString = Env.GetString("DB_CONNECTION_STRING");
                // Console.WriteLine("Connection String: " + connectionString);

                if (string.IsNullOrEmpty(connectionString))
                {
                    MessageBox.Show("Baðlantý dizesi null veya boþ. Lütfen .env dosyasýný kontrol edin.");
                    return;
                }

                connection = new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = string.Empty;

            // SqlConnection nesnesinin null olmadýðýný kontrol edin
            if (connection == null)
            {
                MessageBox.Show("Baðlantý nesnesi null. Lütfen baðlantýyý kontrol edin.");
                return;
            }

            try
            {
                connection.Open(); // Baðlantýyý aç

                // SqlCommand nesnesini kontrol edin
                if (string.IsNullOrEmpty(textBoxKullaniciAdi.Text))
                {
                    MessageBox.Show("Kullanýcý adý boþ olamaz.");
                    return;
                }

                SqlCommand sqlcommand = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", connection);
                sqlcommand.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);

                // SqlDataReader nesnesini kontrol edin
                SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();
                if (sqlDataReader == null)
                {
                    MessageBox.Show("Veri okunamadý. Lütfen veritabanýný kontrol edin.");
                    return;
                }

                if (sqlDataReader.Read())
                {
                    sifre = sqlDataReader[0].ToString();
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý bulunamadý!");
                    textBoxKullaniciAdi.Text = "";
                    textBoxSifre.Text = "";
                    return;
                }

                if (sifre == textBoxSifre.Text)
                {
                    // Þifre doðru
                    formKitaplar = new Form2(); 
                    formKitaplar.Show(); 
                                          
                }
                else
                {
                    MessageBox.Show("Kullanýcý adý veya þifre hatalý!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý Hatasý! " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
