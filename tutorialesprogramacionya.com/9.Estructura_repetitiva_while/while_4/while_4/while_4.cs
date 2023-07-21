// Problema 4:
// Una planta que fabrica perfiles de hierro posee un lote de n piezas.
// Confeccionar un programa que pida ingresar por teclado la cantidad de
// piezas a procesar y luego ingrese la longitud de cada perfil; sabiendo
// que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30 son
// aptas. Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.

using System;

class while_4
{
    static void Main()
    {
        int conteo = 1, aptas = 0; 

        Console.Write("Cantiad de piezas a procesar: ");
        int cantidad = int.Parse(Console.ReadLine());

        while (conteo <= cantidad)
        {
            Console.Write($"Longitud del perfil {conteo}: ");
            float longitud = float.Parse(Console.ReadLine());

            if (longitud >= 1.20 && longitud <= 1.30)
            {
                aptas += 1;
            }

            conteo++;
        }

        Console.WriteLine($"\nCantidad piezas aptas: {aptas}");

        Console.ReadKey();
    }
}

