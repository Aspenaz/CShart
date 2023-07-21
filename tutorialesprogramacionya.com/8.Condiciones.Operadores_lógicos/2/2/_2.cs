//Se ingresan tres valores por teclado, si todos son iguales se imprime
//la suma del primero con el segundo y a este resultado se lo multiplica
//por el tercero.

using System;

class _2
{
    static void Main()
    {
        float multi = 0;

        Console.Write("ingrese 1er valor: ");
        float num1 = float.Parse(Console.ReadLine());

        Console.Write("ingrese 2do valor: ");
        float num2 = float.Parse(Console.ReadLine());

        Console.Write("ingrese 3er valor: ");
        float num3 = float.Parse(Console.ReadLine());

        if (num1 == num2 && num1 == num3)
        {
            float suma = num1 + num2;

             multi = suma * num3;
        }

        Console.WriteLine($"Resultado: {multi}");

        Console.ReadKey();
    }
}

