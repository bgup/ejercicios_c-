using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el presupuesto anual del hospital");
            string ma = Console.ReadLine();
            float montanual = float.Parse(ma);
            double ginecologia = montanual * 0.40;
            Console.WriteLine("El presupuesto que le corresponde a ginecologia es{0}",ginecologia);
            double traumatologia = montanual * 0.30;
            Console.WriteLine("El presupuesto que le corresponde a traumatologia es{0}", traumatologia);
            double pediatria = montanual * 0.30;
            Console.WriteLine("El presupuesto que le corresponde a pediatria es{0}", pediatria);
            Console.ReadKey();

        }
    }
}
