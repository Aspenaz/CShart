/* Problema 2:
    Crear una matriz de n * m filas (cargar n y m por teclado). 
    Imprimir el mayor elemento y la fila y columna donde se almacena.
*/


using System;

class Matriz6
{
    private int[,] matriz;

    public void Cargar()
    {
        Console.Write("Ingrese cantidad de filas: ");
        int filas = int.Parse(Console.ReadLine());

        Console.Write("Ingrese cantidad de columnas: ");
        int columnas = int.Parse(Console.ReadLine());   

        matriz = new int[filas,columnas];

        for (int f = 0; f < matriz.GetLength(0); f++)
        {
            for (int c = 0; c < matriz.GetLength(1); c++)
            {
                Console.Write("Ingrese componente: ");
                matriz[f,c] = int.Parse(Console.ReadLine());    
            }
        }
    }

    public void ImprimirMayor()
    {
        int mayor = matriz[0,0];
        int filaMayor = 0;
        int columnaMayor = 0;

        for(int f = 0; f < matriz.GetLength(0); f++)
        {
            for(int c = 0;c < matriz.GetLength(1); c++)
            {
                if (matriz[f,c] > mayor)
                {
                    mayor = matriz[f,c];
                    filaMayor = f;
                    columnaMayor = c;   
                }
            }
        }
        Console.WriteLine("El elemento mayor es: " + mayor);
        Console.WriteLine("Se encuentra en la fima: " + filaMayor + " y en la columna: " + columnaMayor);
        Console.ReadLine();
    }


    static void Main()
    {
        Matriz6 m = new Matriz6();

        m.Cargar();
        m.ImprimirMayor();

        Console.ReadLine();
    }
}

