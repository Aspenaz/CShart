// 5. Escribir un programa que lea n números enteros y calcule la
// cantidad de valores mayores o iguales a 1000.
// Este tipo de problemas también se puede resolver empleando la
// estructura repetitiva for. Lo primero que se hace es cargar una
// variable que indique la cantidad de valores a ingresar. Dicha
// variable se carga antes de entrar a la estructura repetitiva for.
// La estructura for permite que el valor inicial o final dependa de una variable cargada previamente por teclado.

using System;

class MayoresIguales
{
    static void Main()
    {
        int count = 0;

        Console.Write("Ingrese n: ");
        int n = int.Parse(Console.ReadLine());

        for (int f = 1; f <= n; f++)
        {
            Console.Write($"Ingrese valor {f,2}: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor >= 1000)
            {
                count++;
            }
        }

        Console.WriteLine($"\nCantidad de mayores a 1000: {count}");

        Console.ReadKey();  
    }

}

