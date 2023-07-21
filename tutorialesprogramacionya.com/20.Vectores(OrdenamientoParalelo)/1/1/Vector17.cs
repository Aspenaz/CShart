/* Cargar en un vector los nombres de 5 paises y en otro vector paralelo 
   la cantidad de habitantes del mismo. Ordenar alfabéticamente e imprimir 
   los resultados. Por último ordenar con respecto a la cantidad de 
   habitantes (de mayor a menor) e imprimir nuevamente.
*/

using System;

class Vector17
{
    private string[] paises;
    private int[] habitantes;

    public void Cargar()
    {
        paises = new string[5];
        habitantes = new int[5];

        Console.WriteLine("Carga de Países y Habitantes");

        for (int i = 0; i < paises.Length; i++)
        {
            Console.Write("\nIngrese país: ");
            paises[i] = Console.ReadLine();

            Console.Write("Ingrese habitantes: ");
            habitantes[i] = int.Parse(Console.ReadLine());  
        }
    }

    public void OrdenarPorPais()
    {
        for(int k = 0; k < paises.Length; k++)
        {
            for (int f = 0; f < paises.Length -1 - k; f++)
            {
                if (paises[f].CompareTo(paises[f + 1]) > 0)
                {
                    string aux_pais;
                    aux_pais = paises[f];
                    paises[f] = paises[f + 1];
                    paises[f + 1] = aux_pais;

                    int aux_habitantes;
                    aux_habitantes = habitantes[f];
                    habitantes[f] = habitantes[f + 1];
                    habitantes[f+1] = aux_habitantes;   
                }
            }
        }
    }


    public void OrdenarPorHabitantes()
    {
        for (int k = 0; k < paises.Length; k++)
        {
            for (int f = 0; f < paises.Length - 1 - k; f++)
            {
                if (habitantes[f] > habitantes[f+1])
                {
                    string aux_pais;
                    aux_pais = paises[f];
                    paises[f] = paises[f + 1];
                    paises[f + 1] = aux_pais;

                    int aux_habitantes;
                    aux_habitantes = habitantes[f];
                    habitantes[f] = habitantes[f + 1];
                    habitantes[f + 1] = aux_habitantes;
                }
            }
        }
    }


    public void Imprimir()
    {
        Console.WriteLine("\nListas ordenadas\n");

        for (int f = 0; f < paises.Length; f++)
        {
            Console.WriteLine(paises[f] + " " + habitantes[f]);
        }
    }

    static void Main()
    {
        Vector17 v = new Vector17();

        v.Cargar();
        v.OrdenarPorPais();
        v.Imprimir();
        v.OrdenarPorHabitantes();
        v.Imprimir();   

        Console.ReadKey();
    }
}

