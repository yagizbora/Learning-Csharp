using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormEntry4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private string domultiplication(int number1,int number2)
        {
            int result = number1 * number2;
            return result.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = (int)Convert.ToInt64(textBox1.Text);
            int number2 = (int)Convert.ToInt64(textBox2.Text);
           label3.Text = domultiplication(number1, number2);

        }

        private double doplus(double number1 , double number2)
        {
            return number1 + number2;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox3.Text);
            double sayi2 = Convert.ToDouble(textBox4.Text);

           double result = doplus(sayi1, sayi2);
            
            label6.Text = result.ToString();

        }
    }
}
