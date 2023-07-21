//Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información:
//cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente.
//Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel del mismo según
//el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:
/*
    Nivel máximo:	Porcentaje >= 90 %.
    Nivel medio:	Porcentaje >= 75 % y < 90 %.
    Nivel regular:	Porcentaje >= 50 % y < 75 %.
    Fuera de nivel:	Porcentaje < 50 %.
*/
using System;
class Test
{
    static void Main()
    {
        Console.Write("Total de preguntas: ");
        int totalPreguntas = int.Parse(Console.ReadLine());

        Console.Write("Total Correctas: ");
        int totalCorrectas = int.Parse(Console.ReadLine());

        double porcentaje = (totalCorrectas * 100) / totalPreguntas;

        Console.Write($"Porcentaje correptas: {porcentaje}%");

        if (porcentaje >= 90)
        {
            Console.WriteLine(" | Nivel máximo!");
        }
        else
        {
            if (porcentaje >= 75)
            {
                Console.WriteLine(" | Nivel medio!");
            }
            else
            {
                if (porcentaje >= 50)
                {
                    Console.WriteLine(" | Nivel regular!");
                }
                else
                {
                    Console.WriteLine(" | Fuera de nivel");
                }
            }
        }

        Console.ReadKey();  
    }
}

