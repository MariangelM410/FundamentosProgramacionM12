using System;


namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //1.Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
        //encuentre y muestre el valor máximo y mínimo de los números ingresados. 
        {
        int[] vector = new int[15];

        Console.WriteLine("Ingrese 15 números:");

        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            vector[i] = int.Parse(Console.ReadLine());
        }

        int max = vector[0];
        int min = vector[0];

        for (int i = 1; i < 15; i++)
        {
            if (vector[i] > max)
            {
                max = vector[i];
            }

            if (vector[i] < min)
            {
                min = vector[i];
            }
        }

        Console.WriteLine($"\nValor máximo: {max}");
        Console.WriteLine($"Valor mínimo: {min}");
    }
        }

        /*// Escribir un algoritmo que permita:
        //a.Crear dos vectores del mismo tamaño.
        //b.Llenarlos con números.
        //c.Comparar posición por posición. *//*
        
        {
        Console.Write("Ingrese el tamaño del vector: ");
        int n = int.Parse(Console.ReadLine());

        int[] vector1 = new int[n];
        int[] vector2 = new int[n];

        Console.WriteLine("\nVector 1:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            vector1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nVector 2:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            vector2[i] = int.Parse(Console.ReadLine());
        }

        int iguales = 0;

        for (int i = 0; i < n; i++)
        {
            if (vector1[i] == vector2[i])
            {
                iguales++;
            }
        }

        Console.WriteLine($"\nCantidad de elementos iguales: {iguales}");

        }*/

    }
    //*3. Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
    //orden de los elementos del vector.Se deben mostrar lo dos vectores.*/
    /*{
        char[] vector = new char[6];
        char[] invertido = new char[6];

        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write($"Elemento [{i}]: ");
            vector[i] = char.Parse(Console.ReadLine());
        }


        for (int i = 0; i < vector.Length; i++)
        {
            invertido[i] = vector[vector.Length - 1 - i];
        }

        Console.WriteLine("\nOriginal:");
        foreach (char c in vector) Console.Write(c + " ");

        Console.WriteLine("\nInvertido:");
        foreach (char c in invertido) Console.Write(c + " ");*/
    }
//4. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
//0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
//número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
//vector resaltando el número en un color diferente. Si no se encuentra el número, se debe
//devolver y mostrar -1. 4. Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
//0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
//número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
//vector resaltando el número en un color diferente. Si no se encuentra el número, se debe
//devolver y mostrar -1. 

/*{
    int[] vector = new int[20];
    Random generadorAleatorio = new Random();

    for (int i = 0; i < 20; i++)
    {
        vector[i] = rnd.Next(0, 51);
    }

    Console.Write("Ingrese número a buscar: ");
    int num = int.Parse(Console.ReadLine());

    int posicion = -1;

    for (int i = 0; i < 20; i++)
    {
        if (vector[i] == num)
        {
            posicion = i;
            break;
        }
    }

    Console.WriteLine("\nVector:");
    for (int i = 0; i < 20; i++)
    {
        if (i == posicion)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(vector[i] + " ");
            Console.ResetColor();
        }
        else
        {
            Console.Write(vector[i] + " ");
        }
    }

    Console.WriteLine();

    if (posicion != -1)
        Console.WriteLine($"Encontrado en posición: {posicion}");
    else
        Console.WriteLine("No encontrado (-1)");
}*/

//5.Escribir un algoritmo que permita:
//a.Crear un vector con rango impar, exceptuando el 1.
//b. Pedirle al usuario un número entero y almacenarlo en la mitad del vector.
//c. Llenar la primera mitad del vector, con los números menores al número almacenado
//en la posición de la mitad.
//d. Llenar la parte inicial del vector, con los números menores al número almacenado
//en la posición de la mitad.
//e. Llenar la parte final del vector, con los números mayores al número almacenado en
//la posición de la mitad.
//f. Mostrar el vector en pantalla. 
/*{
    int[] vector = new int[11]; // impar
    int mitad = vector.Length / 2;

    Console.Write("Ingrese número central: ");
    int num = int.Parse(Console.ReadLine());

    vector[mitad] = num;

    int valor = num - 1;
    for (int i = mitad - 1; i >= 0; i--)
    {
        vector[i] = valor;
        valor--;
    }

    valor = num + 1;
    for (int i = mitad + 1; i < vector.Length; i++)
    {
        vector[i] = valor;
        valor++;
    }

    Console.WriteLine("\nVector:");
    foreach (int v in vector)
        Console.Write(v + " ");*/
}

//6.Escribir un algoritmo que permita:
//a.Crear dos vectores, el rango para cada uno de los vectores los debe ingresar el
//usuario.
//b. LLenar el primer vector con números aleatorios entre 0 y su rango+1
//c. LLenar el segundo vector con números aleatorios entre rango y rango*2
//d. Combinar los dos vectores en uno solo.
//e. Mostrar en pantalla los tres vectores
//{
/*    Console.Write("Tamaño: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Rango: ");
    int rango = int.Parse(Console.ReadLine());

    int[] v1 = new int[n];
    int[] v2 = new int[n];
    int[] combinado = new int[n * 2];

    Random generadorAleatorio = new Random();

    for (int i = 0; i < n; i++)
        v1[i] = rnd.Next(0, rango + 1);

    for (int i = 0; i < n; i++)
        v2[i] = rnd.Next(rango, rango * 2 + 1);

    for (int i = 0; i < n; i++)
        combinado[i] = v1[i];

    for (int i = 0; i < n; i++)
        combinado[i + n] = v2[i];

    Console.WriteLine("\nVector 1:");
    foreach (int v in v1) Console.Write(v + " ");

    Console.WriteLine("\nVector 2:");
    foreach (int v in v2) Console.Write(v + " ");

    Console.WriteLine("\nCombinado:");
    foreach (int v in combinado) Console.Write(v + " ");*/
}
//7.Escribir un algoritmo que permita:
//a.Crear un vector de nombres.
//b. Solicitar una letra al usuario.
//c. Contar cuántos nombres empiezan con esa letra.
/*{
    string[] nombres = new string[5];

    for (int i = 0; i < nombres.Length; i++)
    {
        Console.Write($"Nombre [{i}]: ");
        nombres[i] = Console.ReadLine();
    }

    Console.Write("Ingrese letra: ");
    char letra = char.ToLower(Console.ReadLine()[0]);

    int contador = 0;

    foreach (string nombre in nombres)
    {
        if (char.ToLower(nombre[0]) == letra)
            contador++;
    }

    Console.WriteLine($"Cantidad: {contador}");*/
}
//8.Escribir un algoritmo que permita:
//a.Crear un vector de nombres.
//b. Identificar cuáles se repiten.
//c. Mostrar cuántas veces aparece cada uno.
/*{
    string[] nombres = new string[5];

    for (int i = 0; i < nombres.Length; i++)
    {
        Console.Write($"Nombre [{i}]: ");
        nombres[i] = Console.ReadLine();
    }

    Console.WriteLine("\nFrecuencia:");

    for (int i = 0; i < nombres.Length; i++)
    {
        int contador = 0;

        for (int j = 0; j < nombres.Length; j++)
        {
            if (nombres[i] == nombres[j])
                contador++;
        }

        Console.WriteLine($"{nombres[i]}: {contador}");*/
    }


