using System;


namespace ParcialDeArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrolle un programa de gestión contable que permite regustrar, almacenar y analizar gastos anuales por concepto y departamento dentro de una organización.

            string[] departamentos = {
            "Marketing", "Contabilidad", "Recursos humanos",
            "Distribución", "Ingeniería", "Investigación"
        };

            string[] conceptos = {
            "Salarios", "Suministros", "Mobiliario", "Equipamiento", "Otros"
        };

            double[,] gastos = new double[6, 5];

            for (int i = 0; i < departamentos.Length; i++)
            {
                for (int j = 0; j < conceptos.Length; j++)
                {
                    double valor;
                    do
                    {
                        Console.Write($"Ingrese el valor del gasto para {departamentos[i]} - {conceptos[j]}: ");
                    }
                    while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0);

                    gastos[i, j] = valor;
                }
            }

            Console.WriteLine("\n===== GASTOS =====");

            Console.Write("{0,-20}");
            for (int j = 0; j < conceptos.Length; j++)
            {
                Console.Write("{0,-15}", conceptos[j]);
            }
            Console.WriteLine();

            for (int i = 0; i < departamentos.Length; i++)
            {
                Console.Write("{0,-20}", departamentos[i]);
                for (int j = 0; j < conceptos.Length; j++)
                {
                    Console.Write("{0,-15:F2}", gastos[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n--- Total por departamento ---");
            for (int i = 0; i < 6; i++)
            {
                double suma = 0;
                for (int j = 0; j < 5; j++)
                {
                    suma += gastos[i, j];
                }
                Console.WriteLine($"{departamentos[i]}: {suma:F2}");
            }

            Console.WriteLine("\n--- Total por concepto ---");
            for (int j = 0; j < 5; j++)
            {
                double suma = 0;
                for (int i = 0; i < 6; i++)
                {
                    suma += gastos[i, j];
                }
                Console.WriteLine($"{conceptos[j]}: {suma:F2}");
            }

            double totalGeneral = 0;
            foreach (double valor in gastos)
            {
                totalGeneral += valor;
            }
            Console.WriteLine($"\nTotal en general del año: {totalGeneral:F2}");

            Console.WriteLine("\n--- 'Otros' gastos ---");
            double[] otros = new double[6];

            for (int i = 0; i < 6; i++)
            {
                otros[i] = gastos[i, 4];
                Console.WriteLine($"{departamentos[i]}: {otros[i]:F2}");
                
            }
            double max = gastos[0, 0];
            int departamentosMax = 0;
            int conceptosMax = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (gastos[i, j] > max)
                    {
                        max = gastos[i, j];
                        departamentosMax = i;
                        conceptosMax = j;
                    }
                }
            }

            Console.WriteLine("\n--- Mayor gasto  ---");
            Console.WriteLine($"Valor: {max:F2}");
            Console.WriteLine($"Departamento: {departamentos[departamentosMax]}");
            Console.WriteLine($"Concepto: {conceptos[conceptosMax]}");

            //:3 miau ✧2
        }
    }
}
        


