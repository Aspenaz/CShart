// 4. Escribir un programa que lea 10 números enteros y luego muestre
// cuántos valores ingresados fueron múltiplos de 3 y cuántos de 5.
// Debemos tener en cuenta que hay números que son múltiplos de 3 y
// de 5 a la vez.

using System;

class Multiplo
{
    static void Main()
    {
        float multiplo_3 = 0, multiplo_5 = 0;

        for(int f=1; f<=10; f++)
        {
            Console.Write($"Ingrese valor {f,2}: ");
            int valor = int.Parse( Console.ReadLine() );

            if (valor%3 == 0)
            {
                multiplo_3 += 1;
            }
            if (valor%5 == 0)
            {
                multiplo_5 += 1;
            }            
        }

        Console.WriteLine($"\nMultiplos de 3: {multiplo_3}");
        Console.WriteLine($"Multiplos de 5: {multiplo_5}");

        Console.ReadKey();
    }
}

