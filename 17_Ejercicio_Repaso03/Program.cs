/*
 * Escribe un programa que pida tres números al usuario y que calcule y muestre su media.
 */
using System;

namespace _17_Ejercicio_Repaso03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un numero"); //Introduce aquí tu código
            string numerouno;
            numerouno = Console.ReadLine();

            Console.WriteLine("Escribe un numero"); //Introduce aquí tu código
            string numerodos;
            numerodos = Console.ReadLine();

            Console.WriteLine("Escribe un numero"); //Introduce aquí tu código
            string numerotres;
            numerotres = Console.ReadLine();

            double numerotresInt = Convert.ToInt32(numerotres);
            double numerounoInt = Convert.ToInt32(numerouno);
            double numerodosInt = Convert.ToInt32(numerodos);

            Console.WriteLine( (numerounoInt + numerodosInt + numerotresInt) / 3); 

        }
    }
}
