/* Problema 2:
    Crear y cargar una matriz de 4 filas por 4 columnas. 
    Imprimir la diagonal principal.
*/

using System;

class Matriz2
{

    private int[,] mat;

    public void Cargar()
    {
        mat = new int[4, 4];

        for (int f = 0; f < 4; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                Console.Write($"Ingrese componente [{f + 1},{c + 1}]: ");
                mat[f, c] = int.Parse(Console.ReadLine());
            }    
            Console.WriteLine();
        }
    }


    public void ImprimirDiagonalPrincipal()
    {
        for (int k = 0; k < 4; k++)
        {
            Console.Write(mat[k, k] + " ");
        }
    }

    public void ImprimirDiagonal()
    {
        for (int f = 0; f < 4; f++)
        {
            for (int c = 0; c < 4; c++)
            {
                if(f == c)
                {
                    Console.Write($"{mat[f, c],2} ");
                }
            }
            Console.WriteLine();
        }
    }


    static void Main()
    {
        Matriz2 m = new Matriz2();

        m.Cargar();
        m.ImprimirDiagonalPrincipal();
        Console.WriteLine();
        m.ImprimirDiagonal();   

        Console.ReadKey();
        
    }
}

