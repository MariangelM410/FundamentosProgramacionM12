using System;

namespace VariableConstantesTiposDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //OPERADORES NUMERICOS
            //Cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = -num2;
            Console.Write(num1 + "//" + num2 + "//" + num3);
            //Aritméticos
            int num4 = 3 + 5;
            int num5 = 12 - 63;
            int num6 = 26 * 14;
            float num7 = 5f / 3; //(float) 5 / 3;
            Console.Write("\nSuma: {0}, Resta: {1}, Multiplicación: {2}, División: {3}", num4, num5, num6, num7);
            //incremento y decremento
            num4++; //a la variable num4=4+1; 
            num5--; //num5=num5-1;
            num6 += 4; // num6=num6+4;
            num4 -= 10; // num4=num4-10;
            num5 *= 3; // num5=num5*3;
            num6 /= 2; // num6=num6/2;
            num6 *= num4; // num6=num6*num4; 
            //orden de evaluación de operadores numéricos aretméticos
            int num8 = 4 * 3 / 2;
            int num9 = 4 * (3 / 2);
            int num10 = 4 + 6 * (3 / 2);
            //operadores lógicos
            //conjunción = Y- AND - &&
            Console.WriteLine("\nTABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine("V Y V : " + (true && true));
            Console.WriteLine("V Y F : " + (true && false));
            Console.WriteLine("F Y V : " + (false && true));
            Console.WriteLine("F Y F : " + (false && false));
            Console.WriteLine("---------------------------");
            //Disyunción - O - OR - ||
            Console.WriteLine("\nTABLA DE VERDAD CONJUNCIÓN");
            Console.WriteLine("V O V : " + (true || true));
            Console.WriteLine("V O F : " + (true || false));
            Console.WriteLine("F O V : " + (false || true));
            Console.WriteLine("F O F : " + (false || false));
            Console.WriteLine("---------------------------");
            // OPERACIÓN DE COMPARACIÓN
            bool dato1 = 4 > 5;
            bool dato2 = 16 != 100;
            bool dato3 = 1 == 1;
            bool dato4 = !dato3;
            bool dato5 = 100 < 200 || dato3 && true; 

        }

    }
}
