using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            double soucet = a + b;
            double soucin = a * b;
            double podil = a / b;
            double odmocnina = Math.Pow(a, b);

            MessageBox.Show("Součet je : " + soucet);
            MessageBox.Show("Součin  je : " + soucin);
            MessageBox.Show("Podil  je : " + podil);
        }
    }
}
