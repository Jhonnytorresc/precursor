using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular();
            Console.Read();
        }

        public static void Calcular ()
        {
            Console.WriteLine("ingrese un valor numerico");
            string num1 = Console.ReadLine();
            Console.WriteLine("ingrese otro valor numerico");
            string num2 = Console.ReadLine();

            int intnum1 = Convert.ToInt32(num1);
            int intnum2 = Convert.ToInt32(num2);


            int resultado = intnum1 + intnum2;
            Console.WriteLine(resultado);
        }

    }
}
