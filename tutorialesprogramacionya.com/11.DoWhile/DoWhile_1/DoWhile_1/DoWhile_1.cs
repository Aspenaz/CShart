/* Problema 1:
    Escribir un programa que solicite la carga de un número entre 0 y 999, y 
    nos muestre un mensaje de cuántos dígitos tiene el mismo. Finalizar el 
    programa cuando se cargue el valor 0.
*/

using System;

class DoWhile_1
{
    static void Main()
    {
        int valor;

        do
        {
            Console.Write("Ingrese valor entre 0 y 999. (0 finaliza): ");
            valor = int.Parse(Console.ReadLine());

            if (valor >= 100)
            {
                Console.WriteLine("Tiene 3 dígitos");
            }
            else
            {
                if (valor >= 10)
                {
                    Console.WriteLine("Tiene 2 dígitos");
                }
                else
                {
                    Console.WriteLine("Tiene 1 dígito");
                }
            }
        } while (valor != 0);
    }
}

