// 5. Mostrar los múltiplos de 8 hasta el valor 500. Debe
// aparecer en pantalla 8 - 16 - 24, etc.

using System;

class _5
{
    static void Main()
    {
        int cont = 1;
        while ((cont*8) <= 500)
        {
            Console.Write($"{cont * 8} ");
            cont++;
        }

        Console.ReadKey();
        
    }
}

