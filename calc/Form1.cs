using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Int32.Parse(textBox1.Text);
            int n2 = Int32.Parse(textBox2.Text);

            label2.Text = "Soma: " + (n1 + n2);
            label3.Text = "Subtração: " + (n1 - n2);
            label4.Text = "Divisão: " + (n1 / n2);
            label5.Text = "Multiplicação: " + (n1 * n2);
        }
    }
}
