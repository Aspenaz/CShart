// 2. Se ingresan un conjunto de n alturas de personas por teclado.
// Mostrar la altura promedio de las personas.

using System;

class _2
{
    static void Main()
    {
        
        int conteo = 1;
        float suma = 0;

        Console.Write("Ingrese cantidad de personas: ");
        int cantidad = int.Parse(Console.ReadLine());

        while (conteo <= cantidad)
        {
            Console.Write($"Ingrese altura {conteo}: ");
            float altura = float.Parse(Console.ReadLine());

            suma += altura;

            conteo++;
        }
        float promedio = suma / cantidad;

        Console.WriteLine();
        Console.WriteLine($"Conteo: {conteo - 1}");
        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Promedio: {promedio}");
        
        Console.ReadKey();  

    }
}

