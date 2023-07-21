using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OperadoresLógicos
{
    static void Main()
    {
        Console.Write("Ingrese primer valor: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo valor: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.Write("Ingrese tercer valor: ");
        float num3 = float.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine($"Mayor es {num1}");
        }
        else
        {
             if (num2 > num3)
            {
                Console.WriteLine($"Mayor es {num2}");
            }
            else
            {
                Console.WriteLine($"Mayor es {num3}");
            }
        }

        Console.ReadKey();
    }
}

