using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string cityName = city.Text.Trim();
            string apiKey = "YOUR_API_KEY";
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={apiKey}&units=metric";

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
                    dynamic? result = JsonConvert.DeserializeObject(resultString);
                    Console.WriteLine(result);
                    string? name = result.name;
                    string? country_code = result.sys.country;
                    string? weatherStatus = result.weather[0].main;
                    string? description = result.weather[0].description;
                    float? temperature = result.main.temp;
                    float? feelsLike = result.main.feels_like;

                    // ListView sütunlarýný ayarlayýn
                    Weather_Status.View = View.Details;
                    Weather_Status.FullRowSelect = true;
                    Weather_Status.GridLines = true;

                    if (Weather_Status.Columns.Count == 0)
                    {
                        Weather_Status.Columns.Add("Þehir", 100);
                        Weather_Status.Columns.Add("Durum", 100);
                        Weather_Status.Columns.Add("Ülke", 100);
                        Weather_Status.Columns.Add("Açýklama", 150);
                        Weather_Status.Columns.Add("Sýcaklýk", 100);
                        Weather_Status.Columns.Add("Hissedilen Sýcaklýk", 150);
                    }

                    // Var olan verileri temizle
                    Weather_Status.Items.Clear();

                    // Yeni veri ekleme
                    var listViewItem = new ListViewItem(name);
                    listViewItem.SubItems.Add(weatherStatus);
                    listViewItem.SubItems.Add(country_code);
                    listViewItem.SubItems.Add(description);
                    listViewItem.SubItems.Add($"{temperature} °C");
                    listViewItem.SubItems.Add($"{feelsLike} °C");

                    Weather_Status.Items.Add(listViewItem);
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

        private void Weather_Status_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 2) // Örneðin üçüncü sütun
            {
                e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds);
                e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, Brushes.Black, e.Bounds);
            }
            else
            {
                e.DrawDefault = true;
            }
        }

        private void Weather_Status_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            if (e.Item.Selected)
            {
                e.Graphics.FillRectangle(Brushes.Blue, e.Bounds);
            }
            else
            {
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }

        }

        private void Weather_Status_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Gray, e.Bounds);
            TextRenderer.DrawText(e.Graphics, e.Header.Text, e.Font, e.Bounds, Color.White, TextFormatFlags.HorizontalCenter);
        }
    }
}
