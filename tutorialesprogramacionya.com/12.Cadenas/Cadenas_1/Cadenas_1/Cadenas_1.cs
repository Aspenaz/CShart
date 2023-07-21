/* Problema 1:
    Solicitar el ingreso del nombre y edad de dos personas. Mostrar el 
    nombre de la persona con mayor edad.
*/

using System;

class Cadenas_1
{
    static void Main()
    {
        Console.Write("Ingrese nombre: ");
        String nombre1 = Console.ReadLine();

        Console.Write("Ingrese edad: ");
        int edad1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nombre: ");
        String nombre2 = Console.ReadLine();

        Console.Write("Ingrese edad: ");
        int edad2 = int.Parse(Console.ReadLine());

        Console.Write("La persona de mayor edad es: ");
        if (edad1 > edad2)
        {
            Console.WriteLine(nombre1);
        }
        else
        {
            Console.WriteLine (nombre2);
        }

        Console.ReadKey();


    }
}

