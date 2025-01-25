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

             if(!string.IsNullOrEmpty(connectionString))
             {
                    string query = "SELECT * FROM TableKitaplar";
                    SqlDataAdapter response = new SqlDataAdapter(query, connection);
                    DataTable dt = new DataTable();
                    response.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        dataGridViewKitaplar.DataSource = dt;
                    }
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
    }
}
