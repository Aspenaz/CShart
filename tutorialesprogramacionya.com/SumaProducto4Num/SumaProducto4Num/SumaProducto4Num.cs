using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class SumaProducto4Num
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese 1er número: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese 2do número: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese 3er número: ");
        float num3 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese 4to número: ");
        float num4 = float.Parse(Console.ReadLine());

        float Suma = num1 + num2;
        float Producto = num3 * num4;

        float SumaTotal = num1 + num2 + num3 + num4;
        float Promedio = SumaTotal / 4;


        Console.WriteLine($"Suma 1ro y 2do: {Suma,4}");
        Console.WriteLine($"Producto 3ro y 4to: {Producto,8:F}");
        Console.WriteLine();
        Console.WriteLine($"Suma total: {SumaTotal,4}");
        Console.WriteLine($"Promedio: {Promedio,6}");

        Console.ReadKey();  


    }
}

