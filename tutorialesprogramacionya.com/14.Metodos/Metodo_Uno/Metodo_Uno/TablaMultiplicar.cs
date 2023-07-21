/* Problema 1:
    Confeccionar una clase que permita ingresar valores enteros por teclado y 
    nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa 
    al ingresar el -1.
*/

using System;

class TablaMultiplicar
{
    public void CargarValor()
    {
        int valor;
        do
        {
            Console.Write("Ingrese valor (-1 finaliza): ");
            valor = int.Parse(Console.ReadLine());

            if (valor != -1)
            {
                Calcular(valor);
            }
        } while (valor != -1);
    }

    public void Calcular(int v)
    {
        for(int f = v; f <= v*10; f = f + v)
        {
            Console.Write(f + "-");
        }
        Console.WriteLine();
    }


    static void Main()
    {
        TablaMultiplicar tm = new TablaMultiplicar();
        tm.CargarValor();

        Console.ReadKey();
    }
}

