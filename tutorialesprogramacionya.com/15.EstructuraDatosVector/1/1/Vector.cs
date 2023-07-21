/* 1. Desarrollar un programa que permita ingresar un vector de 8 elementos, 
    e informe:
    El valor acumulado de todos los elementos del vector.
    El valor acumulado de los elementos del vector que sean mayores a 36.
    Cantidad de valores mayores a 50.
*/


using System;


class Vector
{
    private float[] vector8;
    
    public void Cargar()
    {
        vector8 = new float[8];
        
        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Ingrese valor {i + 1}: ");
            vector8[i] = float.Parse( Console.ReadLine() );
        } 
    }

    public void Acumulado()
    {
        float suma = 0;

        for (int i = 0; i < 8; i++)
        {
            suma += vector8[i];
        }
        Console.WriteLine("Suma total: " + suma);
    }

    public void MayoresA36()
    {
        float suma36 = 0;

        for (int i = 0; i < 8; i++)
        {
            if (vector8[i] > 36)
            {
                suma36 += vector8[i];
            }
        }
        Console.WriteLine("Suma mayores a 36: " + suma36);
    }

    public void MayoresA50()
    {
        int count50 = 0;    
        
        for (int i = 0; i < 8; i++)
        {
            if (vector8[i] > 50)
            {
                count50++;
            }
        }
        Console.WriteLine("Cantidad mayores a 50: " + count50); 
    }



    static void Main()
    {
        Vector v = new Vector();
        v.Cargar();
        v.Acumulado();  
        v.MayoresA36();
        v.MayoresA50();

        Console.ReadKey();
    }
}

