using System;


namespace TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Algoritmo que permita calcular el promedio de calificaciones,
            // le permitirá al usuario, introducir tantas calificaciones como así desee,
            // en el momento en que seleccione que no desea continuar capturando
            // calificaciones, el algoritmo debe presentar el promedio de las
            // calificaciones capturadas previamente.

            bool Continue = true;
            int sumgrades = 0;
            int i = 0;
            float average = 0;
            int nota;

            while (Continue == true)
            {
                i = i + 1;
                Console.WriteLine("Ingrese nota:");
                nota = Convert.ToInt16(Console.ReadLine());
                sumgrades = sumgrades + nota;

                Console.WriteLine("Desea continuar? Escribir Si o No");
                if (Console.ReadLine() == "No")
                {
                    Continue = false;
                }
            }

            average = sumgrades / i;
            Console.WriteLine("Su promedio es de: " + average);
        }
        //* Se requiere un algoritmo para mostrar por pantalla los divisores de un
        //número ingresado por teclado.
        //Tener en cuenta que dados dos números enteros a y b, se dice que b es
        //divisor de a si se cumple que al efectuar una división entera a/b el
        //residuo es 0, en C# utilizar el operador Mod para obtener el residuo de
        //una división de dos números.
        //Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3,
        //2, 1 que son los divisores del número 6. */

        /* Console.WriteLine("Ingrese un número: ");
         int num = int.Parse(Console.ReadLine());

         int i = num;

         Console.WriteLine("Divisores:");

         while (i >= 1)
         {
             if (num % i == 0)
             {
                 Console.WriteLine(i);
             }
            i--;*/
    }
        
        // 3. Dados dos números enteros ingresados por teclado: b que es la base y
        // e que es el exponente, se requiere calcular el resultado de la
        // potenciación.
        // Ejemplo: b = 2, e = 5 o 2^5 = 2 * 2 * 2 * 2 * 2 = 32
        // Mostrar por pantalla el resultado de la potenciación.
        // Seguir pidiendo por teclado la base y el exponente y realizar la
        // potenciación correspondiente, hasta que el usuario ingrese por teclado
        // el carácter de escape ‘n’

        /*int Base = 0;
        int Exponente = 0;
        int Result = 0;
        bool Escape = true;

while (Escape == true)
{
    Console.WriteLine("Ingrese un numero para que sea la base:");
    Base = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine("Ingrese un numero para que sea el exponente");
    Exponente = Convert.ToInt16(Console.ReadLine());

    Result = Base;

    for (int i = 1; i<Exponente; i++)
    {
        Result = Result* Base;
    }

    Console.WriteLine("El resultado de la potenciacion es: " + Result);

    Console.WriteLine("If you don't wish to continue, write 'n':");
    if (Console.ReadLine() == "n")
    {
        Escape = false;*/
    }

// 4. Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
// kilómetros durante 10 días, para determinar si es apto para la prueba de
// 5 kilómetros. Para considerarlo apto debe cumplir las siguientes
// condiciones:
// - Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
// - Que al menos en una de las pruebas realice un tiempo menor de 15 minutos.
// - Que su promedio sea menor o igual a 18 minutos.
// Diseñar un algoritmo para registrar los datos y decidir si es apto para la
// competencia.

/*int sumTimes = 0;
int Minutes = 0;
bool C1 = true;
bool C2 = false;
bool C3 = false;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Ingrese el tiempo para el día " + i + " en minutos:");
    Minutes = Convert.ToInt16(Console.ReadLine());

    if (Minutes > 20) // C1
    {
        i = 10;
        C1 = false;
    }

    if (Minutes < 15)
    {
        C2 = true;
    }

    sumTimes = sumTimes + Minutes;
}

int average = sumTimes / 10;
if (average <= 18)
{
    C3 = true;
}
if (C1 == true && C2 == true && C3 == true)
{
    Console.WriteLine("Puedes participar en la carrera");
}
else
{
    Console.WriteLine("No puedes participar en la carrera");
}*/


// 5. Se aplicó una encuesta a n personas solicitando su opinión sobre el
// tema del servicio militar obligatorio para las mujeres. Las opciones de
// respuesta fueron: a favor, en contra y no responde. Se solicita un
// algoritmo que calcule qué porcentaje de los encuestados marcó cada
// una de las respuestas.

/*float numeroPersonas = 0;
float porcentajeAFavor = 0;
float porcentajeEnContra = 0;
float porcentajeNoResponde = 0;

float personasAFavor = 0;
float personasEnContra = 0;
float personasNoResponde = 0;

while (true)
{
    Console.WriteLine("Esta a favor o no, o no responde, del servicio militar obligatorio para mujeres:");
    string Respuesta = Console.ReadLine();

    if (Respuesta == "a favor")
    {
        personasAFavor = personasAFavor + 1;
        numeroPersonas = numeroPersonas + 1;
    }
    else if (Respuesta == "en contra")
    {
        personasEnContra = personasEnContra + 1;
        numeroPersonas = numeroPersonas + 1;
    }
    else if (Respuesta == "no responde")
    {
        personasNoResponde = personasNoResponde + 1;
        numeroPersonas = numeroPersonas + 1;
    }

    Console.WriteLine("Desea continuar?");
    if (Console.ReadLine() == "No")
    {
        break;
    }
}

porcentajeAFavor = (personasAFavor / numeroPersonas) * 100;
porcentajeEnContra = (personasEnContra / numeroPersonas) * 100;
porcentajeNoResponde = (personasNoResponde / numeroPersonas) * 100;

Console.WriteLine("Porcentaje de personas a favor: " + porcentajeAFavor + "%");
Console.WriteLine("Porcentaje de personas en contra: " + porcentajeEnContra + "%");
Console.WriteLine("Porcentaje de personas que no responden: " + personasNoResponde + "%");*/


/*// 6. Realizar un algoritmo que lea 40 números e imprima en pantalla cuántos
// de esos números son positivos, cuántos negativos, cuántos son neutros
// (0); además que imprima por pantalla la sumatoria de los números
// positivos y la de los negativos.

int number = 0;
int countPos = 0;
int countNeg = 0;
int countNeu = 0;
int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < 40; i++)
{
    Console.WriteLine("Ingrese un numero:");
    number = Convert.ToInt16(Console.ReadLine());

    if (number > 0)
    {
        countPos = countPos + 1;
        sumPos = sumPos + number;
    }
    else if (number < 0)
    {
        countNeg = countNeg + 1;
        sumNeg = sumNeg + number;
    }
    else if (number == 0)
    {
        countNeu = countNeu + 1;
    }
}

Console.WriteLine("Hay " + countPos + " numeros positivos, y su sumatoria es de: " + sumPos);
Console.WriteLine("Hay " + countNeg + " numeros negativos, y su sumatoria es de: " + sumNeg);
Console.WriteLine("Hay " + countNeu + " numeros neutros");
}*/

    // 7. Una persona desea realizar un muestreo con 70 personas para
    // determinar el promedio de peso de los niños, jóvenes, adultos y viejos
    // que existen en su zona y cuántos son de cada una de las categorías.
    // Las categorías están dadas por la siguiente tabla:
    // Categoría Edad
    // Niños 0 - 13
    // Jóvenes 14 - 30
    // Adultos 31 - 60
    // Viejos 61 en adelante

    /*int promKids = 0;
    int promyAdults = 0;
    int promAdults = 0;
    int promOld = 0;

    int sumKids = 0;
    int sumyAdults = 0;
    int sumAdults = 0;
    int sumOld = 0;

    int countKids = 0;
    int countyAdults = 0;
    int countAdults = 0;
    int countOld = 0;

    for (int i = 1; i <= 70; i++)
    {
        Console.WriteLine("Inserte edad:");
        int response = Convert.ToInt16(Console.ReadLine());

        if (response <= 13)
        {
            Console.WriteLine("Inserte peso en kilogramos");
            response = Convert.ToInt16(Console.ReadLine());
            sumKids = sumKids + response;
            countKids = countKids + 1;
        }
        else if (13 < response && response <= 30)
        {
            Console.WriteLine("Inserte peso en kilogramos");
            response = Convert.ToInt16(Console.ReadLine());
            sumyAdults = sumyAdults + response;
            countyAdults = countyAdults + 1;
        }
        else if (30 < response && response <= 60)
        {
            Console.WriteLine("Inserte peso en kilogramos");
            response = Convert.ToInt16(Console.ReadLine());
            sumAdults = sumAdults + response;
            countAdults = countAdults + 1;
        }
        else if (60 < response)
        {
            Console.WriteLine("Inserte peso en kilogramos");
            response = Convert.ToInt16(Console.ReadLine());
            sumOld = sumOld + response;
            countOld = countOld + 1;
        }
    }

    promKids = sumKids / countKids;
    promyAdults = sumyAdults / countyAdults;
    promAdults = sumAdults / countAdults;
    promOld = sumOld / countOld;

    Console.WriteLine("El promedio de pesos de los niños es de: " + promKids);
    Console.WriteLine("El promedio de pesos de los jóvenes es de: " + promyAdults);
    Console.WriteLine("El promedio de pesos de los adultos es de: " + promAdults);
    Console.WriteLine("El promedio de pesos de los adultos mayores es de: " + promOld);*/
}

// 8. El Departamento de Tránsito de Antioquia desea saber de los n autos
// que circulan a la ciudad de Medellín, cuántos autos tienen como
// calcomanía de un determinado color. Conociendo el último dígito de la
// placa de cada automóvil se puede determinar el color de la calcomanía.
// Para determinar lo anterior utilice la siguiente tabla:
// Dígito Color
// 1 o 2 amarilla
// 3 o 4 rosa
// 5 o 6 roja
// 7 o 8 verde
// 9 o 0 azul

/*int countAmarillo = 0;
int countRosa = 0;
int countRojo = 0;
int countVerde = 0;
int countAzul = 0;
int digplaca = 0;

while (true)
{
    Console.WriteLine("Inserte el ultimo digito de su placa: ");
    digplaca = Convert.ToInt16(Console.ReadLine());

    if (digplaca == 1 || digplaca == 2)
    {
        countAmarillo = countAmarillo + 1;
    }
    else if (digplaca == 3 || digplaca == 4)
    {
        countRosa = countRosa + 1;
    }
    else if (digplaca == 5 || digplaca == 6)
    {
        countRojo = countRojo + 1;
    }
    else if (digplaca == 7 || digplaca == 8)
    {
        countVerde = countVerde + 1;
    }
    else if (digplaca == 9 || digplaca == 0)
    {
        countAzul = countAzul + 1;
    }

    Console.WriteLine("Desea continuar? Responda Si o No");
    if (Console.ReadLine() == "No")
    {
        break;
    }
}

Console.WriteLine("Hay " + countAmarillo + " carros con stickers Amarillos.");
Console.WriteLine("Hay " + countRosa + " carros con stickers Rosas.");
Console.WriteLine("Hay " + countRojo + " carros con stickers Rojos.");
Console.WriteLine("Hay " + countVerde + " carros con stickers Verdes.");
Console.WriteLine("Hay " + countAzul + " carros con stickers Azules.");
*/
}


