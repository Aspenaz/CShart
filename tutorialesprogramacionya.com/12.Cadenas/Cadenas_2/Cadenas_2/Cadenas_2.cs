/* Problema 2:
    Solicitar el ingreso de dos apellidos. Mostrar un mensaje si son 
    iguales o distintos.
*/

using System;

class Cadenas_2
{
    static void Main()
    {
        Console.Write("Ingrese apellido 1: ");
        String apellido1 = Console.ReadLine();

        Console.Write("Ingrese apellido 2: ");
        String apellido2 = Console.ReadLine();

        if (apellido1 == apellido2)
        {
            Console.WriteLine("Apellidos son iguales.");
        }
        else
        {
            Console.WriteLine("Apellidos son distintos.");
        }

        Console.ReadKey();
    }
}

