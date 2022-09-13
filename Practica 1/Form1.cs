using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear el objeto
            //Clsuma osuma = new Clsuma(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            //Creando el objeto (osuma) = instanciar
            Clsuma osuma = new Clsuma();
            //El valor de la caja de texto1 lo convierte a entero y se lo asigna a la propiedad N1
            osuma.N1 = int.Parse(textBox1.Text);
            //El valor de la caja de texto2 lo convierte a entero y se lo asigna a la propiedad N2
            osuma.N2 = int.Parse(textBox2.Text);
            //textbox4 es para ver como funciona el get, es decir darle un valor que ya había sido asignado
            textBox4.Text = osuma.N2.ToString();
            //La caja de texto3 es el resultado por lo que en este se realiza la operación
            textBox3.Text = osuma.sumar().ToString();
        }
    }
}
