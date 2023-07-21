/* Problema 2:
    Escribir un programa que solicite la carga de números por teclado, 
    obtener su promedio. Finalizar la carga de valores cuando se cargue 
    el valor 0.
*/
using System;

class DoWhile_2
{
    static void Main()
    {
        int valor, promedio, suma = 0, cant = 0;

        do
        {
            Console.Write("Ingrese valor (0 para finalizar): ");
            valor = int.Parse(Console.ReadLine());

            if (valor != 0)
            {
                suma += valor;
                cant++;
            }
        } while (valor != 0);

        if (cant != 0)
        {
            promedio = suma / cant;
            Console.Write($"El proomedio de los valores ingresados es: {promedio}");
        }
        else
        {
            Console.WriteLine("No se ingresaron valores");
        }
        Console.WriteLine();

        Console.ReadKey();  
    }
}

