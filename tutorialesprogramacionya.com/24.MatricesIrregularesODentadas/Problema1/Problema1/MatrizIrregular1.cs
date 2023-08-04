/* Problema 1:
    Confeccionaremos un programa que permita crear una matriz irregular 
    y luego imprimir la matriz en forma completa.
*/

using System;

class MatrizIrregular1
{
    private int[][] mat;

    public void Cargar()
    {
        Console.Write("Filas que tiene la matriz: ");
        int filas = int.Parse(Console.ReadLine());

        mat = new int[filas][];

        for (int f = 0; f < mat.Length; f++)
        {
            Console.Write("Elementos que tiene la fila: " + f + ": ");
            int elementos = int.Parse(Console.ReadLine());

            mat[f] = new int[elementos];

            for(int c = 0; c < mat[f].Length; c++)
            {
                Console.Write("Ingrese componente: ");
                mat[f][c] = int.Parse(Console.ReadLine());  
            }
        }
    }

    public void Imprimir()
    {
        for(int f = 0; f < mat.Length; ++f)
        {
            for(int c = 0; c < mat[f].Length ; c++)
            {
                Console.Write(mat[f][c] + " ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }


    static void Main()
    {
        MatrizIrregular1 m = new MatrizIrregular1();
        m.Cargar();
        m.Imprimir();
    }
}

