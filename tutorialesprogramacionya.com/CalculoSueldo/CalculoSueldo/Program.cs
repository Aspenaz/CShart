using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        //int horasTrabajadas;
        //float costoHora;
        //float sueldo;
        string linea;

        Console.Write("Ingrese horas trabajadas: ");
        // linea = Console.ReadLine();
        // horasTrabajadas = int.Parse(linea);
        int horasTrabajadas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese el pago por hora: ");
        // linea = Console.ReadLine();
        // costoHora = float.Parse(linea);
        float costoHora = float.Parse(Console.ReadLine());

        float sueldo = horasTrabajadas * costoHora;

        Console.Write($"El sueldo es: {sueldo} ");
        // Console.Write(sueldo)
        Console.WriteLine();    
        Console.ReadKey();

    }
}

