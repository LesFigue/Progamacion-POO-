using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1dividirenunasolalínea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Así se programaba en los 90´s pero este tipo de programación ya no se usa
            textBox3.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();

        }
    }
}
