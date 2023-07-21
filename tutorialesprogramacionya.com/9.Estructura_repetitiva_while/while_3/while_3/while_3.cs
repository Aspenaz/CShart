// Problema 3:
// Desarrollar un programa que permita la carga de 10 valores por teclado y
// nos muestre posteriormente la suma de los valores ingresados y su promedio.

using System;

class while_3
{
    static void Main()
    {
        int limit = 1;
        int num, total, suma = 0, promedio = 0;

        while (limit <= 10)
        {
            Console.Write($"{limit,2} Ingrese valor : ");
            num = int.Parse( Console.ReadLine() );

            suma += num;
           
            limit++;   

        }
        total = limit - 1;

        promedio = suma / total;

        Console.WriteLine($"\nCantidad: {total}");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
        Console.ReadKey();
        
    }
}

