/* Problema 2:
    Definir un vector de 5 componentes de tipo float que representen las 
    alturas de 5 personas.
    Obtener el promedio de las mismas. Contar cuántas personas son más altas 
    que el promedio y cuántas más bajas.
*/

using System;


class Vector2
{
    private float[] alturas;
    private float promedio;

    public void Cargar()
    {
        alturas = new float[5];

        for (int f = 0; f < 5; f++)
        {
            Console.Write($"Ingrese altura {f+1}: ");
            alturas[f] = float.Parse(Console.ReadLine());
        }
    }


    public void CalcularPromedio()
    {
        float suma = 0;

        for (int f = 0;f < 5; f++)
        {
            suma += alturas[f];
        }
        promedio = suma / 5;
        Console.WriteLine("Altura promedio: " + promedio);
    }


    public void MayoresMenores()
    {
        int may = 0, men = 0;

        for (int f = 0; f < 5; f++)
        {
            if (alturas[f] > promedio)
            {
                may++;
            }
            else
            {
                if (alturas[f] < promedio)
                {
                    men++;
                }
            }
        }
        Console.WriteLine("Cantidad mayores al promedio: " +may);
        Console.WriteLine("Cantidad menores al promedio: "+men);
        Console.ReadKey();
    }

    static void Main()
    {
        Vector2 v2 = new Vector2();

        v2.Cargar();
        v2.CalcularPromedio();
        v2.MayoresMenores();
    }
}

