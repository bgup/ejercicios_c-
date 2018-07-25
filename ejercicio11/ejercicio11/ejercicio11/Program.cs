using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            Console.WriteLine("digite n numero");
            string nu = Console.ReadLine();
            int num = int.Parse(nu);
            Console.WriteLine("ingrese un numero");
            string nu2 = Console.ReadLine();
            int num2 = int.Parse(nu2);

            for  (int i = 0; i < num; i++)
            {
                Console.WriteLine("ingrese un numero");
                b = int.Parse("Console.ReadKey");
                if (b < num)
                {
                    num = b;
                }

            }
            Console.WriteLine("el numero menor es"+num);
            Console.ReadKey();
        }
    }
}
