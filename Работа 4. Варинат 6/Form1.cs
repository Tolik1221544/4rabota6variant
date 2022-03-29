using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_4.Варинат_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Считывание начальных данных
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = "Работу выполнил ст. Червинский А.Ю." + Environment.NewLine;
            // Цикл для табулирования функции
            double x = x0;
            while (x >= (xk + dx / 2))
            {
                double y = Math.Pow(x,2) + Math.Tan(5*x + b/x);
                textBox5.Text += "x=" + Convert.ToString(x) +
                    "; y=" + Convert.ToString(y) + 
                    Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
