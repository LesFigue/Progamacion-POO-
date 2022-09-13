using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1suma
{
    internal class Clsuma
    {
        private int n1;
        private int n2;

        public Clsuma(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int sumar()
        {
            return (n1 + n2);
        }
    }
}
