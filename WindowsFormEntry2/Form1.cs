namespace WindowsFormEntry2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? ogrencino = textBox1.Text;

            FormDetayBilgiler formdetaybilgiler = new FormDetayBilgiler(ogrencino);
            formdetaybilgiler.Show();
        }
    }
}
