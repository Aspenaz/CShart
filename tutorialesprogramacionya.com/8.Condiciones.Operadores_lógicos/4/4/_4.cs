//Se ingresan por teclado tres números, si al menos uno de los
//valores ingresados es menor a 10, imprimir en pantalla la
//leyenda "Alguno de los números es menor a diez".


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class _4
{
    static void Main()
    {
        Console.Write("Ingrese 1er valor: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 2do valor: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 3er valor: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 < 10 || num2 < 10 || num3 < 10)
        {
            Console.WriteLine("Al menos uno de los números es menor a diez");
        }

        Console.ReadKey();
    }
}

