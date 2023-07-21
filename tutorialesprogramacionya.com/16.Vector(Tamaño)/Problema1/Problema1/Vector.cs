/* Problema 1:
    Se desea almacenar los sueldos de operarios. Cuando se ejecuta el programa 
    se debe pedir la cantidad de sueldos a ingresar. Luego crear un vector con 
    dicho tamaño.
*/

using System;

class Vector
{

    private int[] sueldos;

    public void Cargar()
    {
        Console.Write("Cantidad de sueldos a cargar: ");
        int cantidad = int.Parse(Console.ReadLine());

        sueldos = new int[cantidad];

        for (int f = 0; f < sueldos.Length; f++)
        {
            Console.Write($"Ingrese sueldo {f + 1}: ");
            sueldos[f] = int.Parse(Console.ReadLine());
        }
    }

    public void Imprimir()
    {
        for (int f = 0; f < sueldos.Length; f++)
        {
            Console.WriteLine(sueldos[f]);
        }
    }

    static void Main()
    {
        Vector v = new Vector();
        v.Cargar();
        v.Imprimir();

        Console.ReadKey();

    }
}

