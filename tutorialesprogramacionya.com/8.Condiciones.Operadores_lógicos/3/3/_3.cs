using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _3
{
    static void Main()
    {
        Console.Write("Ingrese 1er valor: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 2do valor: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 3er valor: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 < 10 && num2 < 10 && num3 < 10)
        {
            Console.WriteLine("Todos los valores son menos que 10.");

        }
        Console.ReadKey();
    }
}

