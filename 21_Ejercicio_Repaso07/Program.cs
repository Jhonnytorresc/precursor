/*
 * Escribe un programa que genere un número aleatorio entre el 1 y el 100 
 * Pista: 
 * 1. hay que utilizar una función, hay que buscarlo en internet ya que no lo hemos visto en el precurso
 */
using System;

namespace _21_Ejercicio_Repaso07
{
    class Program
    {
        static void Main(string[] args)
        {
            var seed = Environment.TickCount; //Introduce aquí tu código
            var random = new Random(seed);

            for (int i = 0; i <= 10; i++)
            {
                var value = random.Next(0, 100);
                Console.WriteLine(value);
                Console.Read();
            }

        }

        
    }
}
