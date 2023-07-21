/* Problema 1:
    Se desea guardar los sueldos de 5 operarios.
*/

using System;

class Vector1
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[5];

        for (int f = 0; f < 5; f++)
        {
            Console.Write("Ingrese valor: ");
            sueldos[f] = int.Parse(Console.ReadLine());
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < 5; f++)
        {
            Console.WriteLine(sueldos[f]);
        }
       // Console.ReadKey();
    }

    static void Main()
    {
        Vector1 v1 = new Vector1();
        v1.Cargar();
        v1.Imprimir();

        Console.ReadKey();

    }
}

