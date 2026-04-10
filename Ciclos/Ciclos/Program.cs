using System;


namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros=new int[5]; //el rango del vector es 5, de 5 posiciones
            numeros[0] = 12; 
            numeros[1] = 13;
            numeros[2] = 42;
            numeros[3] = 201;
            numeros[4] = 0;
            //numero[5] = 1; la posición 6 con índice 5 no existe, porque el rango del vector es 5. OSEA, NO SE PONE numeros[5] = 1; PORQUE YA CONTARIA COMO 6

            Console.WriteLine($"El valor almacenado en la posición 3, con índice 2 es: {numeros[2]}");

            //Recorrer el vector para llenarlo

            string[] nombres=new string[5];

            for (int i=0; i <5; i++)
            {
                Console.WriteLine($"Ingrese el nombre para guardar ls posición {i + 1} con pindice {i} : ");
                nombres[1] = Console.ReadLine();

                char[] simbolos = new char[] { '#', '%', '?', '|', 'Q', 'ñ', '&', '9', '*', };

                //Recorrer vector para recuperar los datos almacenados en el 
                Console.Clear();
                for (int i = 0; i < simbolos.Length; i++)
                {
                    Console.WriteLine(simbolos[1] + " | "); 
                }

        }
    }
}
