
//Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y muestre un
//mensaje indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.


using System;

class TresCifras
{
    static void Main()
    {
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 10)
        {
            Console.WriteLine(" Número de una cifra");
        }
        else
        {
             if (num < 100)
            {
                Console.WriteLine("Número de dos cifras");
            }
             else
            {
                if (num < 1000)
                {
                    Console.WriteLine("Número de tres cifras");
                }
                else
                {
                    Console.WriteLine("Error: Número de cifras");
                }
            }
        }
    }
}

