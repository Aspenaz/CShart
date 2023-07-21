// 3. Escribir un programa que lea 10 notas de alumnos y nos
// informe cuántos tienen notas mayores o iguales a 7 y
// cuántos menores.

// Para resolver este problema se requieren tres contadores:
// aprobados(Cuenta la cantidad de alumnos aprobados)
// reprobados(Cuenta la cantidad de reprobados)
// f(es el contador del for)


using System;

class Notas
{
    static void Main()
    {
        int aprobados = 0, reprobados = 0, f;

        for (f=1; f<= 10; f++)
        {
            Console.Write($"Ingrese nota {f}: ");
            int nota = int.Parse( Console.ReadLine() );

            if (nota >= 0 && nota <= 10)
            {            
                if(nota >= 7)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }
            else
            {
                Console.WriteLine("Error: Ingrese valores entre 0 y 10");
            }
        }

        Console.WriteLine($"\nAprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");

        Console.ReadKey();
    }
}

