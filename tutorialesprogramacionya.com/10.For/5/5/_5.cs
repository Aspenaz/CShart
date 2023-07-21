// 5. Realizar un programa que lea los lados de n triángulos, e informar:
// a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados
//    iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
// b) Cantidad de triángulos de cada tipo.
// c) Tipo de triángulo que posee menor cantidad.

using System;

class _5
{
    static void Main()
    {
        int count_equilatero = 0, count_isoceles = 0, count_escaleno = 0;

        Console.Write("Ingrese cantidad de triángulos: ");
        int num_tri = int.Parse(Console.ReadLine());

        for (int i = 1; i <= num_tri; i++)
        {
            Console.WriteLine($"\nTriángulo {i}:");

            Console.Write("Ingrese lado 1: ");
            int lado1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese lado 2: ");
            int lado2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese lado 3: ");
            2int lado3 = int.Parse(Console.ReadLine());


            if (lado1 == lado2 && lado1 == lado3)
            {
                Console.WriteLine("Es triángulo equilátero");
                count_equilatero++;
            }
            else
            {
                if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Es triángulo isósceles");
                    count_isoceles++;
                }
                else
                {
                    Console.WriteLine("Es triángulo escaleno");
                    count_escaleno++;
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine($"\nEquiláteros: {count_equilatero} | Isósceles: {count_isoceles} | Escaleno: {count_escaleno}");
        //Console.WriteLine($"Isósceles: {count_isoceles}");
        //Console.WriteLine($"Escaleno: {count_escaleno}");

        if (count_equilatero < count_isoceles && count_equilatero < count_escaleno)
        {
            Console.WriteLine("\nEquilatero posee menor cantidad");
        }
        else
        {
             if (count_isoceles < count_escaleno)
            {
                Console.WriteLine("\nIsóceles posee menor cantidad");
            }
             else
            {
                Console.WriteLine("\nEscaleno posee menor cantidad");
            }
        }

        Console.ReadKey();
    }
}

