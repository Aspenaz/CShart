/* Problema 3:
    Crear y cargar una matriz de 3 filas por 4 columnas. 
    Imprimir la primer fila. Imprimir la última fila e imprimir 
    la primer columna.
*/

using System;

class Matriz3
{
    private int[,] mat;


    public void Cargar()
    {
        mat = new int[3, 4];

        for(int f= 0; f < 3; f++)
        {
            for(int c= 0; c < 4; c++)
            {
                Console.Write($"Ingrese componente [{f+1},{c+1}]: ");
                mat[f, c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();    
        }
    }

    public void PrimeraFila()
    {
        Console.WriteLine("\nPrimera fila: ");

        for (int c = 0; c < 4; c++)
        {
            Console.WriteLine(mat[0,c]);
        }
    }


    public void UltimaFila()
    {
        Console.WriteLine("\nUltima fila: ");

        for(int c = 0; c < 4; c++)
        {
            Console.WriteLine(mat[2,c]);
        }
    }


    public void PrimeraColumna()
    {
        Console.WriteLine("\nPrimera columna:");

        for(int f= 0; f < 3; f++)
        {
            Console.WriteLine(mat[f,0]);
        }
    }


    static void Main()
    {
        Matriz3 m = new Matriz3();

        m.Cargar();
        m.PrimeraFila();
        m.UltimaFila();
        m.PrimeraColumna();

        Console.ReadKey();
    }
}

