/* Problema 2:
    Definir un vector donde almacenar los nombres de 5 paises. Confeccionar 
    el algoritmo de ordenamiento alfabético.
*/

using System;

class Vector14
{
    private string[] paises;


    public void Cargar()
    {
        paises = new string[5];

        for (int f = 0; f < paises.Length; f++)
        {
            Console.Write("Ingrese nombre del país: ");
            paises[f] = Console.ReadLine();
        }
    }


    public void Ordenar()
    {
        for (int K = 0; K < 4; K++)
        {
            for(int f = 0; f < 4 - K; f++)
            {
                if (paises[f].CompareTo(paises[f + 1]) > 0)
                {
                    string aux;
                    aux = paises[f];
                    paises[f] = paises[f + 1];
                    paises[f + 1] = aux;    
                }
            }
        }
    }


    public void Imprimir()
    {
        Console.WriteLine("\nPaíses ordenados");

        for (int f = 0; f < paises.Length; f++)
        {
            Console.WriteLine(paises[f]);
        }
    }

    static void Main()
    {
        Vector14 v = new Vector14();

        v.Cargar(); 
        v.Ordenar();    
        v.Imprimir();

        Console.ReadKey();
    }
}

