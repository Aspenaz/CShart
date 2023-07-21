// 1. Escribir un programa que solicite ingresar 10 notas de alumnos y nos
// informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.

using System;

class _1
{
    static void Main()
    {
        int cantidad = 1, cant_may_7 = 0 , cant_men_7 = 0;

        while (cantidad <= 10)
        {
            Console.Write($"Ingrese nota {cantidad,2}: ");
            float nota = float.Parse( Console.ReadLine() );            
            
            if (nota >= 0 && nota <= 10)
            {
                cantidad++;

                if (nota >= 7)
                {
                    cant_may_7++;
                }
                else
                {
                    cant_men_7++;   
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese valores entre 0 y 10");
            }

            
        }

        Console.WriteLine($"\n>= 7: {cant_may_7}");
        Console.WriteLine($"< 7: {cant_men_7}");

        Console.ReadKey();
    }
}

