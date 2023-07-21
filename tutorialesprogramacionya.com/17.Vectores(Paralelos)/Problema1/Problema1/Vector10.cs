/* Problema 1:
    Desarrollar un programa que permita cargar 5 nombres de personas y sus 
    edades respectivas. Luego de realizar la carga por teclado de todos los 
    datos imprimir los nombres de las personas mayores de edad (mayores o 
    iguales a 18 años)
*/


using System;

class Vector10
{
    private string[] nombres;
    private int[] edades;

    public void Cargar()
    {
        nombres = new string[5];
        edades = new int[5];

        for (int f = 0; f < nombres.Length; f++)
        {
            Console.Write($"\n{f + 1}/5\nIngrese nombre:");
            nombres[f] = Console.ReadLine();

            Console.Write("Ingrese edad: ");
            edades[f] = int.Parse(Console.ReadLine());  
        }
    }


    public void MayoresEdad()
    {
        Console.WriteLine("\nPersonas mayores de edad:");

        for(int f = 0; f < nombres.Length; f++)
        {
            if (edades[f] >= 0)
            {
                Console.Write(nombres[f]);
                Console.WriteLine(" " + edades[f]);
            }
        }
    }


    static void Main()
    {
        Vector10 vector = new Vector10();

        vector.Cargar();    
        vector.MayoresEdad();

        Console.ReadKey();

    }
}

