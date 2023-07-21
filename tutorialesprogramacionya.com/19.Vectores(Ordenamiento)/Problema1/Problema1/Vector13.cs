/* Problema 1:
    Se debe crear un vector donde almacenar 5 sueldos. Ordenar 
    el vector sueldos de menor a mayor.
*/

using System;

class Vector13
{
    private int[] sueldos;

    public void Cargar()
    {
        sueldos = new int[5];
        for(int f = 0; f < sueldos.Length; f++)
        {
            Console.Write("Ingrese sueldo: ");
            sueldos[f] = int.Parse(Console.ReadLine());
        }
    }


    public void Ordenar()
    {
        for(int k = 0; k < 4; k++)
        {
            for (int f = 0; f < 4 - k; f++)
            {
                if (sueldos[f] > sueldos[f + 1])
                {
                    int aux;
                    aux = sueldos[f];
                    sueldos[f] = sueldos[f + 1];
                    sueldos[f + 1] = aux;
                }
                
            }
        }
    }


    public void Imprimir()
    {
        Console.WriteLine("Sueldos de menor a mayor:");
        for(int f = 0; f < sueldos.Length; f++)
        {
            Console.WriteLine(sueldos[f]);
        }
    }


    static void Main()
    {
        Vector13 v = new Vector13();    

        v.Cargar(); 
        v.Ordenar();
        v.Imprimir();

        Console.ReadKey();
    }
}

