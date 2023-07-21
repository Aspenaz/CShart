//Escribir un programa que pida ingresar la coordenada de un punto
//en el plano, es decir dos valores enteros x e y (distintos a cero).
//Posteriormente imprimir en pantalla en que cuadrante se ubica dicho
//punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0, etc.)

using System;

class _5
{
    static void Main()
    {
        Console.Write("Coordenada X: ");
        int coord_X = int.Parse(Console.ReadLine());

        Console.Write("Coordenada Y: ");
        int coord_Y = int.Parse(Console.ReadLine());

        if (coord_X > 0 && coord_Y > 0)
        {
            Console.WriteLine($"Coordenada <{coord_X}, {coord_Y}> se encuentra en el 1er Cuadrante");
        }
        if (coord_X < 0 && coord_Y > 0 )
        {
            Console.WriteLine($"Coordenada <{coord_X}, {coord_Y}> se encuentra en el 2do Cuadrante");
        }

        Console.ReadKey();
    }
}

