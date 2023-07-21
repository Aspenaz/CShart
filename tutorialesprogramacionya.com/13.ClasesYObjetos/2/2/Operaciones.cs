/* Implementar la clase operaciones. Se deben cargar dos valores enteros, 
 * calcular su suma, resta, multiplicación y división, cada una en un método, 
 * imprimir dichos resultados.
*/

using System;

class Operaciones
{
    private int entero1, entero2, suma, resta;
   // private float multiplicacion, division;

    public void Imput()
    {
        Console.Write("Ingrese entero 1: ");
        entero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingrese entero 2: ");
        entero2 = int.Parse(Console.ReadLine());
    }

    public void Suma()
    {
       int suma = entero1 + entero2;
       Console.WriteLine($"Suma: {suma}");
    }

    public void Resta()
    {
        int resta = entero1 - entero2;
        Console.WriteLine($"Resta: {resta}");
    }

    public void Multiplica()
    {
        int multipli = entero1 * entero2;
        Console.WriteLine($"Multiplicación: {multipli}");
    }

    public void Division()
    {
        float div = entero1 / entero2;
        Console.WriteLine($"División: {div}");
    }


    static void Main()
    {
        Operaciones op1 = new Operaciones();

        op1.Imput();
        op1.Suma();
        op1.Resta();
        op1.Multiplica();   
        op1.Division(); 
        //Console.WriteLine($"Suma: {op1.suma}");

        Console.ReadKey();

    }
}

