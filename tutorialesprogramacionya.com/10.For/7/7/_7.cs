/*  Se realiza la carga de 10 valores enteros por teclado. Se desea 
    conocer:
    a) La cantidad de valores ingresados negativos.
    b) La cantidad de valores ingresados positivos.
    c) La cantidad de múltiplos de 15.
    d) El valor acumulado de los números ingresados que son pares. 
*/
using System;

class _7
{
    static void Main()
    {
        int positivos = 0, negativos = 0, multiplos15 = 0, par = 0;

        for (int i = 1; i <= 10;  i++)
        {
            Console.Write($"Ingrese valor {i,2}: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor >= 0)
            {
                positivos++;
            }
            else
            {
                negativos++;    
            }

            if (valor%15 == 0)
            {
                multiplos15++;
            }

            if (valor % 2 == 0)
            {
                par += valor;
            }
        }

        Console.WriteLine($"\nPositivos: {positivos} | Negativos: {negativos} | Múltiplos 15: {multiplos15} | Suma de pares: {par}");

        Console.WriteLine();
        Console.ReadKey();
        
    }
}

