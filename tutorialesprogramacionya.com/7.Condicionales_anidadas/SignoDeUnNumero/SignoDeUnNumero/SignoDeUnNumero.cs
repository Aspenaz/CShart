//Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el número es positivo, nulo o negativo.


using System;

class SignoDeUnNumero
{
    static void Main()
    {
        Console.Write("Ingrese número: ");
        int num = int.Parse(Console.ReadLine());

        if (num > 0)
        {
            Console.WriteLine("Número es Positivo");
        }
        else
        {
            if (num == 0)
            {
                Console.WriteLine("Número es nulo");
            }
            else
            {
                Console.WriteLine("Numero es negativo");
            }
        }

    }
}

