/* Desarrollar un programa que permita ingresar un vector de n elementos, 
   ingresar n por teclado. Luego imprimir la suma de todos sus elementos.
*/
using System;

class N_elementos
{
    private int[] elemento;

    public void Carga()
    {
        Console.WriteLine("Vector de n elementos");

        Console.Write("Ingrese n: ");
        int n = int.Parse(Console.ReadLine());

        elemento = new int[n];

        for (int f = 0; f < n; f++)
        {
            Console.Write($"Ingrese elemento {f+1}: ");
            elemento[f] = int.Parse(Console.ReadLine());

        }        
    }


    public void Suma()
    {
        float suma = 0;
        
        for (int f = 0; f < elemento.Length; f++)
        {
            suma += elemento[f];
        }

        Console.WriteLine("Suma total: " + suma);
    }
    



    static void Main()
    {
        N_elementos n1 = new N_elementos();

        n1.Carga(); 
        n1.Suma();

        Console.ReadKey();

    }
}

