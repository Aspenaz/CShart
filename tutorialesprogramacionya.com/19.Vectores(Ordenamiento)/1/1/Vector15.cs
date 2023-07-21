/* Cargar un vector de n elementos de tipo entero. Ordenar posteriormente 
   el vector.
*/


using System;


class Vector15
{
    private int[] vector;
    int n;


    public void Cargar()
    {
        Console.Write("Ingrese longitud del vector: ");
        n = int.Parse(Console.ReadLine());

        vector = new int[n];

        for(int f = 0; f < vector.Length; f++)
        {
            Console.Write($"Ingrese valor {f+1}: ");
            vector[f] = int.Parse(Console.ReadLine());
        }
    }


    public void Ordenar()
    {
        int l = n - 1;
        for (int k = 0; k < l; k++)
        {
            for(int f = 0; f < l - k; f++)
            {
                if (vector[f] > vector[f + 1])
                {
                    int aux;
                    aux = vector[f];
                    vector[f] = vector[f + 1];
                    vector[f + 1] = aux;
                }
            }
        }
    }


    public void Imprimir()
    {
        Console.WriteLine("\nVector ordenado: ");

        for (int k = 0; k < vector.Length; k++)
        {
            Console.Write(vector[k] + " ");
        }
    }


    static void Main()
    {
        Vector15 v = new Vector15();    

        v.Cargar(); 
        v.Ordenar();    
        v.Imprimir();

        Console.ReadKey();
    }
}

