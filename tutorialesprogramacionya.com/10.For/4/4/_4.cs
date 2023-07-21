// 4. Confeccionar un programa que permita ingresar un valor del 1 al 10
// y nos muestre la tabla de multiplicar del mismo (los primeros 13
// términos)
// Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores
// 3, 6, 9, hasta el 39.


using System;

class _4
{
    static void Main()
    {
        Console.Write("Ingrese valor del 1 al 10: ");
        int valor = int.Parse(Console.ReadLine());

        if (valor >= 1 && valor <= 10)
        {
            for (int i = 1; i <= 13; i++)
            {
                Console.WriteLine($"{valor} * {i,2} = {valor * i}");
            }
        }
        else
        {
            Console.WriteLine("Error: Ingrese valores entre 1 y 10.");
        }
            

        Console.ReadKey();
    }
}

