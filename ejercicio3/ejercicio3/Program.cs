using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la inversion de la primera persona");
            string i1 = Console.ReadLine();
            float inversion1 = float.Parse(i1);
            Console.WriteLine("Ingrese la inversion de la segunda persona");
            string i2 = Console.ReadLine();
            float inversion2 = float.Parse(i2);
            Console.WriteLine("Ingrese la inversion de la primera persona");
            string i3 = Console.ReadLine();
            float inversion3 = float.Parse(i3);
            float sumatotal = (inversion1 + inversion2 + inversion3);
            float porc1 = ((inversion1 * 100) / sumatotal);
            float porc2 = ((inversion2 * 100) / sumatotal);
            float porc3 = ((inversion3 * 100) / sumatotal);
            Console.WriteLine("El porcentaje del primer inversionista es{0}",porc1);
            Console.WriteLine("El porcentaje del primer inversionista es{0}", porc2);
            Console.WriteLine("El porcentaje del primer inversionista es{0}", porc3);
            Console.ReadKey();
        }
        
    }
}
