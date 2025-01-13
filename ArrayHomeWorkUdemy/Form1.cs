using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.IEnumerable;
using System.Windows.Forms;

namespace ArrayHomeWorkUdemy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arrays = { 20,22,27,29,45};
            int sum = 0; 

            for (int i = 0; i < arrays.Length; i++)
            {
                sum += arrays[i]; 
            }

            float result = (float)sum / arrays.Length; 
            richTextBox1.Text = result.ToString(); 
        }
    }
}
