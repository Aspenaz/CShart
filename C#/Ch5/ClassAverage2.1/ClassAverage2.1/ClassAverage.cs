class ClassAverage
{
    static void Main()
    {
        int total = 0;
        int gradeCounter = 0;

        Console.Write($"Enter grade or -1 to quit: ");
        int grade = int.Parse(Console.ReadLine());

        while (grade != -1)
        {
            total = total + grade;
            gradeCounter = gradeCounter + 1;

            Console.Write($"Enter grade or -1 to quit: ");
            grade = int.Parse(Console.ReadLine());
        }
        if (gradeCounter != 0)
        {
            double average = (double)total / gradeCounter;

            Console.WriteLine($"\nTotal de ingresos es {gradeCounter} sumando {total}");
            Console.WriteLine($"Promedio es {average:F}");
        }
        else
        {
            Console.WriteLine("Nada fue ingresado");
        }

    }
}