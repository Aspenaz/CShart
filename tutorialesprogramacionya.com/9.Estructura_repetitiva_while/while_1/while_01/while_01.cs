// Problema 1:
// Realizar un programa que imprima en pantalla los números del 1 al 100.

using System;

class while_01
{
    static void Main()
    {
        int count = 0;

        while (count <= 100)
        {
            Console.Write($"{count} ");
            //count++;
            count += 2;
        }
       // Console.WriteLine("");
        Console.ReadKey();
    }
}

