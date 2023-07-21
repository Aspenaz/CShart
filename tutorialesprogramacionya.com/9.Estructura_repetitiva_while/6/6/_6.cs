// Realizar un programa que permita cargar dos listas de 15 valores cada una.
// Informar con un mensaje cual de las dos listas tiene un valor acumulado
// mayor (mensajes "Lista 1 mayor", "Lista 2 mayor", "Listas iguales")
// Tener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.

using System;

internal class _6
{
    static void Main()
    {
        int cont = 1, suma1 = 0, suma2 = 0;

        Console.WriteLine("Lista 1");
        while(cont <= 3) // reemplazo 3 por 15.
        {
            Console.Write($"Ingrese valor {cont}: ");
            int valor = int.Parse( Console.ReadLine() );
            suma1 += valor;

            cont++;
        }

        cont = 1;
        Console.WriteLine("Lista 2");
        while (cont <= 3)  // reemplazo 3 por 15.
        {
            Console.Write($"Ingrese valor {cont}: ");
            int valor2 = int.Parse( Console.ReadLine() );   
            suma2 += valor2;

            cont++;
        }

        Console.WriteLine();    
        Console.WriteLine($"Suma lista 1: {suma1}");
        Console.WriteLine($"Suma lista 2: {suma2}");

        if (suma1 > suma2)
        {
            Console.WriteLine("\nLista 1 mayor");
        }
        else
        {
            if(suma2 > suma1)
            {
                Console.WriteLine("\nLista 2 mayor");
            }
            else
            {
                Console.WriteLine("\nListas iguales");
            }
        }

        Console.ReadKey();
            
    }
}

