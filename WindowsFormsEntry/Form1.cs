namespace WindowsFormsEntry
{
    public partial class Form1 : Form
    {
        public string text = "Software Tech.....";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = text;
            textBox2.Text = text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxTimer.Text.Length == 0)
            {
                return;
            }
            comboBox1.Items.Add(textBoxTimer.Text);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox1?.SelectedIndex == null)
            {
                MessageBox.Show("Choose time!");
            }
            else
            {
                //label3.Text = comboBox1.SelectedIndex.ToString();
                label3.Text = comboBox1?.SelectedItem?.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void AddMonth_Click(object sender, EventArgs e)
        {
            monthListBox.Items.Add(monthTextBox.Text);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnRichText_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "\n" + textBox3.Text;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n" + dateTimePicker1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "\n" + trackBar1.Value;
        }
    }
}
