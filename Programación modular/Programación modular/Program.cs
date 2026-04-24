using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación_modular
{
    internal class Program
    {
        static int añoActual = 2026;

        static void Main(string[] args)
        {
            //Programación Modular
            string nombre = "Ferney";
            string apellidos = "Chica Álvarez";
            Console.WriteLine($"Edad: {EdadAñoNacimiento()}");
            Saludo("Ferney" , "Chica álvarez");
            Saludo("Carlos" , "Perez Lopez");
            Console.WriteLine($"Edad: {EdadAoNacimiento(2001))}");
            Console.ReadKey();
            BorrarPantalla();
        }
        //Procedimientos sin parámetros
        static void BorrarPantalla()

        {
            Console.Clear(); 
        }

        //Procedimientos con parámetros


        static void Saludo(string nombre, string apellido)
        {
            Console.WriteLine($"Bienvenidos {nombre} {apellido}, a la programación modular");
        }

        //Funciones sin parámetros

        static int EdadAñoNacimiento()
        {
            int añoNacimiento = 1999;
            int edad = añoActual - añoNacimiento;
            return edad; 
        }

        //Funciones con parámetros

        static int EdadAñoNacimiento(int añoNacimiento)
        {
            return añoActual - añoNacimiento; 
        }
     }
}
