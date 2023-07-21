// 7. Desarrollar un programa que permita cargar n números enteros y luego
// nos informe cuántos valores fueron pares y cuántos impares.
// Emplear el operador “%” en la condición de la estructura condicional:
// if (valor % 2 == 0)         //Si el if da verdadero luego es par.

using System;

class _7
{
    static void Main()
    {
        int cont = 1, cont_par = 0, cont_impar = 0;

        Console.Write("Ingrese cantidad de números: ");
        int cantidad = int.Parse(Console.ReadLine());

        while(cont <= cantidad)
        {
            Console.Write($"Ingrese valor {cont}: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                cont_par++;
            }
            else
            {
                cont_impar++;
            }

            cont++;
        }

        Console.WriteLine();
        Console.WriteLine($"Pares: {cont_par}");
        Console.WriteLine($"Impares: {cont_impar}");

        Console.ReadKey();

    }
}

