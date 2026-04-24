using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoModulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMenú()

            int opcion = CapturaOpcion();
            RealizarOperacion(opcion);
        }

        static void MostrarMenú()
        {
            Console.WriteLine("----------------------Mostrar Menú----------------------");
            Console.WriteLine("    1.Suma                                2.Resta");
            Console.WriteLine("    3. Multiplicación                     4. División");
            Console.WriteLine("--------------------------------------------------------");
        }

        static int CapturaOpcion()
        {
            Console.WriteLine("Ingrese una opción del menú");
            return int.Parse(Console.ReadLine());
        }

        static void RealizarOperacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                default:
                    Console.WriteLine("Ingrese una opción válida deñ menú");
                    break;
            }

            private static void Division()
        {
            Console.WriteLine("Usted va a dividir");
        }

        private static void Multiplicacion()
        {
            Console.WriteLine("Usted va a dividir");
        }

        private static void Resta()
        {
            Console.WriteLine("Usted va a dividir");
        }

        private static void Suma()
        {
            Console.WriteLine("Usted va a dividir");
        }

    }
}
}
