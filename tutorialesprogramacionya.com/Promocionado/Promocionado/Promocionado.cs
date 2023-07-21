using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class Promocionado
{
    static void Main()
    {
        Console.Write("Ingrese nota 1: ");
        int nota1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nota 2: ");
        int nota2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese nota 3: ");
        int nota3 = int.Parse(Console.ReadLine());

        float promedio = (nota1 + nota2 + nota3) / 3;

        if (promedio >= 7)
        {
            Console.WriteLine($"Promedio: {promedio} | Promocionado");
        }
        else
        {
            Console.WriteLine($"Promedio: {promedio} | No Promocionado");
        }

        Console.ReadKey();  
    }
}

