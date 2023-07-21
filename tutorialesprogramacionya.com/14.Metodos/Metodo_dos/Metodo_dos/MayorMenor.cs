/* Problema 2:
    Confeccionar una clase que permita ingresar tres valores por teclado. 
    Luego mostrar el mayor y el menor.
*/

using System;


class MayorMenor
{
    public void cargarValores()
    {
        Console.Write("Ingrese 1er valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 2do valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 3er valor: ");
        int valor3 = int.Parse(Console.ReadLine());

        int numMayor = CalcularMayor(valor1, valor2, valor3);
        int numMenor = CalcularMenor(valor1, valor2, valor3);

        Console.WriteLine("El mayor es: " + numMayor);
        Console.WriteLine("El menor es: " + numMenor);  
    }

    public int CalcularMayor(int v1, int v2, int v3)
    {
        int m;
        if(v1 > v2 && v1 > v3)
        {
            m = v1;
        }
        else
        {
            if(v2 > v3)
            {
                m = v2;
            }
            else
            {
                m = v3;
            }
        }
        return m;
    }


    public int CalcularMenor(int v1, int v2, int v3)
    {
        int m;
        if(v1 < v2 && v1 < v3)
        {
            m = v1;
        }
        else
        {
            if(v2 < v3)
            {
                m = v2;
            }
            else
            {
                m = v3;
            }
        }
        return m;
    }


    static void Main()
    {
        MayorMenor mm = new MayorMenor();

        mm.cargarValores();
/*
        Console.Write("Ingrese 1er valor: ");
        int valor1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 2do valor: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese 3er valor: ");
        int valor3 = int.Parse(Console.ReadLine());

        int numMayor = mm.CalcularMayor(valor1, valor2, valor3);
        int numMenor = mm.CalcularMenor(valor1, valor2, valor3);

        Console.WriteLine("El mayor es: " + numMayor);
        Console.WriteLine("El menor es: " + numMenor);
*/
        Console.ReadKey();
    }
}

