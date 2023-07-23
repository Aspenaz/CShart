/* 1. Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar 
 *    la primer fila con la segunda. Imprimir luego la matriz.
 */


using System;

class Matriz7
{
    private int[,] matriz;

    public void Cargar()
    {
        Console.Write("Ingrese cantindad de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese cantidad de columnas: ");
        int columnas = int.Parse(Console.ReadLine());

        matriz = new int[filas, columnas];

        for(int f = 0; f < matriz.GetLength(0); f++)
        {            
            for(int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write("Ingrese componente: ");
                matriz[f,c] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }
    }


    public void IntercambiarFila1y2()
    {
        for(int c = 0; c < matriz.GetLength(1); c++)
        {
            int aux = matriz[0, c];
            matriz[0, c] = matriz[1, c];
            matriz[1, c] = aux;
        }
    }

    public void Imprimir()
    {
        for(int f = 0; f < matriz.GetLength(0); f++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write(matriz[f, c] + " ");
            }
            Console.WriteLine();
        }            
    }





    static void Main()
    {
        Matriz7 m = new Matriz7();  

        m.Cargar(); 
        m.Imprimir();   
        m.IntercambiarFila1y2();
        m.Imprimir();   

        Console.ReadKey();
    }
}

