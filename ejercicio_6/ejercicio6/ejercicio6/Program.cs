using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el 1 numero");
            string num = Console.ReadLine();
            int nu1 = int.Parse(num);
            Console.WriteLine("ingrese el 2 numero");
            string num2 = Console.ReadLine();
            int nu2 = int.Parse(num2);
            Console.WriteLine("ingrese el 3 numero");
            string num3 = Console.ReadLine();
            int nu3 = int.Parse(num3);

            if (nu1 > nu2 && nu1 < nu3 || nu1 < nu2 && nu1 > nu3)
            {
                Console.WriteLine("el del  medio es"+nu1);
            }else if (nu2 > nu1 && nu2 < nu3 || nu2 < nu1 && nu2 > nu3)
            {
                Console.WriteLine("el del  medio es" + nu2);
            }
            else if (nu3 > nu1 && nu3 < nu2 || nu3 < nu1 && nu3 > nu2)
            {
                Console.WriteLine("el del  medio es" + nu3);
            }

            Console.ReadKey();



        }
    }
}
