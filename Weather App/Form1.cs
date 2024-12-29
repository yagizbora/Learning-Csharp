using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string url = $"https://api.openweathermap.org/data/2.5/weather?q={{city name}}&appid={{API key}}";

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string cityName = city.Text.Trim();
            string apiKey = "YOUR_API_KEY";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}";

            if (string.IsNullOrWhiteSpace(cityName))
            {
                MessageBox.Show("Lütfen bir þehir adý giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string resultString = await response.Content.ReadAsStringAsync();

                    dynamic result = JsonConvert.DeserializeObject(resultString);

                    string weatherStatus = result.weather[0].main;
                    string description = result.weather[0].description;
                    float temperature = result.main.temp;
                    float feelsLike = result.main.feels_like;

                    // ListBox'a verileri ekle
                    Weather_Status.Items.Clear();
                    Weather_Status.Items.Add($"Durum: {weatherStatus}");
                    Weather_Status.Items.Add($"Açýklama: {description}");
                    Weather_Status.Items.Add($"Sýcaklýk: {temperature} °C");
                    Weather_Status.Items.Add($"Hissedilen Sýcaklýk: {feelsLike} °C");
                }
                else
                {
                    MessageBox.Show($"Hata: {response.StatusCode}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
