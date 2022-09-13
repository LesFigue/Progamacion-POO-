using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1dividir
{
    internal class Cldividir
    {
        private double n1;
        private double n2;

        public Cldividir(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public double dividir()
        {
            return (n1 / n2);
        }
    }
}
