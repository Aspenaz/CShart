/* Realizar un programa que pida la carga de dos vectores numéricos enteros 
   de 4 elementos. Obtener la suma de los dos vectores, dicho resultado 
   guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.
*/

using System;

class Vector
{
    private int[] vector1;
    private int[] vector2;
    private int[] sumaVectores;

    public void Carga()
    {
        vector1 = new int[4];
        vector2 = new int[4];

        Console.WriteLine("Vector 1");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Ingrese valor {i + 1}: ");
            vector1[i] = int.Parse( Console.ReadLine() );
        }

        Console.WriteLine("\nVector 2");
        for (int i = 0; i < 4; i++)
        {
            Console.Write($"Ingrese valor {i + 1}: ");
            vector2[i] = int.Parse(Console.ReadLine());
        }
    }

    public void SumaVectores()
    {
        sumaVectores = new int[4];

        for (int i = 0; i < 4; i++)
        {
            sumaVectores[i] = vector1[i] + vector2[i];
        }

        Console.WriteLine("\nSuma de Vectores: ");
        Console.Write("< ");
        for (int i = 0;i < 4; i++)
        {
            Console.Write($"{sumaVectores[i]} ");
        }
        Console.WriteLine(">");
    }




    static void Main()
    {
        Vector v = new Vector();

        v.Carga();
        v.SumaVectores();

        Console.ReadKey();

    }
}

