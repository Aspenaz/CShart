/* 1. Crear una matriz de 2 filas y 5 columnas. Realizar la carga 
    de componentes por columna (es decir primero ingresar toda la 
    primer columna, luego la segunda columna y así sucesivamente)
    Imprimir luego la matriz.
*/

using System;

class Matriz4
{
    private int[,] matriz;

    public void Cragar()
    {
        matriz = new int[2, 5];

        Console.WriteLine("\nCarga de la matriz por columna\n");

        for (int c = 0; c < 5; c++)
        {
            for (int f = 0; f < 2; f++)
            {
                Console.Write("Ingrese componente de la fila " + f + " y la columna " + c + ": ");
                matriz[f,c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }

    public void Imprimir()  
    {
        for (int f = 0; f< 2; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                Console.Write($"{matriz[f, c],2} ");
            } 
            Console.WriteLine() ;
        }
        Console.ReadKey();
    }

    static void Main()
    {
        Matriz4 m = new Matriz4();

        m.Cragar();
        m.Imprimir();

        Console.ReadKey();
    }
}

