using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1resta
{
    internal class Clrestar
    {
        private int n1;
        private int n2;

        public Clrestar(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int restar()
        {
            return (n1 - n2);
        }
    }
}
