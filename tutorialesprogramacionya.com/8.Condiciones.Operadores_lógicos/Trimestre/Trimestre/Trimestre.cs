using System;


class Trimestre
{
    static void Main()
    {
        Console.Write("Ingrese día: ");
        int dia = int.Parse(Console.ReadLine());

        Console.Write("Ingrese mes: ");
        int mes = int.Parse(Console.ReadLine());

        Console.Write("Ingrese año: ");
        int año = int.Parse(Console.ReadLine());

        if (mes == 1 || mes == 2 || mes == 3)
        {
            Console.WriteLine("Corresponde al primer trimestre");
        }
        else
        {
            Console.WriteLine("No corresponde al pimer trimestre");
        }

        Console.ReadKey();  
    }
}

