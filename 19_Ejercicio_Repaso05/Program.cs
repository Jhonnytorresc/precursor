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
            
            string a = Console.ReadLine();
           
            int aInt = Convert.ToInt32(a);

            int digito3 = aInt % 10 ;
            int digito2 = (aInt % 100 )/10;
            digito2 = Convert.ToInt32(digito2);
            int digito1 = (aInt % 1000) / 100 ;
            digito1 = Convert.ToInt32(digito1);

            int resultado = digito1 + digito2 + digito3;

            Console.WriteLine(resultado);
            Console.Read();

            
        }
    }
}
