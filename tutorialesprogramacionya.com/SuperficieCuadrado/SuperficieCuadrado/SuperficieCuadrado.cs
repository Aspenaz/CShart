using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SuperficieCuadrado
{
    static void Main(string[] args)
    {
        //int lado;
        //int superficie;
        //String linea;
        Console.Write("Ingrese el valos del lado del cuadrado: ");
        int lado = int.Parse(Console.ReadLine());

        int superficie = lado * lado;

        Console.WriteLine($"La superficie del cuadrado es {superficie}");

        Console.ReadKey();  


    }
}

