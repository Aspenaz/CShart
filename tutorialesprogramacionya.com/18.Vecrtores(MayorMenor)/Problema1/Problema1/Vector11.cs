/* Problema 1:
    Confeccionar un programa que permita cargar los nombres de 5 operarios 
    y sus sueldos respectivos. Mostrar el sueldo mayor y el nombre del operario.
*/

using System;

class Vector11
{
    private string[] nombres;
    private float[] sueldos;

    public void Cargar()
    {
        nombres = new string[5];
        sueldos = new float[5];

        for (int f = 0; f < nombres.Length; f++)
        {
            Console.Write($"\n{f + 1}\nIngrese nombre: ");
            nombres[f] = Console.ReadLine();

            Console.Write("Ingrese sueldo: ");
            sueldos[f] = float.Parse(Console.ReadLine());
        }
    }


    public void SueldoMayor()
    {
        float mayor;
        int pos;

        mayor = sueldos[0];
        pos = 0;

        for (int f = 0; f < nombres.Length; f++)
        {
            if (sueldos[f] > mayor)
            {
                mayor = sueldos[f];
                pos = f;
            }
        }
        Console.WriteLine("\nEmpleado con mayor sueldo: " + nombres[pos]);
        Console.WriteLine("Sueldo: " + mayor);
    }

    static void Main()
    {
        Vector11 v = new Vector11();

        v.Cargar(); 
        v.SueldoMayor();

        Console.ReadKey();
    }
}

