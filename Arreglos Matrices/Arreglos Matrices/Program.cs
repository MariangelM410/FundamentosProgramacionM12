using System;


namespace Arreglos_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que realice la suma de dos matrices de dimensiones 2x3

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];


            //Ingreso de la primera matriz
            Console.WriteLine("Ingrese los elementos de la primera matriz (2x3):");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]:");
                    matriz1[i, j] =
                    int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Ingrese los elementos de la segunda matriz (2x3):");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Elemento [{i},{j}]:");
                    matriz2[i, j] =
                    int.Parse(Console.ReadLine());
                }
            }
            
        Console.WriteLine("Matriz resultante de la suma");

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(suma[i, j] + "t");
                }
                Console.WriteLine();
            }


                    /*   //Fila, columna//
                           int[,] numeros = new int[2, 3];
                           numeros[0, 0] = 13;
                           numeros[0, 1] = 65;
                           numeros[0, 2] = 0;
                           numeros[1, 0] = 45;
                           numeros[1, 1] = 100;
                           numeros[1, 2] = 29;

                           string[,] nombres =
                                              {
                                                {"Ferney","Martin"},
                                                {"Eustalino","TuntungSahur"},
                                                {"Postman","Robbie"},
                                              };

                           //Recorrer matirx para llenarla
                           char[,] simbolos new char[2, 5];

                           for (int f = 0; f < 2; f++) //Recorrer las filas
                           {
                               for (int c = 0; c < 5; c++) //Recorre las columnas
                               {
                                   Console.WriteLine($"Ingrese el valor para la matriz [{f},{c}]:");
                                   simbolos[f, c] = char.Parse(Console.ReadLine());
                               }
                           }
                           Console.Clear();
                           //Recorrer matrix para recuperar datos
                           for (int f = 0; f < simbolos.GetLength(0); f++)//GetLength(0) devuelve el # de filas
                           {
                               for (int c = 0; c < simbolos.GetLength(1); c++)//GetLength(1) devuelve el # de columnas
                               {
                                   Console.Write($"{simbolos[f, c]} | ");
                               }
                               Console.WriteLine(); */
                }







        }
}
}
