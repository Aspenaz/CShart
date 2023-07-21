using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class SumaProducto
{
    static void Main(string[] args)
    {
        int num1, num2, suma, producto;

        Console.Write("Ingrese primer valor: ");
        num1 = int.Parse(Console.ReadLine());   

        Console.Write("Ingrese segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        suma = num1 +num2;
        producto = num1 * num2;

        Console.WriteLine($"La suma es: {suma}");
        Console.WriteLine($"El producto es: {producto}");

        Console.ReadKey();  

    }
}

