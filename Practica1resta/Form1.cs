using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1resta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clrestar orestar = new Clrestar (int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            textBox3.Text = orestar.restar().ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
