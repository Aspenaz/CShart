// 1.Realizar un programa que acumule (sume) valores ingresados por teclado
// hasta ingresar el 9999 (no sumar dicho valor, indica que ha finalizado
// la carga). Imprimir el valor acumulado e informar si dicho valor es cero,
// mayor a cero o menor a cero.

using System;

class _1
{
    static void Main()
    {
        int valor, suma = 0; 
        do
        {
            Console.Write("Ingrese valor, (9999 para salir): ");
            valor = int.Parse(Console.ReadLine());

            if (valor != 9999)
            {
                suma += valor;
            }

        } while (valor != 9999);

        if (suma > 0)
        {
            Console.WriteLine("Valor es mayor a cero");
        }
        else
        {
            if (suma < 0)
            {
                Console.WriteLine("Valor es menor a cero");
            }
            else
            {
                Console.WriteLine("Valor es igual a cero");
            }
        }

        Console.WriteLine($"\nTotal: {suma}");        

        Console.ReadKey();

    }
}

