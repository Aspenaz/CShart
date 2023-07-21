// Problema 2:
// Escribir un programa que solicite la carga de un valor positivo y nos
// muestre desde 1 hasta el valor ingresado de uno en uno.
// Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.


using System;

class while_2
{
    static void Main()
    {
        int limit = 1;
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        while (limit <= num)
        {
            Console.Write($"{limit} ");
            limit++;    
        }

        Console.WriteLine();

        //Console.ReadKey();  
    }
}

