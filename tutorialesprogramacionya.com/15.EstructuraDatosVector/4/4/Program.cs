/* Cargar un vector de 10 elementos y verificar posteriormente si el mismo 
   está ordenado de menor a mayor.
*/


using System;

class Vector
{
    private int[] vector10;

    public void Carga()
    {
        vector10 = new int[10];

        Console.WriteLine("Carga de vector ");
        
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Ingrese valor {i + 1}/10: ");
            vector10[i] = int.Parse(Console.ReadLine()); 
        }
    }

    public void Verifica()
    {
        int bandera = 1;
        for (int i = 0;i < 9; i++)
        {
            if (vector10[i+1] < vector10[i])
            {
                bandera = 0;
            }
        }

        if (bandera == 0)
        {
            Console.WriteLine("No está ordenado de menor a mayor");
        }
        else
        {
            Console.WriteLine("Está ordenado");
        }
    }



    static void Main()
    {
        Vector v = new Vector();    
        v.Carga();  
        v.Verifica();

        Console.ReadKey();
    }
}

