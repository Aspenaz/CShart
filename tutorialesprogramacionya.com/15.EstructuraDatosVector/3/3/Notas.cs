/* Se tienen las notas del primer parcial de los alumnos de dos cursos, 
   el curso A y el curso B, cada curso cuenta con 5 alumnos.
  Realizar un programa que muestre el curso que obtuvo el mayor 
  promedio general.
*/

using System;


class Notas
{
    private int[] notasA;
    private int[] notasB;

    public void Carga()
    {
        notasA = new int[5];
        notasB = new int[5];

        Console.WriteLine("Curso A");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese nota {i + 1}: ");
            notasA[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nCurso B");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Ingrese nota {i + 1}: ");
            notasB[i] = int.Parse(Console.ReadLine());
        }
    }

    public void Promedio()
    {
        int sumaA = 0, sumaB = 0, promedioA, promedioB;
        for (int i = 0;i < 5; i++)
        {
            sumaA += notasA[i];
            sumaB += notasB[i];
        }
        promedioA = sumaA / 5;
        promedioB = sumaB / 5;
        
        if (promedioA > promedioB)
        {
            Console.WriteLine("\nCurso A tiene mayor promedio");
        }
        else
        {
            if(promedioB > promedioA)
            {
                Console.WriteLine("\nCurso B tiene mayor promedio");
            }
            else
            {
                Console.WriteLine("\nCurso A y B tienen igual promedio");
            }
        }
    }


    static void Main()
    {
        Notas n = new Notas();

        n.Carga();
        n.Promedio();

        Console.ReadKey();
    }
}

