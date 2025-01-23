using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometric_Calculator
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

        private void calculate_rectangle_Click(object sender, EventArgs e)
        {
            float? a = Convert.ToInt64(textBox1.Text);
            float? b = Convert.ToInt64(textBox2.Text);
            float? c = a * b;

            label7.Text = c.ToString() + "m Alan"; 
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            float? a = Convert.ToInt64((string)square_side.Text);
            float b = (float)(a * a);

            label6.Text = b.ToString() + "m Alan"; 
        }

        private void calculate_circle_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox3.Text);
            float result = (float)(Math.PI * ( a *  a ));
            
            label8.Text = result.ToString() + "m Alan";
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
