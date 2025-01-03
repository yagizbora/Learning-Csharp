using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEntry2
{
    public partial class FormDetayBilgiler : Form
    {
        public FormDetayBilgiler(string ogrencino)
        {
            InitializeComponent();
            textBox1.Text = ogrencino;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
