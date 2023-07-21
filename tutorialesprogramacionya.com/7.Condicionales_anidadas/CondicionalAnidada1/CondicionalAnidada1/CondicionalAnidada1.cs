using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CondicionalAnidada1
{
    static void Main()
    {
        Console.Write("Ingrese primera nota: ");
        int nota1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese segundo nota: ");
        int nota2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese tercera nota: ");
        int nota3 = int.Parse(Console.ReadLine());

        float promedio = (nota1 + nota2 + nota3)/3;   

        if (promedio >= 7)
        {
            Console.WriteLine($"Promedio: {promedio} | Promocionado");
        }
        else
        {
            if (promedio >= 4)
            {
                Console.WriteLine($"Promedio: {promedio} | Regular");
            }
            else
            {
                Console.WriteLine($"Promedio: {promedio} | Reprobado");
            }
        }

        Console.ReadKey();

    }
}

