using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
            Console.WriteLine("ingrese el valor que invirtio");
            string val = Console.ReadLine();
            int inversion = int.Parse(val);
            int i=0;
            while (i <= 12)
            {
                
                int  ganancia = ((inversion * 2)/100);
                inversion = inversion + ganancia;
                i++;
                

            }
            Console.WriteLine("la ganancia que tendra al año si es reinvertida mensualmente es:" + inversion);

            Console.ReadKey();
        }

    }

}
