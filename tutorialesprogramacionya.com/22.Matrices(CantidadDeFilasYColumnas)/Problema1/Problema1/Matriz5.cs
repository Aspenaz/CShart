/* Problema 1:
    Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir 
    la matriz completa y la última fila.
*/

using System;

class Matriz5
{
    private int[,] matriz;

    public void Cargar()
    {
        Console.Write("Ingrese cantidad de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingresa cantida de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        matriz = new int[filas, columnas];

        for(int c = 0; c < matriz.GetLength(0); c++)
        {
            for (int f = 0; f < matriz.GetLength(1); f++)
            {
                Console.Write($"Ingrese componente: ");
                matriz[f,c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < matriz.GetLength(0); f++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write($"{matriz[f, c], 2} ");
            }
            Console.WriteLine();    
        }
    }


    public void ImprimeUltimaFila()
    {
        Console.WriteLine("\nUltima fila");

        for(int c = 0; c < matriz.GetLength(1) - 1; c++)
        {
            Console.Write(matriz[matriz.GetLength(0) - 1, c] + " ");
        }
    }

    static void Main()
    {
        Matriz5 m = new Matriz5();

        m.Cargar();
        m.Imprimir();
        m.ImprimeUltimaFila();

        Console.ReadKey();
    }
}

