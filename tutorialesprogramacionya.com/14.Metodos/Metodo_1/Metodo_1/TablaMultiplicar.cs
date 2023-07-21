/* Confeccionar una clase que permita ingresar valores enteros por teclado y 
 * nos muestre la tabla de multiplicar de dicho valor. Finalizar el programa 
 * al ingresar el -1.
*/

using System;

class TablaMultiplicar
{
    private int valor;

    public void Inicia()
    {
        Console.Write("Ingrese valor: ");
        valor = int.Parse(Console.ReadLine());  
    }
     
    public void Tabla()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{valor} * {i} = {valor * i}");
        }
    }


    static void Main()
    {
        TablaMultiplicar tm1 = new TablaMultiplicar();

        tm1.Inicia();   
        tm1.Tabla();

        Console.ReadKey();
    }
}

