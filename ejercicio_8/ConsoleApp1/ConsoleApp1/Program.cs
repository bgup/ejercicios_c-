using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor a multiplicar:");
            string num = Console.ReadLine();
            int numx = int.Parse(num);
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numx * i;
                Console.WriteLine(numx + "X" + i + "=" + resultado);
            }
            Console.ReadKey();
        }
    }
}
