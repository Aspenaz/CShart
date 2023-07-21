class ClassAverage
{
    static void Main()
    {
        int total = 0;
        int gradeCounter = 0;

        while (gradeCounter <= 10)
        {
            Console.Write("Enter grade: ");
            int grade = int.Parse(Console.ReadLine());
            total = total + grade;

            gradeCounter = gradeCounter + 1;

            Console.WriteLine($"Total: {total} ");
            Console.WriteLine($"gradeCounter: {gradeCounter}\n");
        }

        //int average = total / 10;
        int average = total / gradeCounter;

        //Console.WriteLine($"\nTotal of all 10 grades is {total}");
        Console.WriteLine($"Total af all {gradeCounter} grades is {total}");
        Console.WriteLine($"Class average is {average}");
    }
}