using System;

class Sum
{
    static void Main()
    {
        int total = 0;

        for (int number = 2; number <= 20;  number += 2)
        {
            Console.Write($"{number} ");
            total += number;
        }

        Console.WriteLine($"\nSum is {total}");
    }
}