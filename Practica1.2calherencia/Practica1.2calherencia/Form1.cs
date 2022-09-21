using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Practica1._2calherencia
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
        private void button1_Click(object sender, EventArgs e)
        {
            Sumar sumar = new Sumar();

            txtresultado.Text = sumar.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Restar restar = new Restar();

            txtresultado.Text = restar.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Multiplicar multiplicar = new Multiplicar();

            txtresultado.Text = multiplicar.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dividir dividir = new Dividir();

            txtresultado.Text = dividir.operar(int.Parse(txtv1.Text), int.Parse(txtv2.Text)).ToString();
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
