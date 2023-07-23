using System;

class Matriz8
{
    private int[,] matriz;

    public void Cargar()
    {
        Console.Write("Ingrese cantindad de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese cantidad de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        matriz = new int[filas, columnas];

        for (int f = 0; f < matriz.GetLength(0); f++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write("Ingrese componente: ");
                matriz[f, c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }


    public void ImprimirVertices()
    {
        Console.WriteLine("Vértice superior izquierdo: " + matriz[0,0]);
        Console.WriteLine("Vértice superior derecho: " + matriz[0, matriz.GetLength(1)-1]);
        Console.WriteLine("Vértice inferior izquierdo: " + matriz[matriz.GetLength(0)-1,0]);
        Console.WriteLine("Vértice inferior derecho: " + matriz[matriz.GetLength(0)-1, matriz.GetLength(1)-1]);

        Console.ReadKey();
    }


    static void Main()
    {
        Matriz8 m = new Matriz8();

        m.Cargar();
        m.ImprimirVertices();

        Console.ReadKey();

    }
}

