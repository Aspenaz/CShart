/* Problema 1:
    Crear una matriz de 3 filas por 5 columnas con elementos de 
    tipo int, cargar sus componentes y luego imprimirlas.
*/


using System;


class Matriz1
{
    private int[,] mat;


    public void Cargar()
    { 
        mat = new int[3, 5];

        for (int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                Console.Write($"Ingrese componente [{f+1},{c+1}]: ");
                mat[f,c] = int.Parse( Console.ReadLine() );
            }
            Console.WriteLine();    
        }
    }


    public void Imprimir()
    {
        for(int f = 0; f < 3; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                Console.Write($"{mat[f, c],2} ");
            }
            Console.WriteLine();
        }
    }



    static void Main()
    {
        Matriz1 m = new Matriz1();
        m.Cargar();
        m.Imprimir();

        Console.ReadKey();
    }
}

