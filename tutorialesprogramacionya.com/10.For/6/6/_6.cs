// 6. Escribir un programa que pida ingresar coordenadas (x,y) que
//    representan puntos en el plano.
//    Informar cuántos puntos se han ingresado en el primer,
//    segundo, tercer y cuarto cuadrante. Al comenzar el programa
//    se pide que se ingrese la cantidad de puntos a procesar.

using System;

class _6
{
    static void Main()
    {
        int cuad_1 = 0, cuad_2 = 0, cuad_3 = 0, cuad_4 = 0;

        Console.Write("Cantidad de puntos a procesar: ");
        int cant_puntos = int.Parse(Console.ReadLine());

        for (int i = 1; i <= cant_puntos; i++)
        {
            Console.WriteLine($"\nPunto {i}");

            Console.Write("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Ingrese y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                cuad_1++;
            }
            if ( x < 0 && y > 0)
            {
                cuad_2++; 
            }
            if (x < 0 && y < 0)
            {
                cuad_3++;
            }
            if (x > 0 && y < 0)
            {
                cuad_4++;   
            }
        }

        Console.WriteLine($"\n1er Cuadrante: {cuad_1} | 2do Cuadrante: {cuad_2} | 3er Cuadrante: {cuad_3} | 4to Cuadrante: {cuad_4}");

        Console.WriteLine();
    }
}

