// 2. Desarrollar un programa que solicite la carga de 10 números
// e imprima la suma de los últimos 5 valores ingresados.

using System;

class _2
{
    static void Main()
    {
        int suma = 0;

        for (int i = 1; i <= 10;  i++)
        {
            Console.Write($"Ingrese número {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (i > 5)
            {
                suma += num;
            }
        }
        Console.WriteLine($"Suma 5 últimos: {suma}");

        Console.ReadKey();
    }
}

