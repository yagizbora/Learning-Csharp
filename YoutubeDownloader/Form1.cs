using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YoutubeDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string SanitizeFileName(string name)
        {
            foreach (char c in Path.GetInvalidFileNameChars())
            {
                name = name.Replace(c, '_');
            }
            return name;
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            string videoUrl = txtUrl.Text;
            string outputFolder = txtPath.Text;

            if (string.IsNullOrWhiteSpace(videoUrl) || string.IsNullOrWhiteSpace(outputFolder))
            {
                MessageBox.Show("Lütfen geçerli bir URL ve kayýt yolu girin.");
                return;
            }

            try
            {
                var youtube = new YoutubeClient();
                var video = await youtube.Videos.GetAsync(videoUrl);
                var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);

                
                var streamInfo = streamManifest
                    .GetMuxedStreams()
                    .OrderByDescending(s => s.VideoQuality.MaxHeight)
                    .FirstOrDefault();

                if (streamInfo != null)
                {
                    string fileName = $"{SanitizeFileName(video.Title)}.mp4";
                    string filePath = Path.Combine(outputFolder, fileName);

                    
                    await youtube.Videos.Streams.DownloadAsync(streamInfo, filePath);

                    MessageBox.Show($"Video baþarýyla indirildi:\n{filePath}");
                }
                else
                {
                    MessageBox.Show("Uygun bir video akýþý bulunamadý.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    txtPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
