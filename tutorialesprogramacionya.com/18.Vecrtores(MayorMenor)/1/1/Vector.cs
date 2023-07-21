/* Cargar un vector de n elementos. imprimir el menor y un 
   mensaje si se repite dentro del vector.
*/


using System;

class Vector
{
    private float[] vector;

    public void Cargar()
    {
        Console.Write("Ingrese longitud del vector: ");
        int n = int.Parse(Console.ReadLine());

        vector = new float[n];

        for (int i = 0; i < vector.Length; i++)
        {
            Console.Write("Ingrese valor: ");
            vector[i] = float.Parse(Console.ReadLine());
        }
    }


    public void Men()
    {
        float men = vector[0];
        int pos = 0;
        string mensaje;

        for (int i = 0;i < vector.Length;i++)
        {
            if (vector[i] < men)
            {
                men = vector[i];
                pos = i;
            }
            if (men == vector[i])
            {
                mensaje = "Se repite";
            }
        }
        Console.WriteLine("Inferior: " + men);
        Console.WriteLine($"{mensaje}");
    }

    static void Main()
    {
        Vector v = new Vector();    

        v.Cargar(); 
        v.Men();

        Console.ReadKey();

    }
}

