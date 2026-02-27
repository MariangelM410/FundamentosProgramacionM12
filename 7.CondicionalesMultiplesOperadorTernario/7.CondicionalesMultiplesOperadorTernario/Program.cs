using System;


namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diaSemana = "";
            float subtotal = 0;
            float descuento = 0;

            Console.WriteLine("Ingrese el monto de la compra");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana");
            diaSemana = Console.ReadLine().ToLower();

            switch (diaSemana)
            {
                case "lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es lunes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;


                case "martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "miercoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es jueves, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "viernes":
                    descuento = subtotal * 0.20f;
                    Console.WriteLine($"Hoy es viernes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "sabado":
                    descuento = subtotal * 0.0f;
                    Console.WriteLine($"Hoy es sabado, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "domingo":
                    descuento = subtotal * 0.0f;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                default:
                    Console.WriteLine("Escriba un día de la semana válido");
                    break;
            }
        }
    }
}
