using System;

class Analysis
{
    static void Main()
    {
        int rest = 0;
        int passes = 0;
        int failures = 0;
        int studentCounter = 1;

        while (studentCounter <= 10)
        {
            Console.Write($"{studentCounter}. Enter result (1 = pass, 2= fail): ");
            int result = int.Parse(Console.ReadLine());

            if (result == 1)
            {
                passes = passes + 1;
            }
            else if (result == 2)
            {
                failures = failures + 1;
            }
            else
            {
                rest = rest + 1;
            }

            studentCounter = studentCounter + 1;
        }

        Console.WriteLine($"Passed: {passes}\nFailed: {failures}\nRest: {rest}");

        if (passes > 8)
        {
            Console.WriteLine("Bonus to instructor");
        }
    }
}
