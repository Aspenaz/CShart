// 1. Confeccionar un programa que lea n pares de datos, cada par de
// datos corresponde a la medida de la base y la altura de un
// triángulo. El programa deberá informar:
// a) De cada triángulo la medida de su base, su altura y su superficie.
// b) La cantidad de triángulos cuya superficie es mayor a 12.


using System;


class _1
{
    static void Main()
    {
        int cantidad;
        float superficie;

        cantidad = 0;

        Console.Write("Ingrese cantidad de triángulos: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine();

        for (int f = 1; f <= n; f++)
        {
            Console.Write("Base: ");
            int base_tri = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            int altura_tri = int.Parse(Console.ReadLine());

            superficie = (float) base_tri * altura_tri / 2;

            Console.WriteLine($"Superficie: {superficie}");
            Console.WriteLine();

            if (superficie > 12)
            {
                cantidad++;
            }
        }

        Console.WriteLine($"Superficies mayores a 12: {cantidad}");

        Console.ReadKey();
        

    }
}

