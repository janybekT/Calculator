using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(multiplay(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(devide(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(sum(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(subtract(Convert.ToDouble(textBox1.Text),
                Convert.ToDouble(textBox2.Text)));

        }
        public static double sum(double a,double b) //сумма
        {
            return a + b;
        }
        public static double devide(double a, double b)  //деление
        {
            return a / b;
        }
        public static double subtract(double a, double b) // вычитания
        {
            return a - b;
        }
            public static double multiplay(double a, double b) // умножения
        {
            return a * b;
        }
    }
}
