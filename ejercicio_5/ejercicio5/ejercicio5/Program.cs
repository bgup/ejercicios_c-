using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor del inmueble");
            string val = Console.ReadLine();
            int valor = int.Parse(val);
            int devaluo = ((((valor * 10) / 100) * (3)) - (valor));
            int valorizacion= ((((valor * 30) / 100) * (3)) + (valor));
            int mitad = valorizacion / 2;

            if (devaluo< mitad){

                Console.WriteLine("durante los 3 anos la devaluacion no es mayor a la mitad de la valorizacion,compre el automovil" + valorizacion + "=" + mitad);
            }
            else
            {
                Console.WriteLine("Compre el inmueble");
            }
            Console.ReadKey();
        }
    }
}
