// Desarrollar un programa que muestre la tabla de multiplicar
// del 5 (del 5 al 50)


using System;

class _3
{
    static void Main()
    {
        for (int f= 5; f<= 50; f=f+5)
        {
            //Console.WriteLine($"5 * {f,2} = {5 * f,2}");
            Console.Write($"{f} ");
        }

        Console.ReadKey();
    }
}

