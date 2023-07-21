// 4. Realizar un programa que imprima 25 términos de la
// serie 11 - 22 - 33 - 44, etc.
// (No se ingresan valores por teclado)

using System;

class _4
{
    static void Main()
    {
        int cont = 1, termino = 11;

        while (cont <= 25)
        {            
            Console.WriteLine($"{cont,2} - {termino,3}");
            termino += 11;
            cont++;
        }

        Console.ReadKey();

    }
}

