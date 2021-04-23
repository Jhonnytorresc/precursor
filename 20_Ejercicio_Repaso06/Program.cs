/*
 * Escribe un programa que pida un número de minutos y muestre cuantos años y días son.
 */
using System;

namespace _20_Ejercicio_Repaso06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número para covertirlos a años y días"); //Introduce aquí tu código
            string numero;
            numero = Console.ReadLine();

            int total = Convert.ToInt32(numero);
            int añoInt = total / 525600;
            total = total - (añoInt * 525600);
            int diasInt = total / 1440; 
           
            Console.WriteLine( "Esos minutos son " + añoInt  + " años y " + diasInt  + " dias.");
            Console.ReadLine();
        }
    }
}
