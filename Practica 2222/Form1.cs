using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Código limpio: hacer comentarios sobre qué son las cosas y las que no se entienden
            //Este fue para hacer la programación con una línea de texto y sin usar clases
            //textBox3.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
            //Creamos el objeto odividir (el nombre del objeto puede ser cualquiera excepto palabras reservadas)
            Cldividir odividir = new Cldividir(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
            //
            textBox3.Text = odividir.dividir().ToString();
        }
    }
}
