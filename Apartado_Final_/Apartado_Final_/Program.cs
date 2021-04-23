using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apartado_Final_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anchura del rectángulo:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Altura del rectángulo:");
            string num2 = Console.ReadLine();

            int num1Int = Convert.ToInt32(num1);
            int num2Int = Convert.ToInt32(num2);

            int resultado = num1Int * num2Int;

            Console.WriteLine("El área del rectángulo es " + resultado);
            Console.ReadLine();
        }
    }
}
