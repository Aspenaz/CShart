/* Problema 1:
    Confeccionar un programa que permita cargar los nombres de 5 alumnos 
    y sus notas respectivas. Luego ordenar las notas de mayor a menor. 
    Imprimir las notas y los nombres de los alumnos.
*/

using System;

class Vector16
{
    private string[] nombres;
    private int[] notas;


    public void Cargar()
    {
        nombres = new string[5];
        notas = new int[5];

        Console.WriteLine("Carga de nombres y notas");

        for (int f = 0; f < nombres.Length; f++)
        {
            Console.Write("\nIngrese nombre: ");
            nombres[f] = Console.ReadLine();

            Console.Write("Ingrese nota: ");
            notas[f] = int.Parse(Console.ReadLine());
        }
    }


    public void Ordenar()
    {
        for(int k = 0;  k < notas.Length; k++)
        {
            for(int f = 0; f < notas.Length - 1 - k; f++)
            {
                if (notas[f] < notas[f + 1])
                {
                    int aux_nota;
                    aux_nota = notas[f];
                    notas[f] = notas[f + 1];
                    notas[f + 1] = aux_nota;

                    string aux_nombre;
                    aux_nombre = nombres[f];
                    nombres[f] = nombres[f + 1];
                    nombres[f + 1] = aux_nombre;
                } 
            }
        }
    }


    public void Imprimir()
    {
        Console.WriteLine("\nListas ordenadas\n");

        for(int f = 0; f < notas.Length; f++)
        {
            Console.WriteLine(nombres[f] + " - " + notas[f]);
        }
    }


    static void Main()
    {
        Vector16 v = new Vector16();

        v.Cargar(); 
        v.Ordenar();
        v.Imprimir();

        Console.ReadKey();
    }
}

