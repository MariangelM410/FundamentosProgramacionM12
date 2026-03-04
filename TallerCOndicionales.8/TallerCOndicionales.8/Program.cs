using System;


namespace TallerCOndicionales._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numero1 = 0.0f;
            float numero2 = 0.0f;  
            float numero3 = 0.0f;

            Console.WriteLine("Ingrese el numero 1");
            numero1 = Single.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el numero 2");
            numero2 = Single.Parse (Console.ReadLine());
            Console.WriteLine("Ingrese el numero 3");
            numero3 = Single.Parse (Console.ReadLine());

            /* if (numero1 != numero2 && numero2 != numero3)
             {
                 Console.WriteLine("Los numeros son diferentes");
             }
             if (numero1> numero2 && numero1> numero3) 
             {
                 Console.WriteLine($"El {numero1} es mayor");
             }
             if (numero2> numero1 && numero2> numero3)
             {
                 Console.WriteLine($"El {numero2} es mayor");
             }
             if (numero3> numero1 && numero3> numero2)
             {
                 Console.WriteLine($"El {numero3} es mayor");
             }
             if (numero1> numero2)
             {
                 if (numero1> numero3)
                 {
                     Console.WriteLine($"El {numero1} es mayor");
                 }

             }*/
            float mayor = 0;
            float medio = 0;
            float menor = 0;

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                //Console.WriteLine("Los números son diferentes");
                if (numero1>numero2)
                {
                    if (numero1 > numero3)
                    {
                        mayor = numero1;
                        if (numero2 > numero3)
                        {
                            medio = numero2;
                            menor = numero3;
                        }
                        else
                        {
                            medio = numero3;
                            menor = numero2;
                        }
                    }
                    else
                    {
                        mayor = numero3;
                        if (numero1 > numero2)
                        { 
                            medio= numero1;
                            menor= numero2;
                        }
                        else
                        {
                            medio = numero2;
                            menor = numero1;
                        }
                    }
                    
                }
                else
                {
                    if (numero2>numero3)
                    {
                        mayor = numero2;
                        if (numero1>numero3)
                        {
                            medio = numero1;
                            menor = numero3;
                        }
                        else
                        {
                            medio=numero3;
                            menor = numero1;
                        }

                    }
                    else
                    {
                        mayor= numero3;
                        if (numero1>numero2)
                        {
                            medio = numero1;
                            menor = numero2;
                        }
                        else
                        {
                            medio = numero2;
                            menor= numero1;
                        }

                    }
                    
                }

            }
            else
            {
                Console.WriteLine("Error hay números Son Iguales");
            }


        }
    }
}
