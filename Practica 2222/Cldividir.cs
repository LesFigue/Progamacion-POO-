using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Espacio de nombre (es donde están nuestras clases)
namespace Practica_2
{
    //Esta es la clase, 
    internal class Cldividir
    {
        //Atributos de la clase, también se les puede decir características o campos
        //Se puede llegar al valor de estos a traves del constructor y de las propiedades
        private double n1;
        private double n2;

        //Constructor, asigna los valores de nuestros atributos
        public Cldividir(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        //Este es un método u operación
        public double dividir()
        {
            return (n1 / n2);
        }
    }
    //Aquí termina la clase Cldividir
}
//Aquí termina el espacio de nombre (namespace)
