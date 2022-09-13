using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cloperaciones osumar = new Cloperaciones(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = osumar.sumar().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cloperaciones orestar = new Cloperaciones(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = orestar.restar().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cloperaciones omultiplicar = new Cloperaciones(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = omultiplicar.multiplicar().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cloperaciones odividir = new Cloperaciones(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            textBox3.Text = odividir.dividir().ToString();
        }
    }
}
