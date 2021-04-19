/*
 * Escribe un programa que pida un número de 3 dígitos y que muestre en pantalla el resultado de sumarlos.
 * Pistas:
 * 1. El resto de una división cuyo divisor es 10, 100, 1000... se corresponde con los decimales del resultado
 * 52/10 = 5,2
 * 52%10 = 2
 */
using System;

namespace _19_Ejercicio_Repaso05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe un número de tres cifras" ); //Introduce aquí tu código
            string  numero;
            numero = Console.ReadLine();

            int numeroInt = Convert.ToInt32(numero);

            Console.WriteLine(numeroInt / 100 + numeroInt % 100 );

        }
    }
}
