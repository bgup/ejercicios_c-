using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine ( "Ingrese 1 si es de preparatoria o 2 si es profesional");
            string nu = Console.ReadLine();
            int num = int.Parse(nu);
            Console.WriteLine("Ingrese el promedio");
            string pro = Console.ReadLine();
            int prom = int.Parse(pro);
            if (prom >= 9.5)
            {
                if (num == 1)
                {
                   int  unidades = (55 / 5) * 180;
                   int  descuento = ((unidades) - (unidades * 25)/100);
                    Console.WriteLine("El total a pagar es"+descuento);
                }
                else{
                   int  unidades = (55 / 5) * 300;
                   int  descuento = ((unidades) - (unidades * 20)/100);
                    Console.WriteLine("El total a pagar es"+descuento);

                }
            }
            else if (prom >= 9 && prom < 9.5)
            {
                if (num == 1)
                {
                   int unidades = (55 / 5) * 180;
                   int  descuento = ((unidades) - (unidades * 10)/100);
                    Console.WriteLine("El total a pagar es" + descuento);
                }
                else
                {
                   int  unidades = (55 / 5) * 300;
                    Console.WriteLine("El total a pagar es" + unidades);
                }
            }
            else if (prom >= 7 && prom < 9)
            {
                if (num == 1)
                {
                   int  unidades = (55 / 5) * 180;
                    Console.WriteLine("El total a pagar es" + unidades);
                }
            }
            else if (prom <= 7)
            {

                Console.WriteLine("ingrese el numero de materias reporbada");
                string nurepro = Console.ReadLine();
                int numrepro = int.Parse(nurepro);
                
                if (numrepro <= 3)
                {
                    int unidades = (45 / 5) * 180;
                    Console.WriteLine("El total a pagar es" + unidades);
                }
                else
                {
                    int unidades = (40 / 5) * 180;
                    Console.WriteLine("El total a pagar es" + unidades);
                }


                

        }
            Console.ReadKey();
        }
}
}

