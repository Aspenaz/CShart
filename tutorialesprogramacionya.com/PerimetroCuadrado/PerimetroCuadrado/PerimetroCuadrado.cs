using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PerimetroCuadrado
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese lado del cuadrado: ");
        int lado = int.Parse(Console.ReadLine());

        int perimetro = lado * 4;

        Console.WriteLine($"Perímetro: {perimetro}");

        Console.ReadKey();  
    }
}

