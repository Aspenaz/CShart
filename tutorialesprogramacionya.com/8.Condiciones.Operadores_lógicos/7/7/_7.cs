// Escribir un programa en el cual: dada una lista de tres valores numéricos distintos
// se calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos)


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _7
{
    static void Main()
    {
        Console.Write("1er número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("2do número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("3er número: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 < num2 && num1 < num3)
        {
            Console.Write(num1);
        }
        else
        {
             if (num2 < num3)
            {
                Console.Write(num2);
            }
            else
            {
                Console.Write(num3);
            }
        }

        Console.Write(" - ");

        if (num1 > num2 && num1 > num3)
        {
            Console.Write(num1);
        }
        else
        {
            if (num2 > num3)
            {
                Console.Write(num2);
            }
            else
            {
                Console.Write(num3);
            }
        }

        Console.ReadKey();  
    }
}

