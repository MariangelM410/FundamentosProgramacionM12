using System;


namespace CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int acumulador = 0;

            while (contador <=5 )
            {
                acumulador += contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }

            Console.WriteLine($"La suma de los cinco primeros números enteros es: {acumulador}");
        
        }

    }
}
