using System.Data;
using System.Data.SqlClient;

namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=YAGIZ-PC\SQLEXPRESS;Initial Catalog=DbYTAKutuphane;Persist Security Info=True;User ID=library;Password=library;Encrypt=False;");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifre = string.Empty; 
            try
            {
                connection.Open(); 
                SqlCommand sqlcommand = new SqlCommand("SELECT Sifre FROM TableKutuphaneYoneticileri WHERE KullaniciAdi = @p1", connection);
                sqlcommand.Parameters.AddWithValue("@p1", textBoxKullaniciAdi.Text);

                SqlDataReader sqlDataReader = sqlcommand.ExecuteReader();

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
