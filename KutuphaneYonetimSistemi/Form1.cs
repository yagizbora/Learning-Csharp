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
                // .env dosyasýný yükle
                Env.Load();
                // Console.WriteLine("DB_CONNECTION_STRING: " + Env.GetString("DB_CONNECTION_STRING"));
                // DB_CONNECTION_STRING deðerini kontrol et
                // string connectionString = @"Data Source=YAGIZ-PC\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Persist Security Info=True;User ID=library;Password=library;Encrypt=False;";
                string connectionString = Env.GetString("DB_CONNECTION_STRING");
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

        [Obsolete]
        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = string.Empty;

            // SqlConnection nesnesinin null olmadýðýný kontrol edin
            if (connection == null)
            {
                MessageBox.Show("Baðlantý nesnesi null. Lütfen baðlantýyý kontrol edin.");
                return;
            }

            if(string.IsNullOrEmpty(textBoxSifre.Text) || string.IsNullOrEmpty(textBoxKullaniciAdi.Text))
            {
                MessageBox.Show("Kullanýcý adý veya þifre boþ olamaz");
            }

            try
            {
                connection.Open(); 

                if (string.IsNullOrEmpty(textBoxKullaniciAdi.Text))
                {
                    MessageBox.Show("Kullanýcý adý boþ olamaz.");
                    return;
                }

                SqlCommand sqlcommand = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", connection);
                sqlcommand.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);

                // SqlDataReader nesnesini kontrol edin
                SqlDataReader response = sqlcommand.ExecuteReader();
                if (response == null)
                {
                    MessageBox.Show("Veri okunamadý. Lütfen veritabanýný kontrol edin.");
                    return;
                }

                if (response.Read())
                {
                    sifre = response[0].ToString();
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


                    formKitaplar = new Form2();
                    this.Hide();
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
