/*
 * Escribe un programa que pida dos números al usuario y muestre el resultado de sumarlos, multiplicarlos, restarlos, dividirlos y el resto de la división
 */
using System;

namespace _15_Ejercicio_Repaso01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número:");
            string numerouno = Console.ReadLine();
            Console.WriteLine("Escribe otro número:");
            string numerodos = Console.ReadLine();

            double numerounoInt = Convert.ToInt32(numerouno);
            double numerodosInt = Convert.ToInt32(numerodos);

            Console.WriteLine("El resultado de " + numerouno + " + " + numerodos + " = " + (numerounoInt + numerodosInt));
            Console.WriteLine("El resultado de"  + numerouno + " - " + numerodos + " = "  + (numerounoInt - numerodosInt));
            Console.WriteLine("El resultado de " + numerouno + " * " + numerodos + " = " + (numerounoInt * numerodosInt));
            Console.WriteLine("El resultado de " + numerouno + " / " + numerodos + " = " + (numerounoInt / numerodosInt));
            Console.WriteLine("El resto de " + numerouno + " / " + numerodos + " = " + (numerounoInt % numerodosInt));

        }
    }
}
