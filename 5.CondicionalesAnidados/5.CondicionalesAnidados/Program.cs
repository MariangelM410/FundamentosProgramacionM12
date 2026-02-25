using System;

namespace _5.CondicionalesAnidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese 3 valores diferentes");
            Console.WriteLine("Ingrese el valor del número 1");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 2");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el valor del número 3");
            num3 = Int32.Parse(Console.ReadLine());

            if (num1>num2)
            {
                //Verdadera
                if (num1>num3)
                {
                    Console.WriteLine($"El número mayor es: {num1}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es: {num3}");
                }
            }
            else
            {
                //False
                if (num2>num3)
                {
                    Console.WriteLine($"El número mayor es {num2}");
                }
                else
                {
                    Console.WriteLine($"El número mayor es {num3}");
                }

            }
        }
        
     
    }
}
