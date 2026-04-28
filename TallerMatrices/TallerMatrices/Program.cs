using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;


namespace TallerMatrices
{
    internal class Program
    {
        static void Main(string[] args)
        //1. Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
        //pantalla la suma de los elementos de cada columna.
        {
            int[,] matriz = new int[10, 20];
            int suma;

            Random generadorAleatorio = new Random();

          
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    matriz[i, j] = generadorAleatorio.Next(1, 10);
                }
            }

            Console.WriteLine("Suma de cada columna:");

            for (int j = 0; j < 20; j++)
            {
                suma = 0;

                for (int i = 0; i < 10; i++)
                {
                    suma += matriz[i, j];
                }

                Console.WriteLine($"Columna {j}: {suma}");
            }

            // 2.Desarrollar un programa que crea una matriz de n filas* m columnas, el usuario ingresa
            //caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
            //primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
            //matriz con el intercambio de filas.

            {
                Console.Write("Filas: ");
                int n = int.Parse(Console.ReadLine());

                Console.Write("Columnas: ");
                int m = int.Parse(Console.ReadLine());

                char[,] matriz = new char[n, m];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write($"[{i},{j}]: ");
                        matriz[i, j] = char.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nMatriz original:");
                Mostrar(matriz, n, m);

                for (int j = 0; j < m; j++)
                {
                    char temp = matriz[0, j];
                    matriz[0, j] = matriz[n - 1, j];
                    matriz[n - 1, j] = temp;
                }

                Console.WriteLine("\nMatriz con filas intercambiadas:");
                Mostrar(matriz, n, m);
            }

            static void Mostrar(char[,] mat, int n, int m)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(mat[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            //3. Crear un algoritmo que cuente la frecuencia de cada número del 1 al 10 en una matriz de
            //5x5 llena de números aleatorios.
            //El algoritmo debe permitir:
            //. Usa la función Random para generar los números aleatorios.
            //. Crea un arreglo adicional para almacenar la frecuencia de cada número.
            //. Mostrar la matriz y el nuevo arreglo con la frecuencia de cada número
            {
                int[,] matriz = new int[5, 5];
                int[] frecuencia = new int[11]; // usamos 1 a 10
                Random generadorAleatorio = new Random();

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        matriz[i, j] = generadorAleatorio.Next(1, 11);
                        frecuencia[matriz[i, j]]++;
                    }
                }

                Console.WriteLine("Matriz:");
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("\nFrecuencia:");
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i}: {frecuencia[i]} veces");
                }


                //4.Crea un algoritmo que represente un tablero de juego de 5x5 donde se coloquen 3 "X" en
                //   posiciones aleatorias.Luego, el algoritmo le debe permitir al usuario intentar adivinar la
                //posición de una "X".
                //El algoritmo debe permitir:
                //. Usar la función Random para colocar las "X" en la matriz.
                //. Realizar 3 intentos para ingresar coordenadas y verificar si ha acertado.
                //. Al final sacar un mensaje de éxito o error.Si el mensaje es de éxito mostrar la
                //posición de la X en la matriz.Si el mensaje es de error, mostrar la matriz. 
                {
                    char[,] tablero = new char[5, 5];
                    Random generadorAleatorio = new Random();

                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            tablero[i, j] = '-';
                        }
                    }

                    int colocadas = 0;
                    while (colocadas < 3)
                    {
                        int f = generadorAleatorio.Next(0, 5);
                        int c = generadorAleatorio.Next(0, 5);

                        if (tablero[f, c] != 'X')
                        {
                            tablero[f, c] = 'X';
                            colocadas++;
                        }
                    }

                    bool acierto = false;

                    for (int intento = 1; intento <= 3; intento++)
                    {
                        Console.Write($"Intento {intento} - fila: ");
                        int f = int.Parse(Console.ReadLine());

                        Console.Write("columna: ");
                        int c = int.Parse(Console.ReadLine());

                        if (tablero[f, c] == 'X')
                        {
                            Console.WriteLine("¡Acertaste!");
                            Console.WriteLine($"La X estaba en [{f},{c}]");
                            acierto = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Fallaste.");
                        }
                    }

                    if (!acierto)
                    {
                        Console.WriteLine("\nNo encontraste ninguna X. Tablero:");
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write(tablero[i, j] + " ");
                            }
                            Console.WriteLine();
                        }
                
                //5.Desarrollar un programa e C# que:
                // Le pida al usuario ingresar por teclado el número de filas y columnas de una matriz
                //de enteros
                // Cargue los datos de la matriz ingresándolos por teclado
                // Muestre la matriz ingresada
                // Luego convierta cada fila de la matriz en una columna, es decir la fila 1 pasaría a ser
                //ahora la columna 1.
                // Mostrar la nueva matriz
                 {
                            Console.Write("Ingrese el número de filas: ");
                            int filas = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese número de columnas: ");
                            int columnas = int.Parse(Console.ReadLine());

                            int[,] matriz = new int[filas, columnas];

                            Console.WriteLine("\nIngrese los datos de la matriz:");
                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    Console.Write($"[{i},{j}]: ");
                                    matriz[i, j] = int.Parse(Console.ReadLine());
                                }
                            }

                            Console.WriteLine("\nMatriz original:");
                            mostrar(matriz, filas, columnas);

                            int[,] transpuesta = new int[columnas, filas];

                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    transpuesta[j, i] = matriz[i, j];
                                }
                            }

                            Console.WriteLine("\nMatriz transpuesta:");
                            Mostrar(transpuesta, columnas, filas);
                        }

                        static void mostrar(int[,] mat, int filas, int columnas)
                        {
                            for (int i = 0; i < filas; i++)
                            {
                                for (int j = 0; j < columnas; j++)
                                {
                                    Console.Write(mat[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            //6.Crear una aplicación en C# que permita realizar las siguientes acciones:
                            //. Crear una matriz de n filas por m columnas
                            //. Llenar la matriz con números aleatorios del 1 al 3(investigar la función random en C#)
                            //. Mostrar la matriz generada
                            // Mostrar por pantalla cuantas veces fue ingresado el número 1, el número 2, y el
                            //número 3, y cuál de los tres números fue repetido más veces.
                            {
                                Console.Write("Ingrese número de filas: ");
                                int filas = int.Parse(Console.ReadLine());

                                Console.Write("Ingrese número de columnas: ");
                                int columnas = int.Parse(Console.ReadLine());

                                int[,] matriz = new int[filas, columnas];

                                Random generadorAleatorio = new Random();

                                int cont1 = 0, cont2 = 0, cont3 = 0;

                                for (int i = 0; i < filas; i++)
                                {
                                    for (int j = 0; j < columnas; j++)
                                    {
                                        matriz[i, j] = generadorAleatorio.Next(1, 4); 

                                        if (matriz[i, j] == 1) cont1++;
                                        else if (matriz[i, j] == 2) cont2++;
                                        else if (matriz[i, j] == 3) cont3++;
                                    }
                                }

                                Console.WriteLine("\nMatriz generada:");
                                for (int i = 0; i < filas; i++)
                                {
                                    for (int j = 0; j < columnas; j++)
                                    {
                                        Console.Write(matriz[i, j] + " ");
                                    }
                                    Console.WriteLine();
                                }

                                Console.WriteLine("\nFrecuencias:");
                                Console.WriteLine($"Número 1: {cont1} veces");
                                Console.WriteLine($"Número 2: {cont2} veces");
                                Console.WriteLine($"Número 3: {cont3} veces");

                                int max = cont1;
                                int numero = 1;

                                if (cont2 > max)
                                {
                                    max = cont2;
                                    numero = 2;
                                }

                                if (cont3 > max)
                                {
                                    max = cont3;
                                    numero = 3;
                                }

                                Console.WriteLine($"\nEl número más repetido es: {numero} (aparece {max} veces)");
                            }




