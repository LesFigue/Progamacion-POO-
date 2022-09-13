using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1dividir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cldividir odividir = new Cldividir(double.Parse(textBox1.Text),
                                               double.Parse(textBox2.Text));
            textBox3.Text = odividir.dividir().ToString();
        }
    }
}
