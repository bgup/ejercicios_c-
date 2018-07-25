using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("que actividad desea saber las calorias consumidas 1 dormir  2 sentado o reposo ?");
            string opcion = Console.ReadLine();
            int opc = int.Parse(opcion);
            if (opc == 1 )
            {
                Console.WriteLine("ingrese las horas que durmio");
                    string horas = Console.ReadLine();
                    double hras = double.Parse(horas);
                    double total = hras * 1.08;
                Console.WriteLine("las calorias que consumio estando dormido es{0}", total);

                    
            } else  if(opc==2){
                Console.WriteLine("ingrese las horas de reposo");
                string horas = Console.ReadLine();
                double hras = double.Parse(horas);
                double total = hras * 1.66;
                Console.WriteLine("las calorias que consumio estando en reposo son{0}",total);
                



            }
            Console.ReadKey();
        }
    }
}
