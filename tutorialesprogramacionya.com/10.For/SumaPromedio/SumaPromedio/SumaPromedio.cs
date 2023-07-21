// 2. Desarrollar un programa que permita la carga de 10 valores por teclado
// y nos muestre posteriormente la suma de los valores ingresados y su
// promedio. Este problema ya lo desarrollamos, lo resolveremos empleando
// la estructura for

using System;

class SumaPromedio
{
    static void Main()
    {
        int suma = 0, f;
        float promedio;

        for (f=1; f<=10; f++)
        {
            Console.Write($"Ingrese valor {f,2}: ");
            int valor = int.Parse(Console.ReadLine());

            suma += valor;
        }
        promedio = (float) suma / 10;
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
        Console.WriteLine($"Contador: {f}");

        Console.ReadKey();
    }
}

